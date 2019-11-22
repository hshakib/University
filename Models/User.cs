using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace University.Models
{
    public class User
    {
        [Key]
        public int UserId{get;set;}

        [Required(ErrorMessage="First Name is required")]
        [MinLength(2, ErrorMessage="First Name must be 2 charector or longer")]
        public string FName {get;set;}


        [Required(ErrorMessage="Last Name is required")]
        public string LName {get;set;}


        [Required(ErrorMessage="Email is required")]
        [EmailAddress(ErrorMessage="Invalid Email")]
        public string Email{get;set;}

        [Required(ErrorMessage="Password is required")]
        [MinLength(4, ErrorMessage="Password must be 4 charector or longer")]
        [DataType(DataType.Password)]
        public string Password {get;set;}
        public DateTime CreatedAt {get;set;}=DateTime.Now;
        public DateTime UpdatedAt {get;set;}=DateTime.Now;

        [NotMapped]
        [Required(ErrorMessage="Confirm Password is required")]
        [Compare("Password", ErrorMessage="Confirm Password must Match Password")]
        [DataType(DataType.Password)]
        public string Confirm {get;set;}
    }
}