using Todoist.ViewModels;

namespace Todoist.Screens;

public partial class EmailPage : ContentPage
{

    Entry entry = new Entry { Placeholder = "" };

	public EmailPage()
	{
        InitializeComponent();
        BindingContext = new AuthViewModel();
    }

	private async void OnContinueWithEmailClickedAsync(object sender, EventArgs e)
	{
        var emailAddress = emailEntryOutlined.Text;

        //Should verify email address, via AuthViewModel
        if (emailAddress == null || emailAddress.Length == 0)
        {
            return;
        }

        try
        {
            await Navigation.PushModalAsync(new SignUpPage());
        }
        catch (Exception ex)
        {
        }
    }
}
