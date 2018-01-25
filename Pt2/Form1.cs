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
        //TODO : Initialize ALL the global variables
        int choice = 3;
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
            //TODO : First running initialization
            this.AcceptButton = Send;
            Min.Text = "1";
            Max.Text = "20";
            isFirst = true;
            Refresh0();
        }

        public void Refresh0()
        {
            //TODO : Refresh all the elements and to fill the Labels
            Entered.Text = null;
            Random random = new Random();           //We need random
            int min = Convert.ToInt32(Min.Text);    //Dafault is 1
            int max = Convert.ToInt32(Max.Text);    //Dafault is 20
            rd = random.Next(min, max + 1);         //Get the random number for users
            Element element = new Element(rd);      //We need build an object for Element
            String name = element.GetName();
            String sign = element.GetSign();
            String stmp = null;
            //Some choices for our users
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
            Show.Text = stmp;       //Print the answer
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

        public void Judge0(int innn)
        {
            //TODO : Judge the number the user inputed
            if (innn == rd)
            {
                r++;                        //Right number plus 1 itself
                Tip.Text = "回答正确";
                Tip.ForeColor = Color.Lime;
                Yes.Text = rr + Convert.ToString(r);
            }
            else
            {
                w++;                        //Wrong number plus 1 itself
                Tip.Text = "回答错误，正确答案：" + Convert.ToString(rd);
                Tip.ForeColor = Color.OrangeRed;
                Wro.Text = ww + Convert.ToString(w);
            }
            Refresh0();                     //Refresh the page
        }

        private void Send_Click(object sender, EventArgs e)
        {
            //TODO : Send the content which the user inputed to our program
            String s = Entered.Text;        //We need the type of String
            if (s != "")                    //Judge whether the user has inputed data or not
            {
                if (s[0] < 'A' && (choice == 1 || choice == 3))
                {
                    Judge0(Convert.ToInt32(s)); //The user inputed a type of number
                }
                else
                {
                    Judge1(s);                  //The user inputed a type of String
                }
            }
            else
            {
                DidNotAnswer();                 //The user did not input anything
            }
            isFirst = false;                    //The user lost the FIRST //Hahahahahaha
            Last = ReadTime();                  //Let's get the time when the user inputed data
            if (Last.Equals(empty))
            {
                isFirst = true;                 //But this time stwc hasn't begun working!
            }
        }

        private void DidNotAnswer()
        {
            //TODO : We are discussing why didn't the user input anything...
            if (choice == 2)
            {
                //We wanna the user input something like String
                d++;
                Tip.ForeColor = Color.Orange;
                Tip.Text = "请回答问题!答案：" + Libraries.numToSign[rd];
                DNA.Text = dd + Convert.ToString(d);
            }
            else
            {
                //The user is expected to input numbers but they didn't
                d++;
                Tip.ForeColor = Color.Orange;
                Tip.Text = "请回答问题!答案：" + Convert.ToString(rd);
                DNA.Text = dd + Convert.ToString(d);
            }
            Refresh0();         //Refresh it!
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //TODO : The event of REFRESH and REFRESH
            //By this we can view the time at real time
            ts = sw.Elapsed;
            STWC.Text = String.Format("{0}:{1}:{2}.{3}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);//Format the time
        }

        private void Entered_TextChanged(object sender, EventArgs e)
        {
            //TODO : If the user changed the TextBox, we need to start the stopwatch
            if (isFirst)
            {
                StartTime();
                isFirst = false;
            }
        }

        private void Judge1(String s)
        {
            //TODO : If the user inputed something like String, we used this method
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
            //TODO : Start our stopwatch
            sw = new System.Diagnostics.Stopwatch();
            ts = new TimeSpan();
            timer1.Interval = 1;
            sw.Start();
            timer1.Start();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            //TODO : If the user cilcked this button, we need STOP THE TIME!
            StopTime();
        }

        private void ResetTime()
        {
            //TODO : Now the user wanna leave, or he/she changed the function
            timer1.Stop();
            sw.Stop();
            STWC.Text = tt;
        }

        private void StopTime()
        {
            //TODO : We need ST0P TH3 T1M3
            timer1.Stop();
            if (sw != null)     //If the user hasnot inputed anything, we CANNOT stop the stwc
            {
                sw.Stop();
            }
            //Now we need the last time when our user INPUTED the last data
            //Not when our user CLICKED the button of stop
            STWC.Text = String.Format("{0}:{1}:{2}.{3}",
                Last.Hours, Last.Minutes, Last.Seconds, Last.Milliseconds / 10);
            isFirst = true;     //Like restart
        }

        private TimeSpan ReadTime()
        {
            //Return the real time
            if (sw != null)
            {
                return sw.Elapsed;
            }
            else
            {
                return empty;
            }
        }

        private void RST_Click(object sender, EventArgs e)
        {
            CompletelyRestart();
        }

        private void RBC(int chose)
        {
            //TODO : When the user changed the fuction, we need run this method
            choice = chose;
            isFirst = true;
            StopTime();
            Refresh0();
        }

        private void CompletelyRestart()
        {
            //TODO : Reset all data like init
            choice = 3; rd = 1;
            w = 0; r = 0; d = 0;
            choice = 3;
            radioButton3.Checked = true;
            radioButton2.Checked = false;
            radioButton1.Checked = false;
            isFirst = false;
            STWC.Text = tt;
            Yes.Text = rr;
            Wro.Text = ww;
            Tip.Text = null;
            DNA.Text = dd;
            NewMethod12();
            ResetTime();
        }

    }
}
