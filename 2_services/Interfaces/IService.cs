using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_services.Interfaces
{
    public interface IService<T>
    {
        T Add(T model);
        void Update(T model);
        void Delete(int key);
        T GetById(int key);
        List<T> GetAll();

        //List<T> Search(int id = 0, string searchstring = "");

    }
}
