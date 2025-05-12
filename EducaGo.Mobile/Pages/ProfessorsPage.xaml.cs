using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace EducaGo.Mobile.Pages
{
    public partial class ProfessorsPage : ContentPage
    {
        public ObservableCollection<Professor> Professors { get; set; }

        public ProfessorsPage()
        {
            InitializeComponent();



            Professors = new ObservableCollection<Professor>
            {
                new Professor { Name = "Lic Pedro", Degree = "Lic. en Edu. Primaria" },
                new Professor { Name = "Lic Pedrito", Degree = "Lic. en Pedagogía" },
                new Professor { Name = "Lic Juan", Degree = "Lic. en Edu. Primaria" },
                new Professor { Name = "Lic Juanito", Degree = "Lic. en Innovación Edu." },
                new Professor { Name = "Lic Pedro", Degree = "Lic. en Edu. Primaria" },
                new Professor { Name = "Lic Pedrito", Degree = "Lic. en Pedagogía" },
                new Professor { Name = "Lic Juan", Degree = "Lic. en Edu. Primaria" },
                new Professor { Name = "Lic Juanito", Degree = "Lic. en Innovación Edu." }
            };

            BindingContext = this;

        }
        private async void OnFilesPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Pages.HomePage());
        }
        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
        private async void OnProfilePage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Pages.HomePage());
        }
        private async void OnSettingsPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Pages.HomePage());
        }
    }

    public class Professor
    {

        public string Name { get; set; }
        public string Degree { get; set; }
    }
}
