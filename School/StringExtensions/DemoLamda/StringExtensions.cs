using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLamda
{
    public static class StringExtensions
    {
        public static bool HasContent(this string source)
        {
            return !string.IsNullOrEmpty(source);
        }
    }
}
