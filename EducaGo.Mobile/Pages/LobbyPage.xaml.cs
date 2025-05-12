namespace EducaGo.Mobile.Pages;

public partial class LobbyPage : ContentPage
{
	public LobbyPage()
	{
        InitializeComponent();
	}
    private async void OnSubjectsClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Pages.HomePage());
    }
    
    private async void OnProfilePage(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Pages.ProfilePage());
    }
    
    private async void ContinuarButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Pages.CoursesPage());
    }
}