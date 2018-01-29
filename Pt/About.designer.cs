namespace Pt2
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.GNU = new System.Windows.Forms.Button();
            this.updatelog = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("SimSun", 15F);
            this.button1.Location = new System.Drawing.Point(201, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GNU
            // 
            this.GNU.Font = new System.Drawing.Font("SimSun", 10F);
            this.GNU.Location = new System.Drawing.Point(18, 265);
            this.GNU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GNU.Name = "GNU";
            this.GNU.Size = new System.Drawing.Size(162, 40);
            this.GNU.TabIndex = 2;
            this.GNU.Text = "GNU License";
            this.GNU.UseVisualStyleBackColor = true;
            this.GNU.Click += new System.EventHandler(this.GNU_Click);
            // 
            // updatelog
            // 
            this.updatelog.Font = new System.Drawing.Font("SimSun", 11F);
            this.updatelog.Location = new System.Drawing.Point(18, 321);
            this.updatelog.Name = "updatelog";
            this.updatelog.Size = new System.Drawing.Size(471, 43);
            this.updatelog.TabIndex = 3;
            this.updatelog.Text = "Update Log";
            this.updatelog.UseVisualStyleBackColor = true;
            this.updatelog.Click += new System.EventHandler(this.updatelog_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("SimSun", 11.5F);
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(476, 245);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "这个辣鸡程序是我根据前人的经验站在巨人的肩膀上写出来的，希望能帮到大家。\r\n感谢以下人员提供精神和技术支持：\r\n吉林一中 段奕辰\r\n\r\n谢谢！\r\n\r\nUI By:" +
    "JackDuan - 2018.1.26 Alpha16\r\n高盟凯 ";
            // 
            // About
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(510, 376);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.updatelog);
            this.Controls.Add(this.GNU);
            this.Controls.Add(this.button1);
            this.Name = "About";
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GNU;
        private System.Windows.Forms.Button updatelog;
        private System.Windows.Forms.TextBox textBox1;
    }
}