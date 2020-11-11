using CsvSimpleMapper.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CsvSimpleMapper
{
    class Person : ModelObject
    {
        //order=1
        [DataClass(Filename ="Person.csv")]

        [DataPropertyInfo(isRequierd =true,OrderPosition =2)]
        public string firstname { get; set; }
        [DataPropertyInfo(isRequierd = true, OrderPosition = 3)]

        public string lastname { get; set; }

        public int id { get; set; }

       public Person(int id,string fname,string lname)
        {
            this.id = id;
            firstname = fname;
            lastname = lname;
        }
        [DataClass(notMapped =true)]
        public string Fullname => $"{firstname} {lastname}";

    }
}
