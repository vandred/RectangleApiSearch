using RectangleWebApi.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleWebApi.EFCore
{
    public class Seed
    {
        // generate method return 200 random rectangles with random points
        public List<RectangleStored> GenerateRectangles(int count)
        {
            var rectangles = new List<Rectangle>();
            var random = new Random();

            for (int i = 0; i < count; i++)
            {
                var rectangle = new Rectangle()
                {
                    X = random.Next(0, 100),
                    Y = random.Next(0, 100),
                    Width = random.Next(0, 300),
                    Height = random.Next(0, 300)
                };
                rectangles.Add(rectangle);
            }

            List<RectangleStored> result = rectangles.Select(r => new RectangleStored()
            {
                PointX = r.X,
                PointY = r.Y,
                Width = r.Width,
                Height = r.Height
            }).ToList();
            return result;
        }

        // generate method return 200 random points
        public List<PointStored> GeneratePoints(int count)
        {
            var points = new List<Point>();
            var random = new Random();

            for (int i = 0; i < count; i++)
            {
                var point = new Point()
                {
                    X = random.Next(0, 100),
                    Y = random.Next(0, 100)
                };
                points.Add(point);
            }
            var result = points.Select(p => new PointStored()
            {
                PointX = p.X,
                PointY = p.Y
            }).ToList();
            return result;
        }
    }
}
