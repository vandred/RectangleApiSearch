using System.ComponentModel.DataAnnotations;

namespace RectangleWebApi.ViewModel
{
    public class PointView
    {
        [Required]
        public int PointX { get; set; }
        [Required]
        public int PointY { get; set; }
    }
}
