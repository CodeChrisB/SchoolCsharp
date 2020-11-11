using System;
using System.Collections.Generic;
using System.Text;

namespace DemoReflection.Attributes
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple =false)]
    public class DataClassAttribute : Attribute
    {
        public string sourcename;

    }
}
