using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace University.Models
{
    public class Faculty
    {
        [Key]
        public int FacultyId{get;set;}

        [Required(ErrorMessage="Facutly Name is required")]
        [MinLength(2, ErrorMessage="Faculty Name must be 2 charector or longer")]
        public string Name {get;set;}

        [Required(ErrorMessage="Description is required")]
        [MinLength(2, ErrorMessage="Description must be 2 charector or longer")]
        public string Description {get;set;}

        public int UniversityId{get;set;}
        public Universities university {get;set;}

        public int CourseId {get;set;}
        public List<Course> CourseNo {get;set;}


    }
}