using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.Models;

namespace UniversityMs.ViewModels
{
    public class HomeVM
    {
        public List<Slide> Slides { get; set; }
        public List<Graduate> Graduates { get; set; }
        public List<Project> Projects { get; set; }
        public List<Partner> Partners { get; set; }
        public List<Mezun> Mezunlar { get; set; }

    }
}
