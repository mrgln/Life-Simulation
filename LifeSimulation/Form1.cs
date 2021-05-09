using System;
using System.Drawing;
using System.Windows.Forms;

namespace LifeSimulation
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int scale;
        private GameSystem gameSystem;


        public Form1()
        {
            InitializeComponent();
        }


        private void StartGame()
        {
            if (timer1.Enabled)
                return;

            nupdDensity.Enabled = false;
            nupdScale.Enabled = false;
            scale = (int)nupdScale.Value;

            gameSystem = new GameSystem
            (
                rows: pictureBox1.Height / scale,
                cols: pictureBox1.Width / scale,
                density: (int)(nupdDensity.Minimum) + (int)(nupdDensity.Maximum) - (int)nupdDensity.Value
            );

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            timer1.Start();
        }

        private void StopGame()
        {
            if (!timer1.Enabled)
                return;
            timer1.Stop();
            nupdDensity.Enabled = true;
            nupdScale.Enabled = true;

        }

        private void NewGeneration()
        {
            graphics.Clear(Color.Black);

            var field = gameSystem.GetCurrentGeneration();

            for (int x = 0; x < field.GetLength(0); x++)
            {
                for (int y = 0; y < field.GetLength(1); y++)
                {
                    if(field[x,y])
                    {
                        graphics.FillRectangle(Brushes.Aqua, x * scale, y * scale, scale - 1, scale - 1);
                    }
                }
            }

            pictureBox1.Refresh();
            gameSystem.NewGeneration();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {NewGeneration();}

        private void buttonStop_Click(object sender, EventArgs e)
        {StopGame();}

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (timer1.Enabled == false)
                return;

            if (e.Button == MouseButtons.Left)
            {
                var x = e.Location.X / scale;
                var y = e.Location.Y / scale;
                gameSystem.AddCell(x, y);
            }

            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / scale;
                var y = e.Location.Y / scale;
                gameSystem.RemoveCell(x, y);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {StartGame();}
    }
}
