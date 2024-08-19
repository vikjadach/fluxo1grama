using Microsoft.Maui.Controls;

namespace fluxo1grama
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNextPageClicked(object sender, EventArgs e)
        {
            // Navegar para a próxima página
            await Navigation.PushAsync(new NextPage());
        }
    }
}
