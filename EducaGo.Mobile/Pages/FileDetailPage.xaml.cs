using Microsoft.Maui.Controls;
using System;

namespace EducaGo.Mobile.Pages
{
    public partial class FileDetailPage : ContentPage
    {
        public FileDetailPage(FileItem file)
        {
            InitializeComponent();
            BindingContext = file;
        }

        private async void OnNextDocumentClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Siguiente", "Aquí iría el siguiente documento", "OK");
        }
        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
