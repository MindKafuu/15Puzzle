using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game7
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static string[] loadStat()
        {
            return System.IO.File.ReadAllLines("stat.txt");
        }

        public static void saveStat(string name, int time)
        {
            try
            {
                string[] input = System.IO.File.ReadAllLines("stat1.txt");
                string[] stat = new string[((input.Length < 5) ? input.Length + 1 : 5)];
                int i;

                for (i = 0; i < input.Length; i++)
                {
                    string[] buffer = input[i].Split(':');
                    string a = buffer[0];
                    int b = Int32.Parse(buffer[1]);

                    if (b <= time)
                        stat[i] = input[i];
                    else
                    {
                        stat[i] = name + ":" + time;
                        i++;
                        break;
                    }
                }

                for (; i < stat.Length; i++)
                {
                    stat[i] = input[i - 1];
                }

                System.IO.File.WriteAllLines("stat.txt", stat);

            }
            catch (System.IO.FileNotFoundException)
            {
                System.IO.File.WriteAllText("stat.txt", name + ":" + time);
            }

        }
    }
}
