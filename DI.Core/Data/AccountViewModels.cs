using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.Build.Framework;

namespace DI.Core
{
    public class ExternalLoginConfirmationViewModel
    {
        [System.ComponentModel.DataAnnotations.Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [System.ComponentModel.DataAnnotations.Required]
        public string Provider { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [System.ComponentModel.DataAnnotations.Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [System.ComponentModel.DataAnnotations.Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [System.ComponentModel.DataAnnotations.Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [System.ComponentModel.DataAnnotations.Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [System.ComponentModel.DataAnnotations.Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
