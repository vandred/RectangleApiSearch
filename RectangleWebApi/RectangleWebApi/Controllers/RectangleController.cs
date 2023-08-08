using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RectangleWebApi.ViewModel;
using System.Text.Json;

namespace RectangleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RectangleController : ControllerBase
    {
        // GET: api/Rectangle
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var classSeed = new RectangleWebApi.EFCore.Seed();

            var rectangles = classSeed.GenerateRectangles(200);

            var points = classSeed.GeneratePoints(200);

            string jsonRectangles = JsonSerializer.Serialize(rectangles.FirstOrDefault());
            string jsonPoints = JsonSerializer.Serialize(points.FirstOrDefault());

            return new string[] { "rectangles", jsonRectangles, "points",jsonPoints };
        }

        [HttpPost]
        public IEnumerable<string> PostListOfPoints(List<PointView> points)
        {

            string jsonPoints = JsonSerializer.Serialize(points.FirstOrDefault());

            return new string[] {  "points", jsonPoints };
        }
    }
}
