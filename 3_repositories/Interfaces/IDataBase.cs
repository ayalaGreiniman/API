using _3_repositories.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_repositories.Interfaces
{
    public interface IDataBase
    {
        DbSet<Person> People { get; set; }
        DbSet<Child> Children { get; set; }
        int SaveChanges();
    }
}
