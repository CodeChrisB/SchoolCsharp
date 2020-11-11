using System;
using System.Collections.Generic;
using System.Text;
using DemoReflection.Attributes;

namespace DemoReflection
{
    //we do not have to write Attribute because all DataClasses end with Attribute
    [DataClass(sourcename ="unkown")]
    public class Person
    {
        [DataPropertyInfo(isRequierd =true,length =50,Order=1,DefaultValue=String.Empty)]
        public string Lastname { get; set; }
        
        [DataPropertyInfo(isRequierd = true, length = 50)]
        public string Firstname { get; set; }

        [DataPropertyInfo(isRequierd = true, length = 50,Calculation=true)]
        public string FullName => $"{Lastname} {Firstname}";
    }
}
