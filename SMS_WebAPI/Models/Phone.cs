using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMS_WebAPI.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public IPerson Owner  { get; set; }
    }
}
