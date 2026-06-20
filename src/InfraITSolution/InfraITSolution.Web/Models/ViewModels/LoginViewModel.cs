using System.ComponentModel.DataAnnotations;


namespace InfraITSolution.Web.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMr { get; set; }

        public string ReturnUrl { get; set; }
    }
}
