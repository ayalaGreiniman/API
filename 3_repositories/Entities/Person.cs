using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_repositories.Entities
{
    public enum EMean { Male, Female }
    public enum EHMO { Maccabi, Meuchedet, Klallit, Leumit }
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TZ { get; set; }
        public string DOB { get; set; }
        public EMean Mean { get; set; }
        public EHMO HMO { get; set; }

        //public List<Child> Children { get; set; }

        
    }
}
