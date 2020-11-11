using System;
using System.Collections.Generic;
using System.Text;

namespace CsvSimpleMapper.Attributes
{

    [AttributeUsage(AttributeTargets.Property,AllowMultiple =false)]

    class DataClassAttribute : Attribute 
    {
        public string Filename { get; set; }
        public string Seperator { get; set; } = ";";
        public bool notMapped { get; set; } = false;
    }
}
