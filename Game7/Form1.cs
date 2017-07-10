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
    public partial class Form1 : Form
    {
        public int _choose_player;
        

        public Form1()
        {
            InitializeComponent();
            _choose_player = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _choose_player = 1;
            if (_choose_player == 1)
            {
                P2_Login _login = new P2_Login();
                _login.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _choose_player = 1;
            if (_choose_player == 1)
            {
                P1_Login login = new P1_Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
