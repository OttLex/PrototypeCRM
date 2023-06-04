using PrototypeCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeCRM.DataAccess
{
    public class EmployesRepositoryEF : IRepository<Employer>
    {
        AppDbContext db = new AppDbContext();
        public void Create(Employer obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Employer obj)
        {
            throw new NotImplementedException();
        }

        public List<Employer> GetListObjects()
        {
            return db.Employers.ToList();
        }

        public Employer GetObject(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Employer obj)
        {
            throw new NotImplementedException();
        }
    }
}
