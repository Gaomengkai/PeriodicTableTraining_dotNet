using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;

namespace Pt2
{
    public partial class Form1 : Form
    {
        //Initialize ALL the global variables
        int choice = 3;
        int rd;
        int w = 0, r = 0, d = 0;
        double a;
        String rr = "正确：";
        String ww = "错误：";
        String dd = "未回答：";
        String tt = "0:0:0.0";
        Stopwatch sw;
        TimeSpan ts;
        TimeSpan Last;
        bool isFirst = false;
        TimeSpan empty = new TimeSpan(0, 0, 0, 0, 0);
        String aa = null;
        String Version = "Alpha19";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (sender == null)
            {
                throw new ArgumentNullException(nameof(sender));
            }
            byte[] obj = (byte[])Pt.Properties.Resources.ResourceManager.GetObject("office2007");
            Sunisoft.IrisSkin.SkinEngine skin = new Sunisoft.IrisSkin.SkinEngine((System.ComponentModel.Component)this)
            {
                //byte[] obj = Properties.Resources.office2007;
                SkinStream = new MemoryStream(obj),
                TitleFont = new System.Drawing.Font("微软雅黑", 10F)// 指定标题栏的Font。
            };
            NewMethod12();
        }

        public void NewMethod12()
        {
            //First running initialization
            this.Text = "元素周期表问答 " + Version;
            aa = Anyli.Text;
            this.AcceptButton = Send;
            isFirst = true;
            Refresh0();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                RBC(3);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                RBC(1);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                RBC(2);
            }
        }

        private void rB4_CheckedChanged(object sender, EventArgs e)
        {
            if (rB4.Checked) { RBC(4); }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (sender == null)
            {
                throw new ArgumentNullException(nameof(sender));
            }
            //Send the content which the user inputed to our program
            String s = Entered.Text;        //We need the type of String
            if (s != "")                    //Judge whether the user has inputed data or not
            {
                if (s[0] < 'A' && (choice == 1 || choice == 3))
                {
                    JUDGE_ALL(isYes: Convert.ToInt32(s) == rd);
                }
                else if (choice == 2)
                {
                    JUDGE_ALL(isYes: s == Libraries.numToSign[rd]);//The user inputed a type of String
                }
                else if (choice == 4)
                {
                    JUDGE_ALL(isYes: Math.Abs(Convert.ToDouble(s) - Libraries.numToZ[rd]) < 0.4);
                }
            }
            else
            {
                DidNotAnswer();                 //The user did not input anything
            }
            isFirst = false;                    //The user lost the FIRST //Hahahahahaha
            Last = ReadTime();                  //Let's get the time when the user inputed data
            a = (double)r * 100 / (r + w);
            Anyli.Text = aa + a.ToString("0.00") + "%";

            if (Last.Equals(empty))
            {
                isFirst = true;                 //But this time stwc hasn't begun working!
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //The event of REFRESH and REFRESH
            //By this we can view the time at real time
            ts = sw.Elapsed;
            STWC.Text = String.Format("{0}:{1}:{2}.{3}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);//Format the time
        }

        private void Entered_TextChanged(object sender, EventArgs e)
        {
            //If the user changed the TextBox, we need to start the stopwatch
            if (isFirst)
            {
                StartTime();
                isFirst = false;
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            //If the user cilcked this button, we need STOP THE TIME!
            StopTime();
        }

        private void RST_Click(object sender, EventArgs e)
        {
            CompletelyRestart();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About openq = new About();
            byte[] obj = (byte[])Pt.Properties.Resources.ResourceManager.GetObject("office2007");
            Sunisoft.IrisSkin.SkinEngine skin = new Sunisoft.IrisSkin.SkinEngine(openq)
            {
                SkinStream =  new MemoryStream(obj),
                //SkinFile = "Office2007.ssk",
                TitleFont = new System.Drawing.Font("微软雅黑", 10F)// 指定标题栏的Font。
            };
            openq.Show();
        }

        private void Min_TextChanged(object sender, EventArgs e)
        {
            Refresh0();
        }

        private void Max_TextChanged(object sender, EventArgs e)
        {
            Refresh0();
        }

    }
}
