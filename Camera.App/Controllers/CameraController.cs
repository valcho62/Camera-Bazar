using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Camera.Models.View.Camera;
using Camera.Services;

namespace Camera.App.Controllers
{
    [RoutePrefix("camera")]
    public class CameraController : Controller
    {
        private CameraService service;

        public CameraController()
        {
            this.service = new CameraService();
        }
        // GET: Camera
        [Route("all")]
        public ActionResult All()
        {
            var cameraList = this.service.MakeCameraVms();
            return View(cameraList);
        }

        // GET: Camera/Details/5
        public ActionResult Details(int id)
        {
            var camera = this.service.Contex.Cameras.Find(id);
            return View(camera);
        }

        // GET: Camera/Create
        [Route("add")]
        public ActionResult Add()
        {
            var session = Request.Cookies.Get("sessionId");
            if (session != null && AuthenticationManager.IsLoged(session.Value))
            {
                return View();
            }
            return RedirectToAction("Login","User")
   ;     }

        // POST: Camera/Create
        [HttpPost]
        [Route("add")]
        public ActionResult Add(AddCameraVM camera)
        {
            if (ModelState.IsValid)
            {
                var session = Request.Cookies.Get("sessionId");
                var user = AuthenticationManager.GetUser(session.Value);
                this.service.Add(camera,user);
                return RedirectToAction("All","Camera")
   ;         }
            return this.View();
        }

        
    }
}
