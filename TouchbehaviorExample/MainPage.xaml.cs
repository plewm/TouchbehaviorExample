using System.Windows.Input;

namespace TouchbehaviorExample;

public partial class MainPage : ContentPage
{
    int count = 0;
    public ICommand TouchCommand { get; set; }

    public MainPage()
    {
        InitializeComponent();
        TouchCommand = new Command(OnClick);
    }

    private void OnClick()
    {
        count++;

        if (count == 1)
            innerLabel.Text = $"Clicked {count} time";
        else
            innerLabel.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(innerLabel.Text);
    }
}