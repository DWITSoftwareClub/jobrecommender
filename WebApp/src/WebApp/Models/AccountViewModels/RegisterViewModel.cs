using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.AccountViewModels
{
    public class RegisterViewModel
    {

        //Personal Details

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "DateOfBirth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Contact Number")]
        public string MobileNo { get; set; }

        [Required]
        [Display(Name = "Permanent Address")]
        public string PermanentAddress { get; set; }

        [Required]
        [Display(Name = "Current Address")]
        public string CurrentAddress { get; set; }

        [Required]
        public string Gender { get; set; }

        public string MaritalStatus { get; set; }

        //career details
        [Required]
        [DataType(DataType.MultilineText)]
        public string CareerPlan { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public string ExceptedSalary { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string LookingFor { get; set; }


        //job preferences

        [Required]
        [DataType(DataType.MultilineText)]
        public string FirstPreference { get; set; }


        [DataType(DataType.MultilineText)]
        public string SecondPreference { get; set; }


        [DataType(DataType.MultilineText)]
        public string JobLocation { get; set; }


        //Login Details


        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
