using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMS_WebAPI.Models
{
    public class Parent : IPerson
    {
        public int Id { get; set; }
        public List<Student> Children { get; set; }
        public string FullName { get; set; }
        public RelationType RelationType { get; set; }
        public List<Phone> Phones { get; set; }
        
    }
}
