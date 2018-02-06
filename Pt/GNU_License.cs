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
    public partial class GNU_License : Form
    {
        public GNU_License()
        {
            InitializeComponent();
        }

        private void GNU_License_Load(object sender, EventArgs e)
        {
            textBox1.Text = Pt.Properties.Resources.GPLv3;
            textBox1.Select(0, 0);
        }
    }
}
