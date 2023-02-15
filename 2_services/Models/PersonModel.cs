using _3_repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_services.Models
{
    public enum EMean { Male, Female }
    public enum EHMO { Maccabi, Meuchedet, Klallit, Leumit }
    public class PersonModel
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TZ { get; set; }
        public DateTime DOB { get; set; }
        public EMean Mean { get; set; }
        public EHMO HMO { get; set; }
        //public List<Child> Children { get; set; }

    }
}
