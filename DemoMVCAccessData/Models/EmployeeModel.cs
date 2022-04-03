using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoMVCAccessData.Models
{
    public class EmployeeModel
    {
        [Display(Name = "Employeed Id")]
        [Range(1, 99999, ErrorMessage = "You need ti eneter a valid employeeId")]
        public int EmployeeId { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You need to give us your firts name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You need to give us your last name")]
        public string LastName { get; set; }
        [Display(Name = "Email Address")]
        [Required(ErrorMessage ="You need to give us your email adress")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [Display(Name ="Confirm your Email ")]
        [Compare("EmailAddress",ErrorMessage ="The email and confirm must match.")]
        public string  ConfirmEmail { get; set; }
        [Display(Name ="Password")]
        [Required(ErrorMessage ="you must have a password")]
        [DataType(DataType.Password)]
        [StringLength(10, MinimumLength =5, ErrorMessage ="you need to provide a lorge password")]
        public string Password  { get; set; }
        [Display(Name ="Confirm password")]
        [Compare("Password", ErrorMessage ="Your password and confirm password do not match")]
        public string confirmPassword { get; set; }
    }
}