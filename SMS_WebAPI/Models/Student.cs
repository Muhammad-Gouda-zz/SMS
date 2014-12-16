using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMS_WebAPI.Models
{
    public class Student : IPerson
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }
        public string FirstName { get; set; }
        
        public DateTime BirthDate { get; set; }
        public Decimal AgeOnOctober { get; set; }
        public Grade Grade { get; set; }
        public List<Parent> Parent { get; set; }
        public List<Phone> Phones { get; set; }
        public DateTime JoinDate { get; set; }
        public List<Student> Brothers { get; set; }
        public string PhotoUrl { get; set; }
        public string Address { get; set; }
        public Area Area { get; set; }

    }
}