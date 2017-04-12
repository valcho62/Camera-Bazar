
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Camera.Models.Entity;
using Camera.Models.View.Camera;

namespace Camera.Services
{
    public class CameraService :Service
    {
        public void Add(AddCameraVM model,User user)
        {
            var camera = Mapper.Map<Models.Entity.Camera>(model);
            camera.User = user;
           
            Contex.Cameras.Add(camera);
            Contex.SaveChanges();
        }

        public IEnumerable<AllCameraVM> MakeCameraVms()
        {
            var cameras = Contex.Cameras.ToList();
            var vms = Mapper.Map<IEnumerable<Models.Entity.Camera>,IEnumerable<AllCameraVM>>(cameras);
            return vms;
        }
    }
}
