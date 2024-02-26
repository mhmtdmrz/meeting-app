using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {

        //localhost/home
        public IActionResult Index()
        {
            //int saat = DateTime.Now.Hour;
            //var selamlama = saat > 12 ? "İyi Günler" : "Günaydın";

            //ViewBag.Selamlama = saat > 12 ? "İyi Günler" : "Günaydın";
            //ViewBag.Username = "Mehmet";

            //ViewData["Selamlama"] = saat > 12 ? "İyi Günler" : "Günaydın";
            //ViewData["Username"] = "Mehmet";

            int UserCount = Repository.Users.Where(x => x.WillAttend == true).Count();

            var meetingInfo = new MeetingInfo() {
                Id = 1,
                Location = "İstanbul, Abc Kongre Kültür Merkezi",
                Date = new DateTime(2024,02,26,20,0,0),
                NumberOfPeople = UserCount
            };
            
            return View(meetingInfo);
        }
    }
} 