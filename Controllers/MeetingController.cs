using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {

        //localhost/meeting
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            if (ModelState.IsValid)
            {
                Repository.CreateUser(model);
                ViewBag.UserCount = Repository.Users.Where(x => x.WillAttend == true).Count();
                return View("Thanks", model);
            }
            else
            {
                return View(model);
            }

        }

        [HttpGet]
        public IActionResult List()
        {
            var users = Repository.Users;
            return View(users);
        }

        //meeting/details/id
        public IActionResult Details(int id)
        {
            return View(Repository.GetUserById(id));
        }
    }
}