using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class DocLogs
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int TranskriptId { get; set; }
        public int ArayishId { get; set; }
        public int ErizeId { get; set; }
        public DocTranskript Transkript { get; set; }
        public DocArayish Arayish { get; set; }
        public DocErize Erize { get; set; }
    }
}
