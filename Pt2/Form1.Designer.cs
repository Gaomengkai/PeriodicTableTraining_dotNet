namespace Pt2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Show = new System.Windows.Forms.Label();
            this.STWC = new System.Windows.Forms.Label();
            this.Entered = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Stop = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.TextBox();
            this.Max = new System.Windows.Forms.TextBox();
            this.Yes = new System.Windows.Forms.Label();
            this.Wro = new System.Windows.Forms.Label();
            this.Tip = new System.Windows.Forms.Label();
            this.DNA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Show
            // 
            this.Show.AutoSize = true;
            this.Show.Font = new System.Drawing.Font("SimSun", 70F);
            this.Show.Location = new System.Drawing.Point(12, 15);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(200, 140);
            this.Show.TabIndex = 0;
            this.Show.Text = "Pt";
            // 
            // STWC
            // 
            this.STWC.AutoSize = true;
            this.STWC.Font = new System.Drawing.Font("SimSun", 20F);
            this.STWC.Location = new System.Drawing.Point(501, 45);
            this.STWC.Name = "STWC";
            this.STWC.Size = new System.Drawing.Size(157, 40);
            this.STWC.TabIndex = 1;
            this.STWC.Text = "0:0:0.0";
            // 
            // Entered
            // 
            this.Entered.Font = new System.Drawing.Font("SimSun", 75F);
            this.Entered.Location = new System.Drawing.Point(36, 231);
            this.Entered.Name = "Entered";
            this.Entered.Size = new System.Drawing.Size(228, 179);
            this.Entered.TabIndex = 2;
            this.Entered.TextChanged += new System.EventHandler(this.Entered_TextChanged);
            // 
            // Send
            // 
            this.Send.Font = new System.Drawing.Font("YouYuan", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Send.Location = new System.Drawing.Point(282, 231);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(173, 179);
            this.Send.TabIndex = 3;
            this.Send.Text = "交";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(449, 133);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(159, 22);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "根据名称写序号";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(449, 162);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(159, 22);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "根据序号写符号";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(449, 105);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(159, 22);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "根据符号写序号";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Stop
            // 
            this.Stop.Font = new System.Drawing.Font("SimHei", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Stop.Location = new System.Drawing.Point(461, 231);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(173, 179);
            this.Stop.TabIndex = 7;
            this.Stop.Text = "停";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(306, 56);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(100, 28);
            this.Min.TabIndex = 8;
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(306, 91);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(100, 28);
            this.Max.TabIndex = 9;
            // 
            // Yes
            // 
            this.Yes.AutoSize = true;
            this.Yes.Location = new System.Drawing.Point(615, 105);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(62, 18);
            this.Yes.TabIndex = 10;
            this.Yes.Text = "正确：";
            // 
            // Wro
            // 
            this.Wro.AutoSize = true;
            this.Wro.Location = new System.Drawing.Point(615, 133);
            this.Wro.Name = "Wro";
            this.Wro.Size = new System.Drawing.Size(62, 18);
            this.Wro.TabIndex = 11;
            this.Wro.Text = "错误：";
            // 
            // Tip
            // 
            this.Tip.AutoSize = true;
            this.Tip.Font = new System.Drawing.Font("SimSun", 15F);
            this.Tip.ForeColor = System.Drawing.Color.Black;
            this.Tip.Location = new System.Drawing.Point(31, 162);
            this.Tip.Name = "Tip";
            this.Tip.Size = new System.Drawing.Size(0, 30);
            this.Tip.TabIndex = 12;
            // 
            // DNA
            // 
            this.DNA.AutoSize = true;
            this.DNA.Location = new System.Drawing.Point(614, 164);
            this.DNA.Name = "DNA";
            this.DNA.Size = new System.Drawing.Size(80, 18);
            this.DNA.TabIndex = 13;
            this.DNA.Text = "未回答：";
            // 
            // Form1
            // 
            this.AcceptButton = this.Send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 449);
            this.Controls.Add(this.DNA);
            this.Controls.Add(this.Tip);
            this.Controls.Add(this.Wro);
            this.Controls.Add(this.Yes);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Entered);
            this.Controls.Add(this.STWC);
            this.Controls.Add(this.Show);
            this.Name = "Form1";
            this.Text = "元素周期表问答 Alpha9";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private new System.Windows.Forms.Label Show;
        private System.Windows.Forms.Label STWC;
        private System.Windows.Forms.TextBox Entered;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.TextBox Min;
        private System.Windows.Forms.TextBox Max;
        private System.Windows.Forms.Label Yes;
        private System.Windows.Forms.Label Wro;
        private System.Windows.Forms.Label Tip;
        private System.Windows.Forms.Label DNA;
    }
}

