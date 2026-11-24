using System.Globalization;
using System.Windows.Data;

namespace NtfyDesktop.Features.Shell.Converters;

// "just now" / "5m ago" / "3h ago" / "yesterday" / absolute date for older entries.
public sealed class RelativeTimeConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is not DateTimeOffset ts) return string.Empty;

        var delta = DateTimeOffset.Now - ts;

        if (delta.TotalSeconds < 60) return Loc.T("just now");
        if (delta.TotalMinutes < 60) return Loc.F("{0}m ago", (int)delta.TotalMinutes);
        if (delta.TotalHours < 24)   return Loc.F("{0}h ago", (int)delta.TotalHours);
        if (delta.TotalDays < 2)     return Loc.T("yesterday");
        if (delta.TotalDays < 7)     return Loc.F("{0}d ago", (int)delta.TotalDays);

        return ts.LocalDateTime.ToString(Loc.IsFrench ? "d MMM yyyy" : "MMM d, yyyy", Loc.IsFrench ? CultureInfo.CurrentCulture : culture);
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture) =>
        throw new NotSupportedException();
}
