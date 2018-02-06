using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pt2
{
    public partial class Form1 : Form
    {
        public void Refresh0()
        {
            //Refresh all the elements and to fill the Labels
            Entered.Text = null;
            Random random = new Random();           //We need random
            if (Min.Text == "") { Min.Text = "1"; }
            if (Max.Text == "") { Max.Text = "36"; }
            int min = Convert.ToInt32(Min.Text);    //Dafault is 1
            int max = Convert.ToInt32(Max.Text);    //Dafault is 36
            if (max < min)
            {
                max ^= min;
                min ^= max;
                max ^= min;
            }
            Element element = null;
            switch (mode)
            {
                case 1:
                    rd = random.Next(min, max + 1);
                    element = new Element(rd);
                    break;
                case 2:
                    rd = random.Next(0, 25);
                    rd = Libraries.importElements[rd];
                    element = new Element(rd);
                    break;
            }
            String name = element.GetName();
            String sign = element.GetSign();
            String stmp = null;
            //Some choices for our users
            switch (choice)
            {
                case 3:
                case 4:
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

        private void DidNotAnswer()
        {
            //We are discussing why didn't the user input anything...
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
        
        private void StartTime()
        {
            //Start our stopwatch
            sw = new System.Diagnostics.Stopwatch();
            ts = new TimeSpan();
            timer1.Interval = 1;
            sw.Start();
            timer1.Start();
        }

        private void ResetTime()
        {
            //Now the user wanna leave, or he/she changed the function
            if (!isFirst)
            {
                timer1.Stop();
                sw.Stop();
                STWC.Text = tt;
            }
        }

        private void StopTime()
        {
            // We need ST0P TH3 T1M3
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

        private void CompletelyRestart()
        {
            //Reset all data like init
            choice = 3; rd = 1;
            w = 0; r = 0; d = 0;
            choice = 3;
            radioButton3.Checked = true;
            radioButton2.Checked = false;
            radioButton1.Checked = false;
            isFirst = false;
            begin.Visible = true;
            end.Visible = true;
            Min.Visible = true;
            Max.Visible = true;
            imEl.Visible = false;
            mode = 1;
            重要元素探索ToolStripMenuItem.Text = "重要元素探索";
            STWC.Text = tt;
            Yes.Text = rr;
            Wro.Text = ww;
            Anyli.Text = aa;
            Tip.Text = null;
            DNA.Text = dd;
            NewMethod12();
            ResetTime();
        }

        private void JUDGE_ALL(bool isYes)
        {
            if (isYes)
            {
                r++;
                Tip.Text = "回答正确";
                Tip.ForeColor = Color.LimeGreen;
                Yes.Text = rr + Convert.ToString(r);
            }
            else
            {
                w++;
                Tip.Text = "回答错误，正确答案：";
                Tip.ForeColor = Color.OrangeRed;
                Wro.Text = ww + Convert.ToString(w);
                switch (choice)
                {
                    case 3:
                    case 1:
                        Tip.Text += Convert.ToString(rd);
                        break;
                    case 2:
                        Tip.Text += Libraries.numToSign[rd];
                        break;
                    case 4:
                        Tip.Text += string.Format("{0:N2}", Libraries.numToZ[rd]);
                        break;
                    default:
                        break;
                }
            }
            Refresh0();
        }

        private void RBC(int chose)
        {
            //When the user changed the fuction, we need run this method
            choice = chose;
            isFirst = true;
            StopTime();
            Refresh0();
        }

        private void ExploreImportElements()
        {
            switch (mode)
            {
                case 1:
                    begin.Visible = false;
                    end.Visible = false;
                    Min.Visible = false;
                    Max.Visible = false;
                    imEl.Visible = true;
                    mode = 2;
                    重要元素探索ToolStripMenuItem.Text = "返回普通模式";
                    Refresh0();
                    break;
                case 2:
                    begin.Visible = true;
                    end.Visible = true;
                    Min.Visible = true;
                    Max.Visible = true;
                    imEl.Visible = false;
                    mode = 1;
                    重要元素探索ToolStripMenuItem.Text = "重要元素探索";
                    Refresh0();
                    break;
            }
        }
    }
}
