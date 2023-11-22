namespace Navigation.Pages;

public partial class BMICalc : ContentPage
{
    int count = 0;

    public BMICalc()
    {
        InitializeComponent();
    }

    void Calc(object sender, EventArgs args)
    {
        double weight = double.Parse(Weight.Text);
        double height = double.Parse(Height.Text) * double.Parse(Height.Text);
        BMItext.Text = "BMI: " + (703 * (weight / height));
    }
}
