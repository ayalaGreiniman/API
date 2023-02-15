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
    public class ChildService : IChildService
    {
        IChildRepository rep;
        IMapper mapper;

        public ChildService(IChildRepository rep, IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }
        public ChildModel Add(ChildModel model)
        {
            return mapper.Map<ChildModel>(rep.Add(mapper.Map<Child>(model)));
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<ChildModel> GetAll()
        {
            List<Child> list = rep.GetAll();
            List<ChildModel> listToReturn = new List<ChildModel>();

            foreach (var item in list)
            {

                listToReturn.Add(mapper.Map<ChildModel>(item));
            }
            return listToReturn;
        }

        public ChildModel GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<ChildModel> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(ChildModel model)
        {
            throw new NotImplementedException();
        }
    }
}
