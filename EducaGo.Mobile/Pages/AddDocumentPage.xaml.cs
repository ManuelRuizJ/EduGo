using Microsoft.Maui.Controls;
using System;

namespace EducaGo.Mobile.Pages
{
    public partial class AddDocumentPage : ContentPage
    {
        public AddDocumentPage()
        {
            InitializeComponent();
        }

        
        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void OnAcceptClicked(object sender, EventArgs e)
        {
            string title = TitleEntry.Text;
            string author = AuthorEntry.Text;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
            {
                await DisplayAlert("Error", "Por favor completa todos los campos.", "OK");
                return;
            }

            // Aqu� podr�as guardar el documento o pasarlo a FilesPage
            await DisplayAlert("Documento a�adido", $"T�tulo: {title}\nAutor: {author}", "OK");
            await Navigation.PopAsync();
        }
    }
}
