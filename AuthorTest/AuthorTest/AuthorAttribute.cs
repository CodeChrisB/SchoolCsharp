using System;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class AuthorAttribute : Attribute
    {
        public String Name { get; set; }   
        public String Version { get; set; }

        public AuthorAttribute(String name): this(name, ""){}

        public AuthorAttribute(String name, String version)
        {
            Name = name;
            Version = version;
        }

        public override String ToString()
        {
            return $"{Name} {Version}";
        }
    }
}
