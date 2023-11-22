namespace Navigation.Pages;

public partial class MorseCode : ContentPage
{
    string letter = "";
    string text = "";

    public MorseCode()
    {
        InitializeComponent();
    }

    void DotClicked(object sender, EventArgs args)
    {
        letter += ".";
    }

    void DashClicked(object sender, EventArgs args)
    {
        letter += "-";
    }

    void ClearClicked(object sender, EventArgs args)
    {
        text = "";
        YourText.Text = text;
    }

    void SpaceClicked(object sender, EventArgs args)
    {
        if (letter.Length == 0)
        {
            text += " ";
        }
        else
        {
            text += Morse.MorseCoder(letter);
            letter = "";
            YourText.Text = text;
        }
    }
}