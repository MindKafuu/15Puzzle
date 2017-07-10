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
    public partial class P2_Play : Form
    {
        //ประกาศตัวแปร
        public Box[,] box, _box, checkbox, _checkbox;
        public int boxSize_X, boxSize_Y, x, y, count, _count;

        private void P2_Play_Load(object sender, EventArgs e)
        {

        }

        DialogResult press = new DialogResult();

        public P2_Play()
        {
            InitializeComponent();
            //กำหนดค่าตัวแปร
            box = new Box[4, 4]; //P1
            _box = new Box[4, 4]; //P2
            checkbox = new Box[4, 4]; //P1
            _checkbox = new Box[4, 4]; //P2
            x = 0;
            y = 0;
            boxSize_X = (this.Size.Width / 8 - this.PreferredSize.Width / 8);
            boxSize_Y = (((this.Size.Height / 4) - 13) - this.PreferredSize.Height / 4);

            //สร้างบล็อค 16 บล็อค 2ฝั่ง 2 ชุด
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    box[i, j] = new Box(i * boxSize_X, j * boxSize_X, (j + 1) + (i * 4));  //P1
                    _box[i, j] = new Box(i * boxSize_X, j * boxSize_X, (j + 1) + (i * 4)); //P2
                    checkbox[i, j] = new Box(i * boxSize_X, j * boxSize_X, (j + 1) + (i * 4)); //P1
                    _checkbox[i, j] = new Box(i * boxSize_X, j * boxSize_X, (j + 1) + (i * 4)); //P2
                }
            }
            Ran_Dom();

        }

        private void P2_Play_Time_Paint(object sender, PaintEventArgs e)
        {
            //build graphics
            Graphics g = e.Graphics;
            Font font1 = new Font("Comic Sans MS", 20, FontStyle.Bold); //font of Box
            Font font2 = new Font("Comic Sans MS", 30, FontStyle.Bold); //font of Time

            //draw Box and Font
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    // P1
                    if (box[i, j].num != 16)    //ไม่ต้องวาดหมายเลขให้บล็อคที่ 16
                    {
                        g.FillRectangle(Brushes.MediumOrchid, j * boxSize_X, i * boxSize_Y, boxSize_X, boxSize_Y);
                        g.DrawRectangle(Pens.Black, j * boxSize_X, i * boxSize_Y, boxSize_X, boxSize_Y);
                        //g.DrawImage(fig1, j * boxSize_X, i * boxSize_Y, boxSize_X, boxSize_Y);
                        g.DrawString(box[i, j].num + "", font1, Brushes.Black,
                            j * boxSize_X + boxSize_X / 2 - g.MeasureString(box[i, j].num + "", font1).Width / 2,
                            i * boxSize_Y + boxSize_Y / 2 - g.MeasureString(box[i, j].num + "", font1).Height / 2);
                    }
                    else    //วาดบล็อคที่ 16 เป็นสีเทา
                    {
                        g.FillRectangle(Brushes.Gray, j * boxSize_X, i * boxSize_Y, boxSize_X, boxSize_Y);
                        g.DrawRectangle(Pens.Black, j * boxSize_X, i * boxSize_Y, boxSize_X, boxSize_Y);
                    }

                    // P2
                    if (_box[i, j].num != 16)   //ไม่ต้องวาดหมายเลขให้บล็อคที่ 16
                    {

                        g.FillRectangle(Brushes.Tomato, 4 * boxSize_X + j * boxSize_X, i * boxSize_Y, boxSize_X, boxSize_Y);
                        g.DrawRectangle(Pens.Black, 4 * boxSize_X + j * boxSize_X, i * boxSize_Y, boxSize_X, boxSize_Y);
                        //g.DrawImage(fig2, 4 * boxSize_X + j * boxSize_X, i * boxSize_Y, boxSize_X, boxSize_Y);
                        g.DrawString(_box[i, j].num + "", font1, Brushes.Black,
                            4 * boxSize_X + j * boxSize_X + boxSize_X / 2 - g.MeasureString(_box[i, j].num + "", font1).Width / 2,
                            i * boxSize_Y + boxSize_Y / 2 - g.MeasureString(_box[i, j].num + "", font1).Height / 2);
                    }
                    else    //วาดบล็อคที่ 16 เป็นสีเทา
                    {
                        g.FillRectangle(Brushes.Gray, 4 * boxSize_X + j * boxSize_X, i * boxSize_Y, boxSize_X, boxSize_Y);
                        g.DrawRectangle(Pens.Black, 4 * boxSize_X + j * boxSize_X, i * boxSize_Y, boxSize_X, boxSize_Y);
                    }
                }
            }

            //draw Name P1
            g.DrawString("PLAYER 1", font2, Brushes.MediumSeaGreen, ((this.Size.Width / 4 - this.PreferredSize.Width / 4) - g.MeasureString("PALYER 1", font2).Width), 420);

            //draw Name P2
            g.DrawString("PLAYER 2", font2, Brushes.MediumSeaGreen, ((this.Size.Width - this.PreferredSize.Width) - g.MeasureString("PALYER 1", font2).Width) - 25, 420);
            Check();
        }

        private void P2_Play_Time_KeyDown(object sender, KeyEventArgs e)
        {
            //หาตำแหน่งของบล็อคที่ 16
            //P1
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (box[i, j].num == 16)
                    {
                        x = i;
                        y = j;
                    }
                }
            }
            //กำหนดตัวรับค่าปุ่มกด
            if (e.KeyCode == Keys.W && x + 1 < 4)  //กด W เลื่อนขึ้น
            {
                Box box1;
                box1 = box[x, y];
                box[x, y] = box[x + 1, y];
                box[x + 1, y] = box1;
            }
            if (e.KeyCode == Keys.S && x - 1 >= 0)    //กด S เลื่อนลง
            {
                Box box1;
                box1 = box[x, y];
                box[x, y] = box[x - 1, y];
                box[x - 1, y] = box1;
            }
            if (e.KeyCode == Keys.A && y + 1 < 4)     //กด A เลื่อนซ้าย
            {
                Box box1;
                box1 = box[x, y];
                box[x, y] = box[x, y + 1];
                box[x, y + 1] = box1;
            }
            if (e.KeyCode == Keys.D && y - 1 >= 0)    //กด D เลื่อนขวา
            {
                Box box1;
                box1 = box[x, y];
                box[x, y] = box[x, y - 1];
                box[x, y - 1] = box1;
            }

            //P2
            //หาตำแหน่งของบล็อคที่ 16
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (_box[i, j].num == 16)
                    {
                        x = i;
                        y = j;
                    }
                }
            }
            //กำหนดตัวรับค่าปุ่มกด
            if (e.KeyCode == Keys.Up && x + 1 < 4)    //กดลูกศรขึ้นเลื่อนขึ้น
            {
                Box box1;
                box1 = _box[x, y];
                _box[x, y] = _box[x + 1, y];
                _box[x + 1, y] = box1;
            }
            if (e.KeyCode == Keys.Down && x - 1 >= 0)     //กดลูกศรลงเลื่อนลง
            {
                Box box1;
                box1 = _box[x, y];
                _box[x, y] = _box[x - 1, y];
                _box[x - 1, y] = box1;
            }
            if (e.KeyCode == Keys.Left && y + 1 < 4)      //กดลูกศรซ้ายขึ้นเลื่อนซ้าย
            {
                Box box1;
                box1 = _box[x, y];
                _box[x, y] = _box[x, y + 1];
                _box[x, y + 1] = box1;
            }
            if (e.KeyCode == Keys.Right && y - 1 >= 0)    //กดลูกศรขวาเลื่อนขวา
            {
                Box box1;
                box1 = _box[x, y];
                _box[x, y] = _box[x, y - 1];
                _box[x, y - 1] = box1;
            }
            this.Invalidate();
        }

        private void Ran_Dom()
        {
            //สลับตำแหน่งบล็อคตอนเริ่มแรก 10000 รอบ
            Random rd = new Random();

            for (int a = 0; a < 10000; a++)
            {
                int n = rd.Next(0, 4);
                int x = 0, y = 0;
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (box[i, j].num == 16)
                        {
                            x = i;
                            y = j;
                        }
                    }
                }
                if (n == 0 && x + 1 < 4)    //สลับแถวที่ 1
                {
                    //P1
                    Box box1;
                    box1 = box[x, y];
                    box[x, y] = box[x + 1, y];
                    box[x + 1, y] = box1;

                    //P2
                    box1 = _box[x, y];
                    _box[x, y] = _box[x + 1, y];
                    _box[x + 1, y] = box1;
                }
                if (n == 1 && x - 1 >= 0)   //สลับแถวที่ 2
                {
                    //P1
                    Box box1;
                    box1 = box[x, y];
                    box[x, y] = box[x - 1, y];
                    box[x - 1, y] = box1;

                    //P2
                    box1 = _box[x, y];
                    _box[x, y] = _box[x - 1, y];
                    _box[x - 1, y] = box1;
                }
                if (n == 2 && y + 1 < 4)    //สลับแถวที่ 3
                {
                    //P1
                    Box box1;
                    box1 = box[x, y];
                    box[x, y] = box[x, y + 1];
                    box[x, y + 1] = box1;

                    //P2
                    box1 = _box[x, y];
                    _box[x, y] = _box[x, y + 1];
                    _box[x, y + 1] = box1;
                }
                if (n == 3 && y - 1 >= 0)   //สลับแถวที่ 4
                {
                    //P1
                    Box box1;
                    box1 = box[x, y];
                    box[x, y] = box[x, y - 1];
                    box[x, y - 1] = box1;

                    //P2
                    box1 = _box[x, y];
                    _box[x, y] = _box[x, y - 1];
                    _box[x, y - 1] = box1;
                }
            }
        }

        private void Check()
        {
            //เช็คตำแหน่งว่าเราเรียงบล็อคถูกหรือป่าว
            count = 0;
            _count = 0;

            //หาตำแหน่งของทุกบล็อค
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //P1
                    Console.WriteLine(checkbox[i, j].num + " : " + box[i, j].num);
                    if (checkbox[i, j].num == box[i, j].num)    //เช็คว่าตำแหน่งของบล็อคที่เราเรียงตรงกับบล็อคอีกชุดที่เราสร้างขึ้นที่ไม่ได้สลับตำแหน่ง
                    {
                        count++;
                        if (count == 16)    //ถ้าตำแหน่งถูกต้องทุกบล็อค จะจบเกม
                        {
                            press = MessageBox.Show("PLAYER 1 WIN!!!", "Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (press == DialogResult.No)
                                Application.Exit();
                        }
                    }

                    //P2
                    Console.WriteLine(_checkbox[i, j].num + " : " + _box[i, j].num);
                    if (_checkbox[i, j].num == _box[i, j].num)      //เช็คว่าตำแหน่งของบล็อคที่เราเรียงตรงกับบล็อคอีกชุดที่เราสร้างขึ้นที่ไม่ได้สลับตำแหน่ง
                    {
                        _count++;
                        if (_count == 16)       //ถ้าตำแหน่งถูกต้องทุกบล็อค จะจบเกม
                        {
                            press = MessageBox.Show("PLAYER 2 WIN!!!", "Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (press == DialogResult.No)
                                Application.Exit();
                        }
                    }
                }
            }
            Console.WriteLine(count);
            Console.WriteLine(_count);
        }
    }
}
