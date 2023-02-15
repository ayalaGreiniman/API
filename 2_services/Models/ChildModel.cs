using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_services.Models
{
    public class ChildModel
    {
        public int ChildId { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string TZ { get; set; }
        public string ParentTZ { get; set; }

    }
}
