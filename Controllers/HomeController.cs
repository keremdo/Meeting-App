using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Hi = hour > 12 ? "İyi Günler":"Günaydın";
            int userCount = Repository.Users.Where(user => user.WillAttend==true).Count();

            var meetingInfo = new MeetingInfo(){
                Id = 1,
                Location = "Hendek/Sakarya - Hendek Gençlik Merkezi",
                Date = new DateTime(2023,01,20,20,0,0),
                NumberOfPeople = userCount
                
            };
            return View(meetingInfo);
        }
    }
}