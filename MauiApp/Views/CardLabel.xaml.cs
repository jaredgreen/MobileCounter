namespace MobileCounter.Views;

public partial class CardLabel : ContentView
{
    public static readonly BindableProperty TitleProperty = 
        BindableProperty.Create(
            nameof(Title),
            typeof(string),
            typeof(CardLabel));

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public static readonly BindableProperty TextProperty = 
        BindableProperty.Create(
            nameof(Text),
            typeof(string),
            typeof(CardLabel));

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public CardLabel()
    {
        InitializeComponent();
    }
}