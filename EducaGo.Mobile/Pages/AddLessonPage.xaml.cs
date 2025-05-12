namespace EducaGo.Mobile.Pages;

public partial class AddLessonPage : ContentPage
{
	public AddLessonPage()
	{
        InitializeComponent();
	}
    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
    private async void OnCancelButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
    private async void OnAcceptButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Pages.CoursesPage());
    }
}