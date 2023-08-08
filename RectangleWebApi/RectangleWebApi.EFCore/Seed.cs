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
        public List<Rectangle> Generate(int count)
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
            return rectangles;
        }

        // generate method return 200 random points
        public List<Point> GeneratePoints(int count)
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
            return points;
        }
    }
}
