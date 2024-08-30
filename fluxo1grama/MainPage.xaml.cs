using System.Diagnostics.Tracing;
using Microsoft.Maui.Controls;

namespace fluxo1grama;

    public partial class MainPage : ContentPage
    {
        Cliente cliente;
        public MainPage()
        {
            InitializeComponent();
            cliente = new Cliente();
        }
        public void botaocliente(object sender, EventArgs args)
        {
            Application.Currente.Mainpage = new Cliente();

        } 
        public void botaomateriaprima(object sender, EventTags args)
        {
            Application.Current.MainPage = new Materiaprima();
            
        }
        public void botaofornecedor(object sender, EventTags args)
        {
            Application.Current.MainPage = new Fornecedor();
        }
        public void botaopedido(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Pedido();
        }
        public void botaoalmoxarifado(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Almoxarifado();
        }
        public void botaoformadepagamento(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Formadepagamento();
        }
        public void botaoprodutos(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Produtos();
        }
        public void botaosetores(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Setores();
        }
        

    }

