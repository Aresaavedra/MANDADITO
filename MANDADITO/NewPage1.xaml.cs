using Microsoft.Maui.Controls;

namespace MANDADITO
{
    public partial class NewPage1 : ContentPage
    {
        public NewPage1()
        {
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void OnCreateAccountClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Cuenta creada", "Tu cuenta ha sido creada exitosamente.", "OK");

            await Navigation.PopAsync();
        }
    }
}
