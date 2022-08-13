using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class Program
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public Sem_Offering SemOffering { get; set; }
        public ICollection<DepUser> DepUsers { get; set; }
    }
}
