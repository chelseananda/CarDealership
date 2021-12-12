using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Models
{
    public class Customer
    {
        
        public int ID { get; set; }
        [Required(ErrorMessage ="Enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Enter email")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Enter your phone number")]
        public double phoneNumber { get; set; }
    }
}
