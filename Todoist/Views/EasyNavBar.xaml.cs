namespace Todoist.Views;

public partial class EasyNavBar : ContentView
{
	public EasyNavBar()
	{
		InitializeComponent();
	}

    void onFirstClicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PopAsync();
    }

    void onSecondClicked(object sender, EventArgs e)
	{

	}

    public static readonly BindableProperty TitleBarProperty = BindableProperty.Create(
    nameof(TitleBar),
    typeof(string),
    typeof(EasyNavBar),
    defaultValue: string.Empty,
    BindingMode.OneWay,
    propertyChanged: titleBindablePropertyChanged);

    private static void titleBindablePropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (EasyNavBar)bindable;
        control.titleBar.Text = newValue.ToString();
        //throw new NotImplementedException();
    }

    public string TitleBar
    {
        get { return base.GetValue(TitleBarProperty).ToString(); }
        set { base.SetValue(TitleBarProperty, value); }
    }
}
