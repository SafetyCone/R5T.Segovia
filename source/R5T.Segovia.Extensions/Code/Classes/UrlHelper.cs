using System;

using R5T.Magyar;


// Use Flurl namespace since adding a reference to this project is indication enough of a desire to use this class.
namespace Flurl
{
    public static class UrlHelper
    {
        public static readonly string RelativeUrlBase = Strings.Empty;


        public static Url NewRelativeUrl()
        {
            // Relative URL is empty URL.
            var url = new Url();
            return url;
        }
    }
}
