using System.Windows.Input;
using Todoist.ViewModels;

namespace Todoist;

public partial class AuthPage : ContentPage
{
    // Launcher.OpenAsync is provided by Essentials.
    public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

    public AuthPage()
	{
        InitializeComponent();
        BindingContext = this;
    }

	private async void OnAuthEmailClicked(object sender, EventArgs e)
	{

		/*
		 * This function navigates to authorization via email page.
		 */
		try
		{
            await Navigation.PushModalAsync(new Screens.EmailPage());
        } catch (Exception ex)
		{
		}
    }

    private void OnAuthAppleClicked(object sender, EventArgs e)
	{
		/*
		 * This function send the Apple ID to the back-end for authorization
		 */
		string appleId = getAppleId();
		if (appleId != null && appleId.Length > 0)
		{
            authViaApple();
			// But here we have to auth apple id asynchronizely and await for
			// the result. After getting successful result only then it can
			// continue and navigate to the home page.
		} else
		{
			// It should show an error message.
		}
    }

	private String getAppleId()
	{
		return "";
	}

	private void authViaApple()
	{

	}
}
