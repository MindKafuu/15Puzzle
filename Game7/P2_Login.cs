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
    public partial class P2_Login : Form
    {
        public int _play_game;

        public P2_Login()
        {
            InitializeComponent();
            _play_game = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _play_game = 1;
            if (checkBox2.Checked == true && checkBox1.Checked == false)
            {
                P2_Play_Time _play = new P2_Play_Time (textBox1.Text.Length > 0 ? textBox1.Text : "");
                _play.Show();
                this.Hide();
            }
            if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                P2_Play _play1 = new P2_Play();
                _play1.Show();
                this.Hide();
            }
        }

        private void P2_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
