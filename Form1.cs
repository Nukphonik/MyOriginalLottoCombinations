using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOriginalLottoCombinations
{
    public partial class Form1 : Form
    {
        int recordcount, recordcounter;

        public Form1()
        {
            InitializeComponent();
        }

        private void Compare_Click(object sender, EventArgs e)
        {
            StreamReader original = new StreamReader("DailyLotto.txt");
            StreamReader MySeq = new StreamReader("ComSeq.txt");
            string z, y, searching;
            string[] x = new string[recordcounter];
            string[] t = new string[recordcount];
            int mycount, mycounter;


            for (mycount = 0; mycount < recordcount; mycount++)
            {
                t[mycount] = MySeq.ReadLine();
            }
            MySeq.Close();
            MySeq.Dispose();
            for (mycounter = 0; mycounter < recordcounter; mycounter++)
            {
                x[mycounter] = original.ReadLine();

            }
            original.Close();
            original.Dispose();

            for (mycount = 0; mycount < recordcount; mycount++)
            {
                for (mycounter = 0; mycounter < recordcounter; mycounter++)
                {
                    if (x[mycounter] == t[mycount])
                    {
                        MessageBox.Show(x[mycounter], " Already won");
                    }
                }
            }
        }


        private void Load_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("DailyLotto.txt");
            StreamReader SR = new StreamReader("ComSeq.txt");
            string x, y;
            x = sr.ReadLine();
            y = SR.ReadLine();
            recordcount = 0;
            recordcounter = 0;


            while (y != null)
            {
                listBox2.Items.Add(y);
                y = SR.ReadLine();
                recordcount = recordcount + 1;
            }

            while (x != null)
            {
                listBox1.Items.Add(x);
                x = sr.ReadLine();
                recordcounter = recordcounter + 1;
            }

        }
    }
}