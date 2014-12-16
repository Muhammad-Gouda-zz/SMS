using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SMS_WebAPI.Models
{
    public class SMSContext : DbContext
    {
        public SMSContext()
            : base("name=DefaultConnection")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Area> Areas { get; set; }
        
    }
}