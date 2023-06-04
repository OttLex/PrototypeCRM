using PrototypeCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeCRM.DataAccess
{
    public class SaleRepositoryEF : IRepository<Sale>
    {
        AppDbContext db= new AppDbContext();
        public void Create(Sale obj)
        {
            db.Products.Remove(obj.Product);
            db.Employers.Remove(obj.Employer);
            db.Clients.Remove(obj.Client);
            db.SaveChanges();
            db.Add(obj);
            db.SaveChanges();
        }

        public void Delete(Sale obj)
        {
            throw new NotImplementedException();
        }

        public List<Sale> GetListObjects()
        {
            return db.Sales.ToList();
        }

        public Sale GetObject(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Sale obj)
        {
            throw new NotImplementedException();
        }
    }
}
