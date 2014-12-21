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

        [Required]
        public string FirstName { get; set; }
        
        public DateTime BirthDate { get; set; }
        [NotMapped]
        public Decimal AgeOnOctober { get; set; }
        public Grade Grade { get; set; }
        public List<Parent> Parents { get; set; }

        public Gender Gender { get; set; }
        
        [NotMapped]
        public Parent Father {
            get 
            {
                if (Parents == null)
                    return null;
                return Parents.SingleOrDefault(p => p.RelationType == RelationType.Father);
            }
            set 
            {
                if(Parents == null)
                {
                    throw new Exception("You have to set Parents first");
                }
                
                if (Father == null)
                {
                    value.RelationType = RelationType.Father;
                    Parents.Add(value);
                }
                else
                {
                    throw new Exception("Only one Father is allowed, remove current to replace him");
                }
            }
        }
        public List<Phone> Phones { get; set; }
        public DateTime JoinDate { get; set; }
        
        //Brothers are all students of the same parent
        [NotMapped]
        public List<Student> Brothers 
        {
            get 
            {
                //return all children of my father except me
                return Father.Children.SkipWhile(s=>s.Id == Id).ToList();
            }             
        }
        public string PhotoUrl { get; set; }
        public string Address { get; set; }
        public Area Area { get; set; }

    }
}