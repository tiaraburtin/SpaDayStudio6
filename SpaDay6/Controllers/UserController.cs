using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay6.Models;
using SpaDay6.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay6.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View();
        }

        [HttpGet]
        [Route("/user/add")]

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                if (addUserViewModel.Password == addUserViewModel.VerifyPassword)
                {
                    User newUser = new User
                    {
                       UserName = addUserViewModel.UserName,
                       Email = addUserViewModel.Email,
                       Password = addUserViewModel.Password

                    };
                    return View("Index", newUser);
                }
                ViewBag.error = "Passwords must match.";
                return View("Add");
            }
            return View("Add", addUserViewModel);

            //        if (newUser.Password == verify)
            //        {
            //            ViewBag.user = newUser;
            //            return View("Index");
            //        }
            //        else
            //        {
            //            ViewBag.error = "Passwords do not match! Try again!";
            //            ViewBag.userName = newUser.Username;
            //            ViewBag.eMail = newUser.Email;
            //            return View("Add");
            //        }
        }
    }
    }

