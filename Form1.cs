using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ai_Project___N_queen
{
    public partial class Form1 : Form
    {
        private int n = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            try
            {
                n = int.Parse(nValue.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid value for N: " + ex.Message);
                return;
            }

            DrawChessBoard();
        }


        private void DrawChessBoard()
        {
            int size = panel1.Width / n;

            panel1.Controls.Clear();

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Panel cell = new Panel();
                    cell.Size = new Size(size, size);
                    cell.Location = new Point(col * size, row * size);

                    if ((row + col) % 2 == 0)
                    {
                        cell.BackColor = Color.White;
                    }
                    else
                    {
                        cell.BackColor = Color.Black;
                    }

                    panel1.Controls.Add(cell);
                }
            }
        }


    }

}
       
