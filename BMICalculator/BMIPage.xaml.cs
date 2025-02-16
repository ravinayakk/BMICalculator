namespace BMICalculator;

public partial class BMIPage : ContentPage
{
	double bmi;
    public BMIPage(double bmi)
    {
        InitializeComponent();
        LblBMI.Text = bmi.ToString();
        this.bmi = bmi;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RecomPage(bmi));
    }
}