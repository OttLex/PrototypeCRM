using PrototypeCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeCRM.DataAccess
{
    public class ProductRepositoryEF : IRepository<Product>
    {
        AppDbContext db = new AppDbContext();
        public void Create(Product obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product obj)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetListObjects()
        {
           return db.Products.ToList();
        }

        public Product GetObject(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product obj)
        {
            throw new NotImplementedException();
        }
    }
}
