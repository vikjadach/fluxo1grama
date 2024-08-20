using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Pedidos
{
    public partial class Pedidos : ContentPage
    {
        public ObservableCollection<Product> Products { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Products = new ObservableCollection<Product>
            {
                new Product { Name = "Produto 1" },
                new Product { Name = "Produto 2" },
                new Product { Name = "Produto 3" },
                new Product { Name = "Produto 4" },
                new Product { Name = "Produto 5" }
            };

            ProductList.ItemsSource = Products;
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            Products.Add(new Product { Name = "Novo Produto" });
        }

        private void PreviousPage_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para página anterior
        }

        private void NextPage_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para próxima página
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public Product()
        {
            EditCommand = new RelayCommand(EditProduct);
            DeleteCommand = new RelayCommand(DeleteProduct);
        }

        private void EditProduct(object parameter)
        {
            MessageBox.Show($"Editando {Name}");
        }

        private void DeleteProduct(object parameter)
        {
            MessageBox.Show($"Deletando {Name}");
        }
    }

    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
