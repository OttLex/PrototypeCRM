using PrototypeCRM.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using PrototypeCRM.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace PrototypeCRM.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private MainFormService _mainService;



        private Product _selectedProduct;
        public Product SelectedProduct
        {
            get { return _selectedProduct; }
            set
            {
                _selectedProduct = value;
                OnPropertyChanged("SelectedProduct");
            }
        }

        public ObservableCollection<Sale> Sales => _mainService.SaleCollection;

        public ObservableCollection<Product> Products => _mainService.ProductCollection;


        public Client Client => _mainService.Client;

        public Employer Employer => _mainService.Employer;
        

        public MainViewModel()
        {
            _mainService = new MainFormService();
        }

        private ICommand addCommand;
        public ICommand AddCommand
        {
            get
            {
              return addCommand ??
                    (addCommand = new RelayCommand(obj =>
                    {
                        Sale sale = new Sale();

                        sale.Product = _selectedProduct;
                        sale.Client = Client;
                        sale.Employer = Employer;

                        _mainService.AddProductToSale(sale);
                    }));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
