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
    public partial class ChooseTheme1 : Form
    {
        public ChooseTheme1()
        {
            InitializeComponent();
        }

        private void ChooseTheme1_Load(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo("Skins");
            if(directory.Exists)
                this.listBox1.DataSource = directory.GetFiles();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem != null)
                Program.form1.skinEngine1.SkinFile = (this.listBox1.SelectedItem as System.IO.FileInfo).FullName;
        }
        
    }
}
