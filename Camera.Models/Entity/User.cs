
using System.Collections.Generic;

namespace Camera.Models.Entity
{
    public class User
    {
        public User()
        {
            this.OwnCameras =new HashSet<Camera>();
        }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Camera> OwnCameras { get; set; }
        
    }
}
