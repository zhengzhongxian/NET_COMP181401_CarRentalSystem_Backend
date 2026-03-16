namespace NET_CarRentalSystem.Shared.Utilities;

public static class DateTimeHelper
{
    /// <summary>
    /// Parse date string from eKYC format (dd/MM/yyyy) to DateTime
    /// </summary>
    /// <param name="dateString">Date string in dd/MM/yyyy format</param>
    /// <returns>Parsed DateTime or null if invalid</returns>
    public static DateTime? ParseDate(string? dateString)
    {
        if (string.IsNullOrEmpty(dateString) || dateString == "-")
            return null;

        if (DateTime.TryParseExact(dateString, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out var date))
            return date;

        return null;
    }

    /// <summary>
    /// Parse date string with multiple format support
    /// </summary>
    /// <param name="dateString">Date string</param>
    /// <param name="formats">Array of supported formats</param>
    /// <returns>Parsed DateTime or null if invalid</returns>
    public static DateTime? ParseDateMultiFormat(string? dateString, params string[]? formats)
    {
        if (string.IsNullOrEmpty(dateString) || dateString == "-")
            return null;

        if (formats == null || formats.Length == 0)
            formats = new[] { "dd/MM/yyyy", "yyyy-MM-dd", "MM/dd/yyyy" };

        if (DateTime.TryParseExact(dateString, formats, null, System.Globalization.DateTimeStyles.None, out var date))
            return date;

        return null;
    }

    /// <summary>
    /// Format DateTime to dd/MM/yyyy string
    /// </summary>
    /// <param name="date">DateTime to format</param>
    /// <returns>Formatted date string or empty string if null</returns>
    public static string FormatDate(DateTime? date)
    {
        return date?.ToString("dd/MM/yyyy") ?? string.Empty;
    }

    /// <summary>
    /// Format DateTime to custom format string
    /// </summary>
    /// <param name="date">DateTime to format</param>
    /// <param name="format">Custom format string</param>
    /// <returns>Formatted date string or empty string if null</returns>
    public static string FormatDate(DateTime? date, string format)
    {
        return date?.ToString(format) ?? string.Empty;
    }
}

