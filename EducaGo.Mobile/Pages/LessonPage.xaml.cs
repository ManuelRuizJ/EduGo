namespace EducaGo.Mobile.Pages;

public partial class LessonPage : ContentPage
{
	public LessonPage()
	{
		InitializeComponent();
	}
    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}
