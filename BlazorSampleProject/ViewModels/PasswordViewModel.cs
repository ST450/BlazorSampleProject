using System.ComponentModel.DataAnnotations;

namespace BlazorSampleProject.ViewModels
{
    public class PasswordViewModel
    {
        public string Password { get; set; }
        [Compare(nameof(Password), ErrorMessage ="パスワードが一致しません")]
        public string ConfiremPassword { get; set; } 
    }
}
