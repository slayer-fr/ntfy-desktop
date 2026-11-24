using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;

namespace NtfyDesktop;

/// <summary>
/// Minimal localisation layer. English is the source language (all UI strings stay as
/// written in XAML / code); when Windows' display language is French, <see cref="T"/>
/// returns the French text, and <see cref="Install"/> translates static XAML text
/// (TextBlock, Button/Menu content, headers, tooltips, placeholders, window titles)
/// as each element loads. Strings with no translation are shown unchanged.
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

    /// <summary>Hooks the XAML text translator. Call once at startup.</summary>
    public static void Install()
    {
        if (_installed || !IsFrench) return;
        _installed = true;

        EventManager.RegisterClassHandler(typeof(FrameworkElement),
            FrameworkElement.LoadedEvent, new RoutedEventHandler(OnElementLoaded));
        EventManager.RegisterClassHandler(typeof(FrameworkContentElement),
            FrameworkContentElement.LoadedEvent, new RoutedEventHandler(OnContentElementLoaded));
    }

    private static void OnElementLoaded(object sender, RoutedEventArgs e)
    {
        try
        {
            if (sender is not FrameworkElement el) return;

            switch (el)
            {
                case TextBlock tb when tb.Inlines.Count == 0
                                       || (tb.Inlines.Count == 1 && tb.Inlines.FirstInline is Run):
                    Translate(tb, TextBlock.TextProperty, tb.Text, v => tb.Text = v);
                    break;
                case Window w:
                    Translate(w, Window.TitleProperty, w.Title, v => w.Title = v);
                    break;
            }

            if (el is ContentControl cc && cc.Content is string content)
                Translate(cc, ContentControl.ContentProperty, content, v => cc.Content = v);

            if (el is HeaderedContentControl hcc && hcc.Header is string h1)
                Translate(hcc, HeaderedContentControl.HeaderProperty, h1, v => hcc.Header = v);

            if (el is HeaderedItemsControl hic && hic.Header is string h2)
                Translate(hic, HeaderedItemsControl.HeaderProperty, h2, v => hic.Header = v);

            if (el.ToolTip is string tip)
                Translate(el, FrameworkElement.ToolTipProperty, tip, v => el.ToolTip = v);

            // WPF-UI TextBox / NumberBox / PasswordBox / AutoSuggestBox expose PlaceholderText.
            var ph = el.GetType().GetProperty("PlaceholderText", BindingFlags.Public | BindingFlags.Instance);
            if (ph is { CanRead: true, CanWrite: true } && ph.PropertyType == typeof(string)
                && ph.GetValue(el) is string phText && phText.Length > 0)
            {
                var translated = T(phText);
                if (!ReferenceEquals(translated, phText) && translated != phText)
                    ph.SetValue(el, translated);
            }
        }
        catch
        {
            // Localisation must never break the UI.
        }
    }

    private static void OnContentElementLoaded(object sender, RoutedEventArgs e)
    {
        try
        {
            if (sender is Run run && !BindingOperations.IsDataBound(run, Run.TextProperty))
            {
                var t = T(run.Text);
                if (t != run.Text) run.Text = t;
            }
        }
        catch
        {
            // ignore
        }
    }

    private static void Translate(DependencyObject d, DependencyProperty dp, string current, Action<string> set)
    {
        if (string.IsNullOrEmpty(current)) return;
        if (BindingOperations.IsDataBound(d, dp)) return; // bound values are translated at their source
        var t = T(current);
        if (t != current) set(t);
    }
}
