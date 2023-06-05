using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Prism.Mvvm;
using PrototypeCRM.DataAccess;
using PrototypeCRM.Models;

namespace PrototypeCRM.Services
{
    public class MainFormService: BindableBase
    {
        private Client _client;
        private Employer _employer;
        private ObservableCollection<Product> _productCollection;
        private ObservableCollection<Sale> _saleCollection;

        private AppDbContext _db;
        private IRepository<Product> _productRepo;
        private IRepository<Employer> _employerRepo;
        private IRepository<Sale> _saleRepo;
        private IRepository<Client> _clientRepo;


        public Client Client
        {
            get { return _client; }
            set
            {
                _client = value;
                RaisePropertyChanged("Client");
            }
        }
        public Employer Employer
        {
            get { return _employer; }
            set
            {
                _employer = value;
                RaisePropertyChanged("Employer");
            }
        }
        public ObservableCollection<Product> ProductCollection
        {
            get { return _productCollection; }
            set
            {
                _productCollection = value;
                RaisePropertyChanged("ProductCollection");
            }
        }

        public ObservableCollection<Sale> SaleCollection
        {
            get { return _saleCollection; }
            set
            {
                _saleCollection = value;
                RaisePropertyChanged("SaleCollection");
            }
        }

        public MainFormService()
        {
            _db = new AppDbContext();
            _db.Database.EnsureDeleted();
            _db.Database.EnsureCreated();
            InitRepositories();

            ProductCollection = new ObservableCollection<Product>(_productRepo.GetListObjects());
            Employer = _employerRepo.GetListObjects().First();
            Client = _clientRepo.GetListObjects().First();
        }

        private void InitRepositories()
        {
            _productRepo = new ProductRepositoryEF();
            _saleRepo = new SaleRepositoryEF();
            _employerRepo = new EmployesRepositoryEF();
            _clientRepo = new ClientRepositoryEF();
        }


        public ObservableCollection<Sale> AddProductToSale(Sale sale)
        {

            _saleRepo.Create(sale);
            return _saleCollection = new ObservableCollection<Sale>(_saleRepo.GetListObjects());
        }
       






        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
