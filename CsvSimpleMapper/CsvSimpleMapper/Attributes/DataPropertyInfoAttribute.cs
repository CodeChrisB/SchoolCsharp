using System;
using System.Collections.Generic;
using System.Text;

namespace CsvSimpleMapper.Attributes
{

    [AttributeUsage(AttributeTargets.Property,AllowMultiple =false)]
    class DataPropertyInfoAttribute : Attribute
    {

        public bool isRequierd { get; set; }
        public int OrderPosition { get; set; }

    }
}
