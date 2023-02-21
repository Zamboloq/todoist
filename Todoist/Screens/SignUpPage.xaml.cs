using Todoist.ViewModels;

namespace Todoist;

public partial class SignUpPage : ContentPage
{

    public SignUpPage()
	{
		InitializeComponent();
        BindingContext = new AuthViewModel();
    }

	private async void OnSignUpClicked(object sender, EventArgs e)
	{
        var password = passwordEntry.Text;

        if (password == null || password.Length < 8)
        {
            return;
        }

        try
        {
            await Navigation.PushModalAsync(new MainPage());
        }
        catch (Exception ex)
        {
        }

    }
}
