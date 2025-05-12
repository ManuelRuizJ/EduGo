using Microsoft.Maui.Controls;

namespace EducaGo.Mobile.Pages
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }




        private void NotificationsClicked(object sender, EventArgs e)
        {
            // Lógica para configurar notificaciones
            DisplayAlert("Notificaciones", "Función para configurar notificaciones", "OK");
        }

        private void LogoutClicked(object sender, EventArgs e)
        {
            // Lógica para cerrar sesión
            DisplayAlert("Cerrar Sesión", "Función para cerrar sesión", "OK");
        }
    }
}
