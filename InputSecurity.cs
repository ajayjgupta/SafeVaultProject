
using System.Text.RegularExpressions;
using System.Net;

public static class InputSecurity
{
    public static string Sanitize(string input)
    {
        if (string.IsNullOrEmpty(input)) return string.Empty;
        string cleaned = Regex.Replace(input, "<.*?>", string.Empty);
        return WebUtility.HtmlEncode(cleaned);
    }

    public static bool IsValidUsername(string username)
    {
        return Regex.IsMatch(username, @"^[a-zA-Z0-9_]{3,50}$");
    }
}
