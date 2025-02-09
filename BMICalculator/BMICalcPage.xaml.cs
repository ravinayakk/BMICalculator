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
        double bmi = (weight * 703) / (height * height);

        string status = "";
        string recommendation = "";
        bmi = Math.Round(bmi);

        if (choice == "Male")
        {
            if (bmi < 18.5)
            {
                status = "Underweight";
                recommendation = "- Increase your calorie intake with nutritious food.\n" +
                                 "- Include strength training in your routine.";
            }
            else if (bmi < 25)
            {
                status = "Normal weight";
                recommendation = "- Maintain a balanced diet and regular exercise.";
            }
            else if (bmi < 30)
            {
                status = "Overweight";
                recommendation = "- Reduce processed foods and focus on portion control.\n" +
                                 "- Engage in aerobic exercises (e.g., jogging, swimming) and strength training.\n" +
                                 "- Drink plenty of water and track your progress.";
            }
            else
            {
                status = "Obese";
                recommendation = "- Consult a healthcare provider for a structured weight-loss plan.\n" +
                                 "- Follow a healthy eating plan and exercise regularly.";
            }
        }
        else 
        {
            if (bmi < 18)
            {
                status = "Underweight";
                recommendation = "- Increase your calorie intake with nutritious food.\n" +
                                 "- Include strength training in your routine.";
            }
            else if (bmi < 24)
            {
                status = "Normal weight";
                recommendation = "- Maintain a balanced diet and regular exercise.";
            }
            else if (bmi < 29)
            {
                status = "Overweight";
                recommendation = "- Reduce processed foods and focus on portion control.\n" +
                                 "- Engage in aerobic exercises (e.g., jogging, swimming) and strength training.\n" +
                                 "- Drink plenty of water and track your progress.";
            }
            else
            {
                status = "Obese";
                recommendation = "- Consult a healthcare provider for a structured weight-loss plan.\n" +
                                 "- Follow a healthy eating plan and exercise regularly.";
            }
        }

        string message = 
                         $"Gender: {choice}\n" +
                         $"BMI: {bmi:F1}\n" +
                         $"Health Status: {status}\n\n" +
                         $"Recommendations:\n{recommendation}";

        DisplayAlert("Your calculated BMI results are: ", message, "OK");
    }
}