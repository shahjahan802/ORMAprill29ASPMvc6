using System;
using System.Collections.Generic;

namespace ORMAprill29ASPMvc6.Models
{
    public partial class Studinfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cnic { get; set; }
        public string Adress { get; set; }
        public DateTime? Dob { get; set; }
    }
}
