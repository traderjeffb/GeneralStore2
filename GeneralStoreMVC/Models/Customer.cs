using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeneralStoreMVC.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        [Display(Name ="FirstName")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name ="LastName")]
        public string LastName { get; set; }

        [Display(Name ="FullName")]
        public string FullName { get; }
    }
}