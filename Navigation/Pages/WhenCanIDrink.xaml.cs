namespace Navigation.Pages;

public partial class WhenCanIDrink : ContentPage
{
    public WhenCanIDrink()
    {
        InitializeComponent();
    }
    void OnDateSelected(object sender, System.EventArgs e)
    {
        double Age = DateTime.Now.Year - BirthDate.Date.Year;
        AgeText.Text = Age.ToString();
        if (Age >= 21)
        {
            AgeText.Text = "You are of age to drink.";
        }
        else
        {
            AgeText.Text = "You are " + (DateTime.Now.Year - BirthDate.Date.Year) + " year(s) ";
            AgeText.Text = "You can buy alchohol in: " + (21 - (DateTime.Now.Year - BirthDate.Date.Year) + " year(s)");
        }
    }
}