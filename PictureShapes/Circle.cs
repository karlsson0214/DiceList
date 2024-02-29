using System;
using System.Drawing;
using System.Threading;

namespace DiceApp
{
    /// <summary>
    /// An object of this class represents a Circle, that is painted on a canvas.
    /// 
    /// author: Rikard Karlsson
    /// 
    /// version: 2018 June
    /// </summary>
    class Circle : Shape
    {


        /// <summary>
        /// Constructor used to create a Circle object.
        /// </summary>
        public Circle()
        {
            size = 50;
            xPosition = 100;
            yPosition = 30;
            color = "red";
        }

        
        /// <summary>
        /// Metod used by the class Canvas to draw the Circle on the canvas.
        /// </summary>
        /// <param name="g">The Grapics object to draw on.</param>
        public override void Draw(Graphics g)
        {
            if (isVisible)
            {
                Color color = TranslateStringToColor(this.color);
                g.FillEllipse(new SolidBrush(color), xPosition, yPosition, size
                    , size); //only difference
                //Wait(10);
            }
        }


    }
}