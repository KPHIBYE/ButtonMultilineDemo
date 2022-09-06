namespace ButtonMultilineDemo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        var nlText = string.Join(Environment.NewLine, "Line", "break", "text");//, "lets", "continue", "this", "some", "more");
        MyButton.Text = nlText;
        MyButtonBig.Text = nlText;
    }
}

