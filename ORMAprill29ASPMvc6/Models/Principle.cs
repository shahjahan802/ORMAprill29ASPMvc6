using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORMAprill29ASPMvc6.Models
{
    public class Principle
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string CNIC { get; set; }
        public string Adress { get; set; }
        public DateTime? DOB { get; set; }


    }
}
