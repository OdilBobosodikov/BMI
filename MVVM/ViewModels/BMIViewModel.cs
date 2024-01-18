using BMI.MVVM.Models;

namespace BMI.MVVM.ViewModels
{
    public class BMIViewModel
    {
        public BMIModel BMI { get; set; }
        public BMIViewModel()
        {
            BMI = new BMIModel()
            {
                Height = 186,
                Weight = 86,
            };
        }
    }
}
