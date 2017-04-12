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
            if (cookie != null && AuthenticationManager.IsLoged(cookie.Value))
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [Route("login")]
        [HttpPost]
        public ActionResult Login([Bind(Include = "Username,Password")] LoginVM userLogin)
        {
            var httpCookie = this.Request.Cookies.Get("sessionId");
            if (httpCookie != null && AuthenticationManager.IsLoged(httpCookie.Value))
            {
                return this.RedirectToAction("Index", "Home");
            }
            if (ModelState.IsValid)
            {
                
                this.service.Login(userLogin,Session.SessionID);
                this.Response.SetCookie(new HttpCookie("sessionId", Session.SessionID));
                return RedirectToAction("Index", "Home");
            }
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
        public ActionResult Register([Bind(Include = "Username,Email,Password,Phone")] RegisterUserVM user)
        {
            if (ModelState.IsValid)
            {
                this.service.RegisterUser(user);
                return RedirectToAction("Index", "Home");
            }

            return View();

        }
        [Route("logout")]
        public ActionResult Logout()
        {
            var cookie = Request.Cookies.Get("sessionId");
            if (cookie != null && AuthenticationManager.IsLoged(cookie.Value))
            {
                this.service.Logout(cookie.Value);

            }
            return RedirectToAction("Index", "Home");
        }

        [Route("profile/{id}")]
        public ActionResult Profile(int id)
        {
            var cookie = Request.Cookies.Get("sessionId");
            if (cookie != null && AuthenticationManager.IsLoged(cookie.Value))
            {
                var model = this.service.MakeProfileVm(id);
                return View(model);
            }
           
            return RedirectToAction("Index", "Home");
        }

        [Route("editprofile/{name}")]
        public ActionResult EditProfile(string name)
        {
            var cookie = Request.Cookies.Get("sessionId");
            bool isMyProfile = AuthenticationManager.GetUser(cookie.Value).Username == name;
            if (cookie != null && AuthenticationManager.IsLoged(cookie.Value) && isMyProfile)
            {
                var model = this.service.MakeProfileVm(id);
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }


    }
}
