using System.Diagnostics;

namespace MAUI_first_work;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    } 

    public void OnCounterClicked(Object sender,EventArgs e)
    {
        Output.Text = $"{Math.Round(Convert.ToInt32(DataValue.Text) * 4.91, 2, MidpointRounding.AwayFromZero)} lei";
        SemanticScreenReader.Announce(Output.Text);
    } 
}

