using System.Globalization;
using System.Windows.Data;

namespace NtfyDesktop;

/// <summary>One-way converter that translates a bound English string (see <see cref="Loc"/>).</summary>
public sealed class LocConverter : IValueConverter
{
    public static readonly LocConverter Instance = new();

    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture) =>
        value is string s ? Loc.T(s) : value;

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture) =>
        throw new NotSupportedException();
}
