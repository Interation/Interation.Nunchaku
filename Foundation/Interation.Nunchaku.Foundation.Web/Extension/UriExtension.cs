using System.Text.RegularExpressions;

namespace System
{
    public static class UriExtension
    {
        public static string GetQueryString(this Uri uri, string key)
        {
            var regex = new Regex(key.ToLower() + "=([^&]*)");
            var match = regex.Match(uri.ToString());

            return match.Groups.Count == 2 ? match.Groups[1].Value : string.Empty;
        }

        public static string SetQueryString(this Uri uri, string key, string value)
        {
            // TODO
            return string.Empty;
        }

        public static string RemoveQueryString(this Uri uri, string key)
        {
            // TODO
            return string.Empty;
        }
    }
}
