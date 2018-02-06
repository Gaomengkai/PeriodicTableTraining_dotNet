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
    public partial class GPLV3 : Form
    {
        public GPLV3()
        {
            InitializeComponent();
            textBox1.Select(0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GNU_License formTmp1 = new GNU_License();
            byte[] obj = (byte[])Pt.Properties.Resources.ResourceManager.GetObject("office2007");
            Sunisoft.IrisSkin.SkinEngine skin = new Sunisoft.IrisSkin.SkinEngine((System.ComponentModel.Component)formTmp1)
            {
                SkinStream = new System.IO.MemoryStream(obj),
                TitleFont = new System.Drawing.Font("微软雅黑", 10F)// 指定标题栏的Font。
            };
            formTmp1.Show();
        }
    }
}
