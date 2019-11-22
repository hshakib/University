using System;
using System.ComponentModel.DataAnnotations;


namespace University.Models
{
    public class Course
    {
        [Key]
        public int CourseId{get;set;}

        [Required(ErrorMessage="Title is required")]
        [MinLength(2, ErrorMessage="Title must be 2 charector or longer")]
        public string Title {get;set;}

        [Required(ErrorMessage="Crouse Hourse is required")]
        public int CrHourse {get;set;}

        [Required(ErrorMessage="Description is required")]
        public string Description {get;set;}

        public int FacultyId{get;set;}
        


    }
}