using System.ComponentModel.DataAnnotations;

namespace BlazorSampleProject.ViewModels
{
    public class BirthdayValidator : ValidationAttribute
    {
        public BirthdayValidator()
        {

        }

        public bool ErrorCheck { get; set; }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (!ErrorCheck)
                return ValidationResult.Success;

            var date = (DateTime)value;

            return DateTime.Compare(date, DateTime.Now) > 0
                ? new ValidationResult("誕生日は本日以前の日付を入力してください。")
                : ValidationResult.Success;
        }
    }
}
