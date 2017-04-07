using Camera.Models.Entity;

namespace Camera.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CameraBazarContex : DbContext
    {

        public CameraBazarContex()
            : base("name=CameraBazarContex")
        {
        }

       public virtual DbSet<User> Users { get; set; }
       public virtual DbSet<Models.Entity.Camera> Cameras { get; set; }
       public virtual DbSet<Session> Sessions { get; set; }

    }
}
    