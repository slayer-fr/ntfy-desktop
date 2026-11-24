using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Threading;

namespace NtfyDesktop;

/// <summary>
/// Minimal localisation layer. English is the source language (all UI strings stay as
/// written in XAML / code); when Windows' display language is French, <see cref="T"/>
/// returns the French text, and <see cref="Install"/> translates static XAML text
/// (TextBlock, Button/Menu content, headers, tooltips, placeholders, window titles)
/// as elements load and, as a safety net, by sweeping open windows a few times a second.
/// Strings with no translation are shown unchanged. Only values set locally (XAML
/// attributes / code) are touched: bound values are translated at their source.
/// </summary>
public static partial class Loc
{
    public static bool IsFrench { get; private set; } =
        CultureInfo.CurrentUICulture.TwoLetterISOLanguageName.Equals("fr", StringComparison.OrdinalIgnoreCase);

    /// <summary>Translates an English string (returns it unchanged when no translation exists).</summary>
    public static string T(string en) =>
        IsFrench && Fr.TryGetValue(en, out var fr) ? fr : en;

    /// <summary>Translates a composite-format string, then formats it.</summary>
    public static string F(string en, params object?[] args) =>
        string.Format(CultureInfo.CurrentCulture, T(en), args);

    private static bool _installed;
    private static DispatcherTimer? _sweepTimer;
    private static readonly Dictionary<Type, PropertyInfo?> PlaceholderProps = new();

    /// <summary>Hooks the XAML text translator. Call once at startup, on the UI thread.</summary>
    public static void Install()
    {
        if (_installed || !IsFrench) return;
        _installed = true;

        // handledEventsToo = true: a control that marks Loaded as handled must not hide it from us.
        EventManager.RegisterClassHandler(typeof(FrameworkElement), FrameworkElement.LoadedEvent,
            new RoutedEventHandler((s, _) => TranslateOne(s as DependencyObject)), true);

        _sweepTimer = new DispatcherTimer(DispatcherPriority.ApplicationIdle)
        {
            Interval = TimeSpan.FromMilliseconds(300),
        };
        _sweepTimer.Tick += (_, _) => Sweep();
        _sweepTimer.Start();
    }

    private static void Sweep()
    {
        try
        {
            var app = Application.Current;
            if (app is null) return;

            foreach (var w in app.Windows.Cast<Window>().ToArray())
                TranslateTree(w);
        }
        catch
        {
            // Localisation must never break the UI.
        }
    }

    private static void TranslateTree(DependencyObject root)
    {
        var stack = new Stack<DependencyObject>();
        stack.Push(root);

        while (stack.Count > 0)
        {
            var d = stack.Pop();
            TranslateOne(d);

            if (d is not (Visual or System.Windows.Media.Media3D.Visual3D)) continue;

            var n = VisualTreeHelper.GetChildrenCount(d);
            for (var i = 0; i < n; i++)
                stack.Push(VisualTreeHelper.GetChild(d, i));
        }
    }

    private static void TranslateOne(DependencyObject? d)
    {
        if (d is null) return;

        try
        {
            if (d is TextBlock tb)
                SetIfString(tb, TextBlock.TextProperty);

            if (d is Window w)
                SetIfString(w, Window.TitleProperty);

            if (d is ContentControl cc && !IsGeneratedForDataString(cc))
                SetIfString(cc, ContentControl.ContentProperty);

            if (d is HeaderedContentControl hcc)
                SetIfString(hcc, HeaderedContentControl.HeaderProperty);

            if (d is HeaderedItemsControl hic)
                SetIfString(hic, HeaderedItemsControl.HeaderProperty);

            if (d is FrameworkElement fe)
            {
                SetIfString(fe, FrameworkElement.ToolTipProperty);
                TranslatePlaceholder(fe);
            }
        }
        catch
        {
            // ignore: an element we can't translate stays in English
        }
    }

    // A container generated for a data item (e.g. a ComboBoxItem showing a string from the view
    // model) is translated at its source; an item that is its own container (NavigationViewItem) is not.
    private static bool IsGeneratedForDataString(ContentControl cc)
    {
        var ic = ItemsControl.ItemsControlFromItemContainer(cc);
        return ic?.ItemsSource is not null
            && ic.ItemContainerGenerator.ItemFromContainer(cc) is string;
    }

    // Only plain string values set in XAML/code (locally or by a template); bindings,
    // TemplateBindings, styles and inherited values are skipped.
    private static void SetIfString(DependencyObject d, DependencyProperty dp)
    {
        var src = DependencyPropertyHelper.GetValueSource(d, dp);
        if (src.IsExpression) return;
        if (src.BaseValueSource is not (BaseValueSource.Local or BaseValueSource.ParentTemplate)) return;
        if (d.GetValue(dp) is not string current || current.Length == 0) return;

        var t = T(current);
        if (t != current) d.SetValue(dp, t);
    }

    // WPF-UI TextBox / NumberBox / PasswordBox / AutoSuggestBox expose PlaceholderText.
    private static void TranslatePlaceholder(FrameworkElement fe)
    {
        var type = fe.GetType();
        if (!PlaceholderProps.TryGetValue(type, out var prop))
        {
            try { prop = type.GetProperty("PlaceholderText", BindingFlags.Public | BindingFlags.Instance); }
            catch (AmbiguousMatchException) { prop = null; }
            PlaceholderProps[type] = prop;
        }

        if (prop is not { CanRead: true, CanWrite: true } || prop.PropertyType != typeof(string)) return;
        if (prop.GetValue(fe) is not string text || text.Length == 0) return;

        var t = T(text);
        if (t != text) prop.SetValue(fe, t);
    }
}
