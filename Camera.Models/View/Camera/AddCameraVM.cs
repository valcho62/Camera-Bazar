
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
        [Range(0,100,ErrorMessage = "Have to be between 0 and 100")]
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int MinShatterSpeed { get; set; }
        public int MaxShatterSpeed { get; set; }
        public int MinISO { get; set; }
        public int MaxISO { get; set; }
        public bool IsFullFrame { get; set; }
        public string VideoResolution { get; set; }
        public CameraLight LightMetering { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
       
    }
}
