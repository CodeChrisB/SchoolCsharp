using System;
using System.Collections.Generic;
using System.Text;

namespace DemoReflection.Attributes
{

    [AttributeUsage(AttributeTargets.Property)]
    public class DataPropertyInfoAttribute : Attribute
    {
        public bool isRequierd { get; set; }
        public int length { get; set; } = -1;

        //req
        //length if idk then -1

    }
}
