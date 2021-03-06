﻿using System;
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
            GPLV3 gPLV3 = new GPLV3();
            gPLV3.Show();
        }

        private void updatelog_Click(object sender, EventArgs e)
        {
            UpdateLog udl = new UpdateLog();
            udl.Show();
        }

        private void About_Load(object sender, EventArgs e)
        {
            textBox1.Text += Libraries._comdate + ' ' + Libraries._version;
        }

        private void btCheckUpdate_Click(object sender, EventArgs e)
        {
            CheckUpdate checkUpdate = new CheckUpdate(Libraries._version);
            if (checkUpdate.StartCheckNewVersion()){
                if (checkUpdate.HasNewVersion())
                {
                    String a = "发现新版本: ";
                    a += checkUpdate.GetLastTag();
                    a += '\n';
                    a += "更新内容： " + checkUpdate.GetBody();
                    a += '\n' + "是否更新？";
                    DialogResult dr = MessageBox.Show(a, "更新", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        Clipboard.SetDataObject(checkUpdate.GetDownUrl(), true);
                        MessageBox.Show("下载地址已经复制到剪贴板！");
                    }
                }
                else
                {
                    MessageBox.Show("您使用的版本是最新的！");
                }
            }
        }
    }
}
