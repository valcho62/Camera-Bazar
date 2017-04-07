
using System.ComponentModel.DataAnnotations;

namespace Camera.Models.Entity
{
    public class Session
    {
        [Key]
        public string SessionId { get; set; }

        public bool IsActive { get; set; }
        public virtual User User { get; set; }
    }
}
