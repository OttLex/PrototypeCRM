using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeCRM.DataAccess
{
    public interface IRepository<T> where T: class
    {
        T GetObject(int id);
        List<T> GetListObjects();

        void Create(T obj);
        void Update(T obj);
        void Delete(T obj);
    }
}
