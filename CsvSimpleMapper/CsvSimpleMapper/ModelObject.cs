using CsvSimpleMapper.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsvSimpleMapper
{
    class ModelObject
    {
        [DataPropertyInfo(OrderPosition =0)]
        public int Id { get; set; }
    }
}
