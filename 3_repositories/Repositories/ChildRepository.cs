using _3_repositories.Entities;
using _3_repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_repositories.Repositories
{
    public class ChildRepository : IChildRepository
    {
        IDataBase dataBase;
        public ChildRepository(IDataBase dataBase)
        {
            this.dataBase = dataBase;
        }
        public Child Add(Child model)
        {
            dataBase.Children.Add(model);
            return model;
        }

        public void Delete(int key)
        {

        }

        public List<Child> GetAll()
        {
            throw new NotImplementedException();
        }

        public Child GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<Child> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(Child model)
        {
            throw new NotImplementedException();
        }
    }
}
