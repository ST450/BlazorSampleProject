using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorSampleProject.ViewModels
{
    public class FormViewModel
    {
        [Required(ErrorMessage ="名前は必須です")]
        [MinLength(3), MaxLength(20)]
        public string Name { get; set; }
        [BirthdayValidator(ErrorCheck = false)]
        public DateTime Birthday { get; set; } = DateTime.Today;
        [Range(0, 100, ErrorMessage = "年齢は0～100で入力してください")]
        public int Age { get; set; }
        public string Profile { get; set; }
        public GenderType GenderType { get; set; }
        public Prefecture Prefecture { get; set; }
    }
}
