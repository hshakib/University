using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace University.Models
{
    public class MyContext: DbContext
    {

        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<Student> Student {get;set;}
        public DbSet<Instructor> Instructor {get;set;}
        public DbSet<Faculty> Faculty {get;set;}
        public DbSet<Course> Course {get;set;}
        public DbSet<Universities> Universities {get;set;}
        public DbSet<User> User {get;set;}

        public Universities FindUniversity(int UnId)
        {
            return Universities.FirstOrDefault(x => x.UniversityId == UnId);            
        }

        public void UpdateUniversity(int UnId, Universities editUn)
        {
            Universities UnToEdit = this.FindUniversity(UnId);
            UnToEdit.Name = editUn.Name;
            UnToEdit.Location= editUn.Location;
            SaveChanges();
            
        }
    }
}