namespace BMICalculator;

public partial class BMICalcPage : ContentPage
{
	public BMICalcPage()
	{
		InitializeComponent();
	}

    string choice = "Male";
    private void TapMale_Tapped(object sender, TappedEventArgs e)
    {
        choice = "Male";
        FrameMale.BorderColor = Color.FromArgb("#0a0e29");
        FrameFemale.BorderColor = Color.FromArgb("#fdfdfd");
    }
    private void TapFemale_Tapped(object sender, TappedEventArgs e)
    {
        choice = "Female";
        FrameFemale.BorderColor = Color.FromArgb("#0a0e29");
        FrameMale.BorderColor = Color.FromArgb("#fdfdfd");
    }

    private void BtnCalculateBMI_Clicked(object sender, EventArgs e)
	{
        double height = double.Parse(LblHeight.Text);
        double weight = double.Parse(LblWeight.Text);
        double bmi = (weight * 703) / height;
    }

    private void Btn_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Your calulated BMI results are:","Gender: ",choice , "BMI: ");
    }
}