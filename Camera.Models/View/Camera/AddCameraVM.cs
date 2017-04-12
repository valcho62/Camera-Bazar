
using System.ComponentModel.DataAnnotations;
using Camera.Models.Entity;

namespace Camera.Models.View.Camera
{
    public class AddCameraVM
    {
      public CameraMake Make { get; set; }
        [Required]
        [RegularExpression("[A-Z0-9-]*",ErrorMessage = "Only capital letters, digits and dash")]
        public string Model { get; set; }
        public decimal Price { get; set; }
        [Range(0, 100, ErrorMessage = "Have to be between 0 and 100")]
        public int Quantity { get; set; }
        [Range(1,30,ErrorMessage = "Have to be between 1 and 30s")]
        public int? MinShatterSpeed { get; set; }
        [Range(2000, 8000, ErrorMessage = "Have to be between 2000 and 8000")]
        public int? MaxShatterSpeed { get; set; }
        [RegularExpression("^50$|^100$",ErrorMessage = "Have to be 50 or 100")]
        public int? MinISO { get; set; }
        [Range(200,409600,ErrorMessage = "Have to be between 200 and 409600")]
        [RegularExpression("^\\d+00$",ErrorMessage = "Have to be dividible by 100")]
        public int? MaxISO { get; set; }
        public bool IsFullFrame { get; set; }
        [StringLength(15,ErrorMessage = "Have to be max 15 symbols")]
        public string VideoResolution { get; set; }
        public CameraLight LightMetering { get; set; }
        [StringLength(600, ErrorMessage = "Have to be max 600 symbols")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [RegularExpression("^http:\\/\\/.+", ErrorMessage = "Must start with http:")]
        public string ImageURL { get; set; }
        public virtual Entity.User User { get; set; }

    }
}
