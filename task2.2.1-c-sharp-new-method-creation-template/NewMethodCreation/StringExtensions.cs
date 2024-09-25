using System;
using System.Globalization;

namespace NewMethodCreation
{
    public static class StringExtensions
    {
        public static string? ToTitleCase(this string? str)
        {
            if (str == null)
                return null;

            if (string.IsNullOrWhiteSpace(str))
                return str;

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(str.ToLower());
        }
    }
}