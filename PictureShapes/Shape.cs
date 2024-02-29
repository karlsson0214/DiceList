using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DiceApp
{
    public abstract class Shape
    {
        protected int size;
        protected int xPosition;
        protected int yPosition;
        protected bool isVisible;
        protected String color;

        /// <summary>
        /// Get or set size of shape.
        /// </summary>
        public int Size
        {
            get { return size; }
            set
            {
                if (value > 0)
                {
                    size = value;
                }
                Draw();
            }
        }
        /// <summary>
        /// Get or set x position.
        /// </summary>
        public int XPosition
        {
            get { return xPosition; }
            set
            {
                xPosition = value;
                Draw();
            }
        }
        /// <summary>
        /// Get or set y position.
        /// </summary>
        public int YPostion
        {
            get { return yPosition; }
            set
            {
                yPosition = value;
                Draw();
            }
        }
        /// <summary>
        /// Override method in subclass and implement drawing.
        /// </summary>
        /// <param name="g"></param>
        public abstract void Draw(Graphics g);

        /// <summary>
        /// Show the Circle on the canvas.
        /// </summary>
        public void MakeVisible()
        {
            isVisible = true;
            Draw();
        }

        /// <summary>
        /// Make the Circle invisible.
        /// </summary>
        public void MakeInVisible()
        {
            isVisible = false;
            Draw();
        }

        /// <summary>
        /// Change the color of the Circle. 
        /// </summary>
        /// <param name="color">The name of the new color as a string. 
        /// Available colors are: "red", "green", "blue", "yellow", "magenta", "cyan", "black", and "white".
        /// </param>
        public void ChangeColor(String color)
        {
            this.color = color;
            Draw();
        }

        /// <summary>
        /// Change the size of the Circle.
        /// </summary>
        /// <param name="size">The new size in pixels.</param>
        public void ChangeSize(int size)
        {
            if (size > 0)
            {
                this.size = size;
            }
            Draw();
        }

        /// <summary>
        /// Move the Circle horizontally.
        /// </summary>
        /// <param name="distance">The distance to move the circle to the right.</param>
        public void MoveHorizontal(int distance)
        {
            xPosition = xPosition + distance;
            Draw();
        }

        /// <summary>
        /// Move the Circle vertically.
        /// </summary>
        /// <param name="distance">The distance to move the circle down.</param>
        public void MoveVertical(int distance)
        {
            yPosition = yPosition + distance;
            Draw();
        }

        // Redraw the circle on the canvas. Make changes visible.
        private void Draw()
        {
            //Canvas canvas = Canvas.GetCanvas();
            Canvas canvas = Canvas.Self;
            canvas.Draw(this);

        }
        // Translate a color from a string to an object of the class Color.
        // Returns the color object.
        protected Color TranslateStringToColor(String color)
        {
            if (color.Equals("red"))
            {
                return Color.Red;
            }
            if (color.Equals("green"))
            {
                return Color.Green;
            }
            if (color.Equals("blue"))
            {
                return Color.Blue;
            }
            if (color.Equals("magenta"))
            {
                return Color.Magenta;
            }
            if (color.Equals("cyan"))
            {
                return Color.Cyan;
            }
            if (color.Equals("yellow"))
            {
                return Color.Yellow;
            }
            if (color.Equals("white"))
            {
                return Color.White;
            }
            if (color.Equals("black"))
            {
                return Color.Black;
            }
            return Color.Brown;
        }
    }
}
