using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SMS_WebAPI.Models
{
    public class Parent : IPerson
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }
        public List<Student> Children { get; set; }
        public string FullName { get; set; }
        public RelationType RelationType { get; set; }
        public List<Phone> Phones { get; set; }
        
    }
}
