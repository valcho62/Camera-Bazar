
using Camera.Models.Entity;

namespace Camera.Models.View.Camera
{
    public class AllCameraVM
    {
        public int Id { get; set; }
        public CameraMake Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string ImageURL { get; set; }

    }
}
