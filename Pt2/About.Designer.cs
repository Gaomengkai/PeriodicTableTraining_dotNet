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
            this.cont = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cont
            // 
            this.cont.AutoSize = true;
            this.cont.Font = new System.Drawing.Font("SimSun", 11F);
            this.cont.Location = new System.Drawing.Point(29, 23);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(450, 198);
            this.cont.TabIndex = 0;
            this.cont.Text = "这个辣鸡程序是我根据前人的经验站在巨人的\r\n肩膀上写出来的，希望能帮到大家。\r\n感谢以下人员提供精神和技术支持：\r\n吉林一中 段亦辰\r\n\r\n谢谢！\r\n\r\n\r\n高盟" +
    "凯 2018年1月25日        Alpha(15)";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("SimSun", 15F);
            this.button1.Location = new System.Drawing.Point(112, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // About
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(510, 328);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cont);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cont;
        private System.Windows.Forms.Button button1;
    }
}