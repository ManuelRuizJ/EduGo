namespace EducaGo.Mobile.Pages;

public partial class AddPage : ContentPage
{
	public AddPage()
	{
		InitializeComponent();
	}
    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
    private async void OnAddExamButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Pages.AddExamPage());

    }

    private async void OnAddLessonButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Pages.AddLessonPage());

    }
}