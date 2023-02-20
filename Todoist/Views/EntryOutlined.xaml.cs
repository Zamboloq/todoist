namespace Todoist.Views;

public partial class EntryOutlined : Grid
{
	public EntryOutlined()
	{
		InitializeComponent();
	}

	public static readonly BindableProperty TextProperty = BindableProperty.Create(
		propertyName: nameof(Text),
		returnType: typeof(string),
		declaringType: typeof(EntryOutlined),
		defaultValue: null,
		defaultBindingMode: BindingMode.TwoWay);

	public String Text
	{
		get => (string)GetValue(TextProperty);
		set { SetValue(TextProperty, value); }
	}

    public static readonly BindableProperty PlaceHolderProperty = BindableProperty.Create(
        propertyName: nameof(PlaceHolder),
        returnType: typeof(string),
        declaringType: typeof(EntryOutlined),
        defaultValue: null,
        defaultBindingMode: BindingMode.OneWay);

    public String PlaceHolder
    {
        get => (string)GetValue(PlaceHolderProperty);
        set { SetValue(PlaceHolderProperty, value); }
    }

	private void txtEntryOnFocused(object sender, FocusEventArgs e)
	{
		labelPlaceHolder.FontSize = 10;
		labelPlaceHolder.TranslateTo(0, -26, 80, easing: Easing.Linear);

	}

	private void txtEntryOnUnfocused(object sender, FocusEventArgs e)
	{
        labelPlaceHolder.FontSize = 14;
        labelPlaceHolder.TranslateTo(0, 0, 80, easing: Easing.Linear);
    }

	public static readonly BindableProperty IsPasswordProperty = BindableProperty.Create(
		propertyName: nameof(IsPasswordEntry),
		returnType: typeof(bool),
		declaringType: typeof(EntryOutlined),
		defaultValue: false,
		defaultBindingMode: BindingMode.OneWay);

	public bool IsPasswordEntry
	{
		get => (bool)GetValue(IsPasswordProperty);
		set { SetValue(IsPasswordProperty, value); }
	}
}
