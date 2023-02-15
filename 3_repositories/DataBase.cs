using _3_repositories.Entities;
using _3_repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _3_repositories
{
    public class DataBase : DbContext, IDataBase
    {
        public System.Data.Entity.DbSet<Person> People { get ; set ; }
        public System.Data.Entity.DbSet<Child> Children { get ; set ; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;DataBase=User4;Trusted_Connection=true");
            base.OnConfiguring(optionsBuilder);
        }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
