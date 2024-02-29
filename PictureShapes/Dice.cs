using System;

namespace DiceApp
{
    class Dice
    {
        private Square dice;
        private Circle dot0;
        private Circle dot1;
        private Circle dot2;
        private Circle dot3;
        private Circle dot4;
        private Circle dot5;
        private Circle dot6;
        private Circle dot7;

        // number of dots to display
        private int number;

        private static Random randomGenerator;

        public Dice()
        {
            DrawDice();
            randomGenerator = new Random();
        }
        private void DrawDice()
        {
            // dot ordering
            // 1   4
            // 5 0 6
            // 3   2
            dice = new Square();
            dot0 = new Circle();
            dot1 = new Circle();
            dot2 = new Circle();
            dot3 = new Circle();
            dot4 = new Circle();
            dot5 = new Circle();
            dot6 = new Circle();
            dot7 = new Circle();

            dice.ChangeColor("white");
            dice.ChangeSize(240);
            dice.MoveVertical(-100);

            dot0.ChangeSize(40);
            dot1.ChangeSize(40);
            dot2.ChangeSize(40);
            dot3.ChangeSize(40);
            dot4.ChangeSize(40);
            dot5.ChangeSize(40);
            dot6.ChangeSize(40);

            dot0.MoveHorizontal(50);
            dot0.MoveVertical(170);

            dot1.MoveHorizontal(50 - 80);
            dot1.MoveVertical(170 - 80);

            dot2.MoveHorizontal(50 + 80);
            dot2.MoveVertical(170 + 80);

            dot3.MoveHorizontal(50 + 80);
            dot3.MoveVertical(170 - 80);

            dot4.MoveHorizontal(50 - 80);
            dot4.MoveVertical(170 + 80);

            dot5.MoveHorizontal(50 - 80);
            dot5.MoveVertical(170);

            dot6.MoveHorizontal(50 + 80);
            dot6.MoveVertical(170);

            dice.MakeVisible();
            dot0.MakeVisible();
            dot1.MakeVisible();
            dot2.MakeVisible();
            dot3.MakeVisible();
            dot4.MakeVisible();
            dot5.MakeVisible();
            dot6.MakeVisible();
        }

        /// <summary>
        /// Roll the die. The new value is displayed.
        /// </summary>
        public void Roll()
        {
            number = randomGenerator.Next(6) + 1;

            HideAllDots();

            if (IsOdd(number))
            {
                // show middle
                dot0.MakeVisible();
            }
            if (number >= 2)
            {
                dot1.MakeVisible();
                dot2.MakeVisible();
            }
            if (number >= 4)
            {
                dot3.MakeVisible();
                dot4.MakeVisible();
            }
            if (number == 6)
            {
                dot5.MakeVisible();
                dot6.MakeVisible();
            }
        }
        private void HideAllDots()
        {
            dot0.MakeInVisible();
            dot1.MakeInVisible();
            dot2.MakeInVisible();
            dot3.MakeInVisible();
            dot4.MakeInVisible();
            dot5.MakeInVisible();
            dot6.MakeInVisible();

        }
        private bool IsOdd(int number)
        {
            return number % 2 == 1;
        }


    }
}
