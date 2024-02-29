using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceApp
{
    public partial class DiceAppForm : Form
    {
        private Dice dice;

        public DiceAppForm()
        {
            InitializeComponent();
            //this.SetStyle(ControlStyles.UserPaint, true);
            //this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dice = new Dice();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            //canvas.Clear();
            dice.Roll();
        }

    }
}
