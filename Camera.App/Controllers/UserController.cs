using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Camera.Models.View.User;

namespace Camera.App.Controllers
{
    [RoutePrefix("user")]
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
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

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
