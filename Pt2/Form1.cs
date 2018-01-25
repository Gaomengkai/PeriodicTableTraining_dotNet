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

namespace Pt2
{
    public partial class Form1 : Form
    {
        int choice=3;
        int rd;
        int w = 0, r = 0, d = 0;
        String rr = "正确：";
        String ww = "错误：";
        String dd = "未回答：";
        String tt = "0:0:0.00";
        Stopwatch sw;
        TimeSpan ts;
        TimeSpan Last;
        bool isFirst = false;
        TimeSpan empty = new TimeSpan(0, 0, 0, 0, 0);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewMethod12();
        }

        public void NewMethod12()
        {
            this.AcceptButton = Send;
            Min.Text = "1";
            Max.Text = "20";
            isFirst = true;
            Refresh0();
        }

        public void Refresh0()
        {
            //TODO : 刷新界面，填充新元素
            Entered.Text = null;
            Random random = new Random();
            int min = Convert.ToInt32(Min.Text);
            int max = Convert.ToInt32(Max.Text);
            rd = random.Next(min, max + 1);
            Element element = new Element(rd);
            String name = element.GetName();
            String sign = element.GetSign();
            String stmp = null ;
            switch (choice)
            {
                case 3:
                    stmp = sign;
                    break;
                case 1:
                    stmp = name;
                    break;
                case 2:
                    stmp = Convert.ToString(rd);
                    break;
                default:
                    break;
            }
            Show.Text = stmp;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                choice = 3;
            }
            isFirst = true;
            StopTime();
            Refresh0();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                choice = 1;
            }
            isFirst = true;
            StopTime();
            Refresh0();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                choice = 2;
            }
            isFirst = true;
            StopTime();
            Refresh0();
        }

        public void Judge0(int innn)
        {
            if (innn == rd)
            {
                r++;
                Tip.Text = "回答正确";
                Tip.ForeColor = Color.Lime;
                Yes.Text = rr + Convert.ToString(r);
            }
            else
            {
                w++;
                Tip.Text = "回答错误，正确答案：" + Convert.ToString(rd);
                Tip.ForeColor = Color.OrangeRed;
                Wro.Text = ww + Convert.ToString(w);
            }
            Refresh0();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            String s = Entered.Text;
            if (s != "") { 
            if (s[0] < 'A' && (choice == 1 || choice == 3))
            {
                Judge0(Convert.ToInt32(s));
            }
            else
            {
                Judge1(s);
            }
            }
            else
            {
                DidNotAnswer();
            }
            isFirst = false;
            Last = ReadTime();
            if (Last.Equals(empty)){
                isFirst = true;
            }
        }

        private void DidNotAnswer()
        {
            if (choice == 2)
            {
                d++;
                Tip.ForeColor = Color.Orange;
                Tip.Text = "请回答问题!答案：" + Libraries.numToSign[rd];
                DNA.Text = dd + Convert.ToString(d);
            }
            else
            {
                d++;
                Tip.ForeColor = Color.Orange;
                Tip.Text = "请回答问题!答案：" + Convert.ToString(rd);
                DNA.Text = dd + Convert.ToString(d);
            }
            Refresh0();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ts = sw.Elapsed;
            STWC.Text = String.Format("{0}:{1}:{2}.{3}", 
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        }

        private void Entered_TextChanged(object sender, EventArgs e)
        {
            if (isFirst)
            {
                StartTime();
            }
        }

        private void Judge1(String s)
        {
            if (s == Libraries.numToSign[rd])
            {
                r++;
                Tip.Text = "回答正确";
                Tip.ForeColor = Color.Lime;
                Yes.Text = rr + Convert.ToString(r);
            }
            else
            {
                w++;
                Tip.Text = "回答错误，正确答案：" + Libraries.numToSign[rd];
                Tip.ForeColor = Color.OrangeRed;
                Wro.Text = ww + Convert.ToString(w);
            }
            Refresh0();
        }

        private void StartTime()
        {
            sw = new System.Diagnostics.Stopwatch();
            ts = new TimeSpan();
            timer1.Interval = 1;
            sw.Start();
            timer1.Start();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            StopTime();
        }

        private void ResetTime()
        {
            timer1.Stop();
            sw.Stop();
            STWC.Text = tt;

        }

        private void StopTime()
        {
            timer1.Stop();
            sw.Stop();
            STWC.Text = String.Format("{0}:{1}:{2}.{3}",
                Last.Hours, Last.Minutes, Last.Seconds, Last.Milliseconds / 10);
            isFirst = true;
        }

        private TimeSpan ReadTime()
        {
            if (sw != null)
            {
                return sw.Elapsed;
            }
            else
            {
                return empty;
            }
        }


    }        
}


