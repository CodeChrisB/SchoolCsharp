using System;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class IsTestedAttribute : Attribute
    {
        public override String ToString()
        {
            return "Is tested!";
        }
    }
}
