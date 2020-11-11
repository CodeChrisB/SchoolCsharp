using System;
using System.Collections.Generic;
using System.Text;

namespace CommonBase.Exentensions
{
    public static class ObjectExentsions
    {
        public static void CheckArgument(this object source,string name)
        {
            if (source == null)
                throw new ArgumentNullException(name);
        }
    }
}
