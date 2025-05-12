using System.Windows.Input;

namespace EducaGo.Mobile.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
        InitializeComponent();
	}
    private async void LoginClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Pages.LobbyPage());
    }

    private async void RegisterClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Pages.RegisterPage());
    }

}