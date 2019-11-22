using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace University.Models
{
    public class Universities
    {
        [Key]
        public int UniversityId{get;set;}

        [Required(ErrorMessage="University Name is required")]
        [MinLength(2, ErrorMessage="Niversity Name must be 2 charector or longer")]
        public string Name {get;set;}

        [Required(ErrorMessage="Location is required")]
        public string Location {get;set;}
        public List<Faculty> staff {get;set;}

    }
}