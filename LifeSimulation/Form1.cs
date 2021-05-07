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
        private bool[,] field;
        private int rows, columns;

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
            rows = pictureBox1.Height / scale;
            columns = pictureBox1.Width / scale;

            field = new bool[columns, rows];

            Random random = new Random();
            for (int x = 0; x < columns; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = random.Next((int)nupdDensity.Value) == 0;
                }
            }

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

            var newField = new bool[columns,rows];

            for (int x = 0; x < columns; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var neighbourCount = CountNeighbours(x, y);
                    var hasLife = field[x, y];

                    if(!hasLife && neighbourCount == 3)
                        newField[x, y] = true;
                    else if(hasLife && (neighbourCount<2 || neighbourCount>3))
                        newField[x,y] = false;
                    else
                        newField[x, y] = field[x, y];
                    
                    if (hasLife)
                        graphics.FillRectangle(Brushes.Aqua, x * scale, y * scale, scale, scale);
                }
            }
            field = newField;
            pictureBox1.Refresh();
        }


        private int CountNeighbours(int x, int y)
        {
            int counter = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + columns) % columns;
                    var row = (y + j + rows) % rows; 

                    var isSelfChecking = col == x && row == y;
                    var hasLife = field[col, row];

                    if (hasLife && !isSelfChecking)
                        counter++;
                }
            }
            return counter;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NewGeneration();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (timer1.Enabled == false)
                return;

            if(e.Button==MouseButtons.Left)
            {
                var x = e.Location.X / scale;
                var y = e.Location.Y / scale;

                var validationPassed = CheckMousePosition(x, y);

                if(validationPassed)
                    field[x, y] = true;
            }

            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / scale;
                var y = e.Location.Y / scale;

                var validationPassed = CheckMousePosition(x, y);

                if (validationPassed)
                    field[x, y] = false;
            }
        }

        private bool CheckMousePosition(int x,int y)
        {
            return x >= 0 && y >= 0 && x < columns && y < rows;
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }
    }
}
