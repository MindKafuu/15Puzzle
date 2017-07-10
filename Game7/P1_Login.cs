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
    public partial class P1_Login : Form
    {
        public int choose_game;

        public P1_Login()
        {
            InitializeComponent();
            choose_game = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            choose_game = 1;
            if(checkBox1.Checked == true && checkBox2.Checked == false)
            {
                P1_Play play = new P1_Play();
                play.Show();
                this.Hide();
            }
            if (checkBox2.Checked == true && checkBox1.Checked == false)
            {
                P1_Play_Time play1 = new P1_Play_Time(textBox1.Text.Length > 0 ? textBox1.Text : "");
                play1.Show();
                this.Hide();
            }
        }

        private void P1_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
