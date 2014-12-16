using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SMS_WebAPI.Models
{
    public class SMSDatabaseInitializer : CreateDatabaseIfNotExists<SMSContext> 
    {
        protected override void Seed(SMSContext context)
        {
            base.Seed(context);

            var students = new List<Student>();

            students.Add(new Student
            {
                FirstName = "Zeyad",
                Address = "Abbaseya"
            });
        }

    }
}