using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Apply(UserInfo userInfo)
        {
            if(ModelState.IsValid)
            {
                Repository.CreateUser(userInfo);
                ViewBag.UserCount = Repository.Users.Where(user => user.WillAttend==true).Count();
                return View("Thanks", userInfo);
            }else{
                return View(userInfo);
            }
            
            
        }
        [HttpGet]
        public IActionResult List()
        {
            var users = Repository.GetAll();
            return View(users);
        }

        public IActionResult Details(int id)
        {
            var u = Repository.GetById(id);
            return View(u);
        }

    } 
}