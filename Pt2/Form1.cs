using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pt2
{
    public partial class Form1 : Form
    {
        int choice=3;
        int rd;
        int w = 0, r = 0;
        String rr = "回答正确：";
        String ww = "回答错误：";


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
            Refresh0();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                choice = 1;
            }
            Refresh0();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                choice = 2;
            }
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
            if (s[0] < 'A')
            {
                Judge0(Convert.ToInt32(s));
            }
            else
            {
                Judge1(s);
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
    }        
}


