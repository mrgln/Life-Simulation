using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeSimulation
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int scale;
        public Form1()
        {
            InitializeComponent();
        }


        private void StartGame()
        {
            if (timer1.Enabled)
                return;

            scale = (int)nupdScale.Value;
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }
    }
}
