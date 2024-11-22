using MANDADITO;
using Microsoft.Maui.Controls;

namespace MANDADITO
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
         InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // Navegar a la nueva página al hacer clic en "Iniciar sesión"
            await Navigation.PushAsync(new NewPage1());
        }

        private async void OnCreateAccountTapped(object sender, EventArgs e)
        {
            // Navegar a la página de creación de cuenta al hacer clic en "Crear cuenta"
            await Navigation.PushAsync(new NewPage1());
        }
    }
}
