using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pt2
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GNU_Click(object sender, EventArgs e)
        {
            GPLV3 neopen = new GPLV3();
            byte[] obj = (byte[])Pt.Properties.Resources.ResourceManager.GetObject("office2007");
            Sunisoft.IrisSkin.SkinEngine skin = new Sunisoft.IrisSkin.SkinEngine((System.ComponentModel.Component)neopen)
            {
                SkinStream = new MemoryStream(obj),
                TitleFont = new System.Drawing.Font("微软雅黑", 10F)// 指定标题栏的Font。
            };
            neopen.Show(); 
        }

        private void updatelog_Click(object sender, EventArgs e)
        {
            UpdateLog udl = new UpdateLog();
            byte[] obj = (byte[])Pt.Properties.Resources.ResourceManager.GetObject("office2007");
            Sunisoft.IrisSkin.SkinEngine skin = new Sunisoft.IrisSkin.SkinEngine((System.ComponentModel.Component)udl)
            {
                SkinStream = new MemoryStream(obj),
                TitleFont = new System.Drawing.Font("微软雅黑", 10F)// 指定标题栏的Font。
            };
            udl.Show();
        }

        private void About_Load(object sender, EventArgs e)
        {
            textBox1.Text += Libraries._comdate + ' ' + Libraries._version;
        }
    }
}
