using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLamda
{
    public static class Extensions
    {
        public static void CheckArgument(this object source, string name) 
        {
            if (source == null)
            {
                throw new ArgumentNullException(name);
            }    
        }
    }
}
