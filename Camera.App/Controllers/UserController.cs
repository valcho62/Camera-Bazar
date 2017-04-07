using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Camera.Models.View.User;
using Camera.Services;

namespace Camera.App.Controllers
{
    [RoutePrefix("user")]
    public class UserController : Controller
    {
        private UserService service;

        public UserController()
        {
            this.service = new UserService();
        }
        [Route("login")]
        public ActionResult Login()
        {
            var cookie = Request.Cookies.Get("sessionId");
            if (AuthenticationManager.IsLoged(cookie.Value))
            {
                this.service.
            }
            return View();
        }

        [Route("login")]
        [HttpPost]
        public ActionResult Login([Bind(Include = "Username,Password")] LoginVM userLogin)
        {
            return View();
        }

        [Route("register")]
        public ActionResult Register()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [Route("register")]
        public ActionResult Register([Bind (Include = "Username,Email,Password,Phone")] RegisterUserVM user)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Index","Home");
            }
           
                return View();
            
        }


        
    }
}
