using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMS_WebAPI.Models
{
    public interface IPerson
    {
        public List<Phone> Phones { get; set; }
    }
}
