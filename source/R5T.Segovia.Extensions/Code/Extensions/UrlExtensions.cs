using System;

using R5T.Magyar;


// Use Flurl namespace since adding a reference to this project is indication enough of a desire to use these extensions.
namespace Flurl
{
    public static class UrlExtensions
    {
        public static string Build(this Url url)
        {
            var output = url.ToString();
            return output;
        }

        /// <summary>
        /// Since Flurl does not have an option to prefix a relative URL with a <see cref="Strings.Slash"/>, with build method does so.
        /// </summary>
        public static string BuildRelative(this Url url)
        {
            var output = $"{Strings.Slash}{url}";
            return output;
        }

        public static Url SetPath(this Url url, string path)
        {
            url.Path = path;

            return url;
        }

        public static Url SetQuery(this Url url, string query)
        {
            url.Query = query;

            return url;
        }
    }
}
