using System;
using System.Drawing;
using System.Threading;

namespace DiceApp
{
    /// <summary>
    /// An object of this class represents a Square, that is painted on a canvas.
    /// 
    /// author: Rikard Karlsson
    /// 
    /// version: 2018 June
    /// </summary>
    class Square : Shape
    {

        /// <summary>
        /// Constructor used to create a Square object.
        /// </summary>
        public Square()
        {
            size = 50;
            xPosition = 50

            yPosition = 200;
            color = "magenta";
        }

        /// <summary>
        /// Metod used by the class Canvas to draw the Square on the canvas.
        /// </summary>
        /// <param name="g">The Grapics object to draw on.</param>
        public override void Draw(Graphics g)
        {
            if (isVisible)
            {
                Color color = TranslateStringToColor(this.color);
                g.FillRectangle(new SolidBrush(color), xPosition, yPosition, size, size);
            }
        }

    }
}