namespace Navigation.Pages;

public partial class CatFact : ContentPage
{
    string text;

    public CatFact()
    {
        InitializeComponent();
    }

    async void FactClicked(object? sender, EventArgs args)
    {
        if (Connectivity.Current.NetworkAccess == NetworkAccess.None)
        {
            factText.Text = "Please connect to the internet";
        }
        else
        {
            factText.Text = "Fetching fact...";
            HttpClient client = new HttpClient();
            text = await client.GetStringAsync("https://catfact.ninja/fact");
            text = text.Substring(9, (text.Length - 24));

            factText.Text = text;
        }
    }
}