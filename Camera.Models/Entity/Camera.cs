
namespace Camera.Models.Entity
{
    public enum CameraMake
    {
        Canon,Nikon,Penta,Sony
    }

    public enum CameraLight
    {
        Spot,Center_weighted,Evaluative
    }
    public class Camera
    {
        public int Id { get; set; }
        public CameraMake Make { get; set; }
        public string Model { get; set; }
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
        public virtual User User { get; set; }

    }
}
