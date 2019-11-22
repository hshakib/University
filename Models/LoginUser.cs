using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace University.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage="Email is required")]
        [EmailAddress(ErrorMessage="Invalid Email")]
        public string LogEmail{get;set;}

        [Required(ErrorMessage="Password is required")]
        [MinLength(4, ErrorMessage="Password must be 4 charector or longer")]
        [DataType(DataType.Password)]
        public string LogPassword {get;set;}
    }
}