using System;
using System.Collections.Generic;

namespace DiceApp
{
    class Dice
    {
        // object variables - graphics
        private Square dice;
        private List<Circle> dots = new List<Circle>();

        // number of dots to display
        private int number;

        private static Random randomGenerator;

        /// <summary>
        /// Create an object of the class Dice. Make a Dice.
        /// </summary>
        public Dice()
        {
            randomGenerator = new Random();

            // Create circle and set properties. Add to list dots.
            Circle dot = new Circle();
            dot.Size = 33;
            dots.Add(dot);
            // Add your code ...

            // Different order. Create circle and add to list dots. Change property on cirkle.
            Cirle.Add(new Circle());
            dots[1].Size = 33;

            // Add your code ...
        }

        /// <summary>
        /// Roll the die. The new value is displayed.
        /// </summary>
        public void Roll()
        {
            number = randomGenerator.Next(6) + 1;

            // Add your code


        }
        /// <summary>
        /// Check if number is odd or even.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>true if number is odd, otherwise false</returns>
        private bool IsOdd(int number)
        {
            return number % 2 == 1;
        }


    }
}
