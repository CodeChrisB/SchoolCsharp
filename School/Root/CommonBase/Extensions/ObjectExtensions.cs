using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace CommonBase.Extensions
{
    public static class ObjectExtensions
    {
        public static bool checkArgument(this string source,string name)
        {
            if (source == null)
                throw new ArgumentNullException();

            return true;


        }
    }
}
