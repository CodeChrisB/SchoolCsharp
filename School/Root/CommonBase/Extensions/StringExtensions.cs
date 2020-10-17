using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace CommonBase.Extensions
{
    public static class StringExtensions
    {
        public static bool HasContent(this string source)
        {
            return string.IsNullOrEmpty(source) == false;
        }

        public static Int32 toInt32(this string source)
        {
            if (source == null)
                throw new ArgumentNullException();

            //String resultString = Regex.Match(source, @"\d+").Value;
            //return Int32.Parse(resultString);
            Int32 result = 0;
            source.Where(c => char.IsDigit(c))
                .MyForEach(c =>
                {
                    result *= 10;
                    result += c - '0';
                });

                return result;
        }
    }
}
