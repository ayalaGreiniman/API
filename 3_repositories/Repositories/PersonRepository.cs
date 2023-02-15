using _3_repositories.Entities;
using _3_repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_repositories.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        IDataBase _dataBase;
        public PersonRepository(IDataBase dataBase)
        {
            _dataBase= dataBase;
        }
        public Person Add(Person model)
        {
            _dataBase.People.Add(model);
            _dataBase.SaveChanges();    
            return model;
        }

        public void Delete(int key)
        {
            _dataBase.People.Remove(_dataBase.People.ToList()[key]);
        }

        public List<Person> GetAll()
        {
            return _dataBase.People.ToList();
        }

        public Person GetById(int key)
        {
            return _dataBase.People.First(k => k.PersonId == key);
        }

        public List<Person> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(Person model)
        {
            for (int i = 0; i < _dataBase.People.Count(); i++)
            {
                if (_dataBase.People.ToList()[i].PersonId == model.PersonId)
                {
                    _dataBase.People.ToList()[i].FirstName = model.FirstName;
                    _dataBase.People.ToList()[i].LastName = model.LastName;
                    _dataBase.People.ToList()[i].TZ = model.TZ;
                    _dataBase.People.ToList()[i].DOB = model.DOB;
                    _dataBase.People.ToList()[i].Mean = model.Mean;
                    _dataBase.People.ToList()[i].HMO = model.HMO;                 
                }
            }
        }
    }
}
