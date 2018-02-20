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
    public partial class Tool1 : Form
    {
        public Tool1()
        {
            InitializeComponent();
        }
        String t1 = null;
        String t2 = null;
        String t3 = null;
        String t4 = null;
        int UserIsBeingFucked = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (UserIsBeingFucked == 1 || UserIsBeingFucked == 0)
            {
                t1 = textBox1.Text;
                if (t1 != "")
                {
                    UserIsBeingFucked = 1;
                    EnableTextBox(1);
                    try
                    {
                        if (Convert.ToInt32(textBox1.Text) >= 1 && Convert.ToInt32(textBox1.Text) <= 120)
                        {
                            t2 = Libraries.numToSign[Convert.ToInt32(t1)];
                            t3 = Libraries.numToName[Convert.ToInt32(t1)];
                            t4 = Convert.ToString(Libraries.numToZ[Convert.ToInt32(t1)]);
                        }
                        else
                        {
                            t2 = t3 = t4 = "等待你去发现！";
                        }
                    }
                    catch (FormatException)
                    {
                        t2 = t3 = t4 = "WTF?";
                    }
                    WriteData();
                }
                else
                {
                    EnableTextBox(0);
                    t2 = t3 = t4 = "";
                    WriteData();
                    UserIsBeingFucked = 0;
                }
            }
        }

        private void WriteData()

        {
            textBox1.Text = t1;
            textBox2.Text = t2;
            textBox3.Text = t3;
            textBox4.Text = t4;
        }

        private void EnableTextBox(int n)
        {
            switch(n)
            {
                case 1:
                    textBox1.Enabled = true;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    break;
                case 2:
                    textBox1.Enabled = false;
                    textBox2.Enabled = true;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    break;
                case 3:
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = true;
                    textBox4.Enabled = false;
                    break;
                case 4:
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    break;
                default:
                case 0:
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox3.Enabled = true;
                    break;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (UserIsBeingFucked == 2 || UserIsBeingFucked == 0)
            {
                t2 = textBox2.Text;
                if (t2 != "")
                {
                    UserIsBeingFucked = 2;
                    EnableTextBox(2);
                    try
                    {
                        int i;
                        for (i = 1; i <= 121 && Libraries.numToSign[i] != t2; i++) ;
                        t1 = Convert.ToString(i);
                        t3 = Libraries.numToName[i];
                        t4 = Convert.ToString(Libraries.numToZ[i]);
                    }
                    catch (FormatException)
                    {
                        t1 = t3 = t4 = "你做了什么？";
                    }
                    catch (IndexOutOfRangeException)
                    {
                        t1 = t3 = t4 = "等待你去发现";
                    }
                    WriteData();
                }
                else
                {
                    UserIsBeingFucked = 0;
                    EnableTextBox(0);
                    t1 = t3 = t4 = "";
                    WriteData();
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (UserIsBeingFucked == 3 || UserIsBeingFucked == 0)
            {
                t3 = textBox3.Text;
                if (t3 != "")
                {
                    UserIsBeingFucked = 3;
                    EnableTextBox(3);
                    try
                    {
                        int i;
                        for (i = 1; i <= 121 && Libraries.numToName[i] != t3; i++) ;
                        t1 = Convert.ToString(i);
                        t2 = Libraries.numToSign[i];
                        t4 = Convert.ToString(Libraries.numToZ[i]);
                    }
                    catch (FormatException)
                    {
                        t1 = t2 = t4 = "你做了什么？";
                    }
                    catch (IndexOutOfRangeException)
                    {
                        t1 = t2 = t4 = "等待你去发现";
                    }
                    WriteData();
                }
                else
                {
                    UserIsBeingFucked = 0;
                    EnableTextBox(0);
                    t1 = t2 = t4 = "";
                    WriteData();
                }
            }
        }
    }
}
