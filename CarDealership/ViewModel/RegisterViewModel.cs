using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.ViewModel
{
    public class RegisterViewModel
    {
        //this class is responsible for the registration of the user
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        //for the password we have used the data type password 
        //which will show passwords as"*"
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password not matched.")]
        public string ConfirmPassword { get; set; }

    }
}
