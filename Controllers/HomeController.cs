using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using University.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace University.Controllers
{
    public class HomeController : Controller
    {    

        // List<User> AllUsers = dbContext.Users.ToList();
        // List<Universities> AllUniversities = MyContext.University
        private MyContext context;
        public HomeController(MyContext mc)
        {
            context=mc;
        }
        
        [HttpGet("")]        
        public IActionResult Index()
        {
            //List<Universities> AllUni = context.University.ToList();
            ViewBag.Faculty  = context.Faculty;
            ViewBag.Course  = context.Course;
            ViewBag.Universities = context.Universities;          
            return View();
        }     

        //for login we created following code
        //first checking if the email is matching the email in the database
        //if email is the same as database email than will tack us to check 
        //password, before checking that the hasher will do its job and than
        //if the passord is correct we can go ahead for forther process.
        [HttpPost("LoginUser")]
        public IActionResult LoginUser(LoginUser UserData) 
        {
            ViewBag.Universities = context.Universities;          
            User UserInDb = context.User.FirstOrDefault(u => u.Email == UserData.LogEmail);
            if (UserInDb == null){
                ModelState.AddModelError("LogEmail", "Email is not walid");
            }else
            {
                var hasher = new PasswordHasher<LoginUser>();
                if(UserData.LogPassword == null) {
                    UserData.LogPassword = "";
            }
                var result = hasher.VerifyHashedPassword(UserData, UserInDb.Password, UserData.LogPassword);
                if ( result == 0 ){
                    ModelState.AddModelError("LogPassword", " Wrong Password"); 
                }
            }             
            if (!ModelState.IsValid){                
                return View("Index");
            } 
            return Redirect("Dashboard");
        }


        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {
            return View("Dashboard");
        }

        //desplay Dashboard page only
        [HttpGet("Universities")]
        public IActionResult Universities()
        {
            ViewBag.Universities = context.Universities;          
            return View("Universities");
        }


        [HttpGet("User")]
        public IActionResult UserShow()
        {
            ViewBag.Universities = context.Universities;          
            return View("User");
        }


        [HttpPost("AddUniversity")]
        public IActionResult AddUniversity(Universities newUniversity)
        {
            ViewBag.Universities = context.Universities;          

            if (!ModelState.IsValid)
            {
            return View("Universities");
            }
            context.Universities.Add(newUniversity);
            context.SaveChanges();
            return View("Universities");
        }

        [HttpPost("saveFaculty")]
        public IActionResult saveFaculty(Faculty NewFaculty)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Faculty  = context.Faculty;
                return View("Index");
            }
            context.Faculty.Add(NewFaculty);
            context.SaveChanges();
            return Redirect("/");
        }

        [HttpPost("saveCourse")]
        public IActionResult saveCourse(Course NewCourse)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Course  = context.Course;
                return View("Index");
            }
            context.Course.Add(NewCourse);
            context.SaveChanges();
            return Redirect("/");
        }      

        //for user registration we used following codes
        //at the same time we used password hasher to hash the 
        //password before saving that in the database
        [HttpPost("saveUser")]
        public IActionResult saveUser(User newUser)
        {
            if (ModelState.IsValid)
            {
                var hasher = new PasswordHasher<User>();
                newUser.Password=hasher.HashPassword(newUser, newUser.Password);
                context.User.Add(newUser);
                context.SaveChanges();
                return Redirect("/");
            }
            return View("Index");
        }




        //Remove university from database
        [HttpGet("RemoverUniversity/{UnId}")]
        public IActionResult RemoveUniversity(int UnId)
        {
            ViewBag.Universities = context.Universities;          

            Universities RetrievedUn = context.Universities.SingleOrDefault(u => u.UniversityId == UnId); 
            context.Universities.Remove(RetrievedUn);
            context.SaveChanges();        
            return Redirect("/");
        }

        [HttpGet("EditU/{UnId}")]
        public IActionResult EditU(int UnId)
        {
            // Universities UnToEdit = context.Universities.FirstOrDefault(x => x.UniversityId == UnId);            
            Universities UnToEdit = context.FindUniversity(UnId);  
            return View("UniversityEdit", UnToEdit);
        }


        [HttpPost("UpdateUn/{UnId}")]
        public IActionResult UpdateUn(int UnId, Universities EditUniv)
        {
           
            context.UpdateUniversity(UnId, EditUniv); 
            // Universities UnToEdit = context.Universities.FirstOrDefault(x => x.UniversityId == UnId);  
            // Universities UnToEdit = this.FindUniversity(UnId);
            // UnToEdit.Name = UnToEdit.Name;
            // UnToEdit.Location= UnToEdit.Location;
            // context.SaveChanges();
            return View("UniversityEdit", EditUniv);
        }
    }
}

        //  public Universities FindUniversity(int UnId)
        // {
        //     return Universities.FirstOrDefault(x => x.UniversityId == UnId);            
        // }
        // public void UpdateUniversity(int UnId, Universities editUn)
        // {
        //     Universities UnToEdit = this.FindUniversity(UnId);
        //     UnToEdit.Name = editUn.Name;
        //     UnToEdit.Location= editUn.Location;
        //     SaveChanges();
            
        // }