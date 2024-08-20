using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace ClientesApp
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Client> Clients { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Clients = new ObservableCollection<Client>
            {
                new Client { Name = "Cliente 1" },
                new Client { Name = "Cliente 2" },
                new Client { Name = "Cliente 3" },
                new Client { Name = "Cliente 4" },
                new Client { Name = "Cliente 5" }
            };

            ClientList.ItemsSource = Clients;
        }

        private void AddClient_Click(object sender, RoutedEventArgs e)
        {
            Clients.Add(new Client { Name = "Novo Cliente" });
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

    public class Client
    {
        public string Name { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public Client()
        {
            EditCommand = new RelayCommand(EditClient);
            DeleteCommand = new RelayCommand(DeleteClient);
        }

        private void EditClient(object parameter)
        {
            MessageBox.Show($"Editando {Name}");
        }

        private void DeleteClient(object parameter)
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
