using System;
using System.Drawing;
using System.Threading;

namespace DiceApp
{
    /// <summary>
    /// An object of this class represents a Triangle, that is painted on a canvas.
    /// 
    /// author: Rikard Karlsson
    /// 
    /// version: 2018 June
    /// </summary>
    class Triangle : Shape
    {


        /// <summary>
        /// Constructor used to create a Triangle object.
        /// </summary>
        public Triangle()
        {
            size = 10;
            xPosition = 100;
            yPosition = 100;
            color = "green";
        }

        /// <summary>
        /// Metod used by the class Canvas to draw the Triangle on the canvas.
        /// </summary>
        /// <param name="g">The Grapics object to draw on.</param>
        public override void Draw(Graphics g)
        {
            if (isVisible)
            {
                Color color = TranslateStringToColor(this.color);
                Point upperMiddle = new Point(xPosition + size / 2, yPosition);
                Point lowerLeft = new Point(xPosition, yPosition + size / 2);
                Point lowerRight = new Point(xPosition + size, yPosition + size / 2);
                Point [] points = { upperMiddle, lowerLeft, lowerRight };
                g.FillPolygon(new SolidBrush(color), points);
            }
        }

       
    }
}