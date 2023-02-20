using System.Windows.Input;

namespace Todoist;

public partial class AppShell : Shell
{
    public Dictionary<string, Type> Routes { get; private set; } = new Dictionary<string, Type>();
    public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

    public AppShell()
	{
		InitializeComponent();
        RegisterRoutes();
        BindingContext = this;
    }

    void RegisterRoutes()
    {
        Routes.Add("authPage", typeof(AuthPage));
        Routes.Add("emailPage", typeof(Screens.EmailPage));
        Routes.Add("signUpPage", typeof(SignUpPage));
        Routes.Add("mainPage", typeof(MainPage));

        foreach (var item in Routes)
        {
            Routing.RegisterRoute(item.Key, item.Value);
        }
    }
}

