using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_repositories.Entities
{
    public class Child
    {
        public int ChildId { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public string TZ { get; set; }
        public string ParentTZ { get; set; }


    }
}
