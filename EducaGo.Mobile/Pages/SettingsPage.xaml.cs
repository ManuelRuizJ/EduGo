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
            // L�gica para configurar notificaciones
            DisplayAlert("Notificaciones", "Funci�n para configurar notificaciones", "OK");
        }

        private void LogoutClicked(object sender, EventArgs e)
        {
            // L�gica para cerrar sesi�n
            DisplayAlert("Cerrar Sesi�n", "Funci�n para cerrar sesi�n", "OK");
        }
    }
}
