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
            formTmp1.Show();
        }
    }
}
