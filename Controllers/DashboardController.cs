using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var model = new DashboardViewModel
            {
                Name = "Tuğçe Deniz",
                ProfileImage = "/images/profile.jpg",
                TotalProjects = 8,
                InternshipMonths = 6,
                TotalSkills = 5,
                Skills = new List<Skill>
            {
                new Skill { Title = "C#", Value = 90 },
                new Skill { Title = "ASP.NET Core", Value = 85 },
                new Skill { Title = "SQL", Value = 80 },
                new Skill { Title = "JavaScript", Value = 70 },
                new Skill { Title = "Python", Value = 60 },
                new Skill { Title = "React", Value = 50 },
                new Skill { Title = "Html,CSS", Value = 75 }
            }
            };
            return View();
        }
    }
    public class DashboardViewModel
    {
        public string Name { get; set; }
        public string ProfileImage { get; set; }
        public int TotalProjects { get; set; }
        public int InternshipMonths { get; set; }
        public int TotalSkills { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
