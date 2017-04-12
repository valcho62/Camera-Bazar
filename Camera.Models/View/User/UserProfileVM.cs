
using System.Collections.Generic;

namespace Camera.Models.View.User
{
    public class UserProfileVM
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public int InstockCamera { get; set; }
        public int OutStockCamera { get; set; }
        public virtual IEnumerable<Entity.Camera> OwnCameras { get; set; }
    }
}

