using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
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

        [Required]
        [DataType(DataType.MultilineText)]
        public string SecondPreference { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string JobLocation { get; set; }



    }
}
