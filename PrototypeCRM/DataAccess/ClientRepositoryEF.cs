using PrototypeCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeCRM.DataAccess
{
    public class ClientRepositoryEF : IRepository<Client>
    {
        AppDbContext db = new AppDbContext();
        public void Create(Client obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Client obj)
        {
            throw new NotImplementedException();
        }

        public List<Client> GetListObjects()
        {
            return db.Clients.ToList();
        }

        public Client GetObject(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Client obj)
        {
            throw new NotImplementedException();
        }
    }
}
