using _2_services.Interfaces;
using _2_services.Models;
using _3_repositories.Entities;
using _3_repositories.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_services.Services
{
    public class PersonService : IPersonService
    {
        IPersonRepository rep;
        IMapper mapper;
     
        public PersonService(IPersonRepository rep, IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }

        public PersonModel Add(PersonModel model)
        {
            return mapper.Map<PersonModel>(rep.Add(mapper.Map<Person>(model)));
        }

        public void Delete(int key)
        {
            rep.Delete(key);
        }

        public List<PersonModel> GetAll()
        {
            List<Person> list = rep.GetAll();
            List<PersonModel> listToReturn = new List<PersonModel>();

            foreach (var item in list)
            {

                listToReturn.Add(mapper.Map<PersonModel>(item));
            }
            return listToReturn;
        }

        public PersonModel GetById(int key)
        {
            return mapper.Map<PersonModel>(rep.GetById(key));
        }

        public List<PersonModel> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(PersonModel model)
        {
            rep.Update(mapper.Map<Person>(model));
        }





    }
}
