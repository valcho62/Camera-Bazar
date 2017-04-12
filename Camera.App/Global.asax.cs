using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using Camera.Data;
using Camera.Models.Entity;
using Camera.Models.View.Camera;
using Camera.Models.View.User;
using Camera = Camera.Models.Entity.Camera;

namespace Camera.App
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //CameraBazarContex contex = new CameraBazarContex();
            //contex.Database.Initialize(true);
            Registermaps();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        private void Registermaps()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<RegisterUserVM, User>();
                cfg.CreateMap<AddCameraVM, Models.Entity.Camera>();
                cfg.CreateMap<Models.Entity.Camera, AllCameraVM>();
                cfg.CreateMap<User, UserProfileVM>();
            });
        }
    }
}
