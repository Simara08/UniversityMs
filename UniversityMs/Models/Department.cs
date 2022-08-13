using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public DateTime Date { get; set; }
        public Sem_Offering SemOffering { get; set; }
        public  ICollection<Depfaculty> Depfaculty { get; set; }
        public  ICollection<CourseDep> CourseDep { get; set; }
        public  ICollection<DepUser> DepUsers { get; set; }
    }
}
