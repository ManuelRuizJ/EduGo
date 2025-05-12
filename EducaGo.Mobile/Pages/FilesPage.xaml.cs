using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;

namespace EducaGo.Mobile.Pages
{
    public partial class FilesPage : ContentPage
    {
        public ObservableCollection<FileItem> Files { get; set; }

        public FilesPage()
        {
            InitializeComponent();

            Files = new ObservableCollection<FileItem>
            {
                new FileItem { Author = "Author name", Title = "Biden Ends Infrastructure Talks With Senate GOP Group, Saying Its Plan Fell Short", Time = "12:10" },
                new FileItem { Author = "Author name", Title = "Biden Ends Infrastructure Talks With Senate GOP Group, Saying Its Plan Fell Short", Time = "12:10" },
                new FileItem { Author = "Author name", Title = "Biden Ends Infrastructure Talks With Senate GOP Group, Saying Its Plan Fell Short", Time = "12:10" },
                new FileItem { Author = "Author name", Title = "", Time = "" }
            };

            BindingContext = this;
        }

        
        private async void OnAddFileClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddDocumentPage());
        }
        private async void OnAddDocumentPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Pages.AddDocumentPage());
        }
        private async void OnFileDetailPage(object sender, EventArgs e)
        {
            var file = (FileItem)((Button)sender).BindingContext;
            await Navigation.PushModalAsync(new FileDetailPage(file));
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }

    public class FileItem
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Time { get; set; }
    }
}
