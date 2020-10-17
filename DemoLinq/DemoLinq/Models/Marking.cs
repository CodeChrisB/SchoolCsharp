using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLinq.Models
{
    class Marking: ModelObject
    {
        public int StudentId { get; set; }
     
        public string Course { get; set; }
        public int  Mark { get; set; }

    }
}
