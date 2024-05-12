using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Arkanoid_IT2
{
    public class Ball : GameObject
    {
        // co by mel mit ball za vlastnosti:
        // velikost, rychlost pohybu, pohyb (x, y), barvu

        public int Size { get; }
        public double Speed { get; set; }
        public double XPos { get; set; }
        public double YPos { get; set; }
        //public SolidColorBrush color;

        // double speed, double xpos, double ypos, SolidColorBrush brush
        // Speed = speed;
        // XPos = xpos;
        // YPos = ypos;
        // color = brush;
        public Ball(int size)
        {
            Size = size;

        }

        public override void Draw(Canvas canvas)
        {
            Ellipse ball = new Ellipse
            {
                Width = Size,
                Height = Size,
                Fill = Brushes.White,
            };
            Canvas.SetLeft(ball, Location.X + Size);
            Canvas.SetTop(ball, Location.Y + Size);

            canvas.Children.Add(ball);

        }
    }
}
