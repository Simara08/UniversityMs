using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Helpers
{
    public  static class Role
    {
       public enum RoleType:byte
        {
            Admin,
            Mentor,
            Student

        }
    }
}
