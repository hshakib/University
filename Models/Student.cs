using System;
using System.ComponentModel.DataAnnotations;


namespace University.Models
{
    public class Student
    {
        [Key]
        public int StudetId{get;set;}

        [Required(ErrorMessage="First Name is required")]
        [MinLength(2, ErrorMessage="First Name must be 2 charector or longer")]
        public string FName {get;set;}


        [Required(ErrorMessage="Last Name is required")]
        [MinLength(2, ErrorMessage="Last Name must be 2 charector or longer")]
        public string LName {get;set;}

        [Required(ErrorMessage="Gender is required")]
        public string Gender {get;set;}

        [Required(ErrorMessage="Age is required")]
        public int Age{get;set;}

        [Required]
        public DateTime DateEnrolled{get;set;}

        [Required(ErrorMessage="Email is required")]
        public string Email{get;set;}


    }
}