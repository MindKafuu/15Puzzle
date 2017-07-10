using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game7
{
    public partial class P1_Score : Form
    {
        private string name;
        private int timeLeft;

        public P1_Score(string name, int timeLeft)
        {
            InitializeComponent();
            this.name = name;
            this.timeLeft = timeLeft;
        }

        private void P1_Score_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Comic Sans MS", 16, FontStyle.Bold);
            string[] input = Program.loadStat();

            g.DrawString("Name", font, Brushes.SaddleBrown,
                (this.Size.Width - this.PreferredSize.Width) / 12,
                (this.Size.Height / 8 - this.PreferredSize.Height / 8) - g.MeasureString("Name", font).Height / 2);
            g.DrawString("Time", font, Brushes.SaddleBrown,
                (this.Size.Width - this.PreferredSize.Width) / 10 * 8,
                (this.Size.Height / 8 - this.PreferredSize.Height / 8) - g.MeasureString("Time", font).Height / 2);

            for (int i = 0; i < input.Length; i++)
            {
                string[] buffer = input[i].Split(':');
                string name = buffer[0];
                int timeLeft = Int32.Parse(buffer[1]);

                g.DrawString(name, font, Brushes.Black,
                    (this.Size.Width - this.PreferredSize.Width) / 12,
                    (this.Size.Height / 4 - this.PreferredSize.Height / 4) - g.MeasureString(name, font).Height / 2 + i * 40);
                g.DrawString(timeLeft + " ", font, Brushes.Black,
                    (this.Size.Width - this.PreferredSize.Width) / 10 * 8,
                    (this.Size.Height / 4 - this.PreferredSize.Height / 4) - g.MeasureString(timeLeft + " ", font).Height / 2 + i * 40);
            }
        }

        private void P1_Score_Load(object sender, EventArgs e)
        {

        }

        private void P1_Score_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
