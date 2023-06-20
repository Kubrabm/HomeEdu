using System.ComponentModel.DataAnnotations;

namespace HomeEdu.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
