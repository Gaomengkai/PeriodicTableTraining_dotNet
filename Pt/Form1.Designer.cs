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
            this.RST = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Anyli = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.begin = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Label();
            this.rB4 = new System.Windows.Forms.RadioButton();
            this.toToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重要元素探索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imEl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Show
            // 
            this.Show.AutoSize = true;
            this.Show.BackColor = System.Drawing.Color.Transparent;
            this.Show.Font = new System.Drawing.Font("宋体", 70F);
            this.Show.Location = new System.Drawing.Point(8, 27);
            this.Show.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(134, 94);
            this.Show.TabIndex = 0;
            this.Show.Text = "Pt";
            // 
            // STWC
            // 
            this.STWC.AutoSize = true;
            this.STWC.Font = new System.Drawing.Font("宋体", 20F);
            this.STWC.Location = new System.Drawing.Point(350, 30);
            this.STWC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.STWC.Name = "STWC";
            this.STWC.Size = new System.Drawing.Size(110, 27);
            this.STWC.TabIndex = 1;
            this.STWC.Text = "0:0:0.0";
            // 
            // Entered
            // 
            this.Entered.Font = new System.Drawing.Font("宋体", 75F);
            this.Entered.Location = new System.Drawing.Point(24, 164);
            this.Entered.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Entered.Name = "Entered";
            this.Entered.Size = new System.Drawing.Size(153, 122);
            this.Entered.TabIndex = 2;
            this.Entered.TextChanged += new System.EventHandler(this.Entered_TextChanged);
            // 
            // Send
            // 
            this.Send.Font = new System.Drawing.Font("幼圆", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Send.Location = new System.Drawing.Point(188, 164);
            this.Send.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(115, 119);
            this.Send.TabIndex = 3;
            this.Send.Text = "交";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(301, 89);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(107, 16);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.Text = "根据名称写序号";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(301, 108);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(107, 16);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "根据序号写符号";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(301, 70);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(107, 16);
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
            this.Stop.Font = new System.Drawing.Font("黑体", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Stop.Location = new System.Drawing.Point(307, 164);
            this.Stop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(115, 119);
            this.Stop.TabIndex = 7;
            this.Stop.Text = "停";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(204, 37);
            this.Min.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(38, 21);
            this.Min.TabIndex = 8;
            this.Min.Text = "1";
            this.Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Min.TextChanged += new System.EventHandler(this.Min_TextChanged);
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(204, 61);
            this.Max.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(38, 21);
            this.Max.TabIndex = 9;
            this.Max.Text = "36";
            this.Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Max.TextChanged += new System.EventHandler(this.Max_TextChanged);
            // 
            // Yes
            // 
            this.Yes.AutoSize = true;
            this.Yes.Location = new System.Drawing.Point(412, 70);
            this.Yes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(41, 12);
            this.Yes.TabIndex = 10;
            this.Yes.Text = "正确：";
            // 
            // Wro
            // 
            this.Wro.AutoSize = true;
            this.Wro.Location = new System.Drawing.Point(412, 89);
            this.Wro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Wro.Name = "Wro";
            this.Wro.Size = new System.Drawing.Size(41, 12);
            this.Wro.TabIndex = 11;
            this.Wro.Text = "错误：";
            // 
            // Tip
            // 
            this.Tip.AutoSize = true;
            this.Tip.Font = new System.Drawing.Font("宋体", 15F);
            this.Tip.ForeColor = System.Drawing.Color.Black;
            this.Tip.Location = new System.Drawing.Point(21, 121);
            this.Tip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Tip.Name = "Tip";
            this.Tip.Size = new System.Drawing.Size(0, 20);
            this.Tip.TabIndex = 12;
            // 
            // DNA
            // 
            this.DNA.AutoSize = true;
            this.DNA.Location = new System.Drawing.Point(411, 108);
            this.DNA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DNA.Name = "DNA";
            this.DNA.Size = new System.Drawing.Size(53, 12);
            this.DNA.TabIndex = 13;
            this.DNA.Text = "未回答：";
            // 
            // RST
            // 
            this.RST.Font = new System.Drawing.Font("宋体", 12F);
            this.RST.Location = new System.Drawing.Point(427, 164);
            this.RST.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RST.Name = "RST";
            this.RST.Size = new System.Drawing.Size(65, 32);
            this.RST.TabIndex = 14;
            this.RST.Text = "重启";
            this.RST.UseVisualStyleBackColor = true;
            this.RST.Click += new System.EventHandler(this.RST_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(511, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // Anyli
            // 
            this.Anyli.AutoSize = true;
            this.Anyli.Location = new System.Drawing.Point(412, 127);
            this.Anyli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Anyli.Name = "Anyli";
            this.Anyli.Size = new System.Drawing.Size(53, 12);
            this.Anyli.TabIndex = 16;
            this.Anyli.Text = "正确率：";
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // begin
            // 
            this.begin.AutoSize = true;
            this.begin.Location = new System.Drawing.Point(138, 41);
            this.begin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(65, 12);
            this.begin.TabIndex = 17;
            this.begin.Text = "开始的元素";
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.BackColor = System.Drawing.Color.Transparent;
            this.end.Location = new System.Drawing.Point(140, 65);
            this.end.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(65, 12);
            this.end.TabIndex = 18;
            this.end.Text = "结束的元素";
            // 
            // rB4
            // 
            this.rB4.AutoSize = true;
            this.rB4.Location = new System.Drawing.Point(301, 127);
            this.rB4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rB4.Name = "rB4";
            this.rB4.Size = new System.Drawing.Size(107, 16);
            this.rB4.TabIndex = 19;
            this.rB4.Text = "写相对原子质量";
            this.rB4.UseVisualStyleBackColor = true;
            this.rB4.CheckedChanged += new System.EventHandler(this.rB4_CheckedChanged);
            // 
            // toToolStripMenuItem
            // 
            this.toToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询工具ToolStripMenuItem,
            this.重要元素探索ToolStripMenuItem});
            this.toToolStripMenuItem.Name = "toToolStripMenuItem";
            this.toToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.toToolStripMenuItem.Text = "Tools";
            // 
            // 查询工具ToolStripMenuItem
            // 
            this.查询工具ToolStripMenuItem.Name = "查询工具ToolStripMenuItem";
            this.查询工具ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查询工具ToolStripMenuItem.Text = "查询工具";
            // 
            // 重要元素探索ToolStripMenuItem
            // 
            this.重要元素探索ToolStripMenuItem.Name = "重要元素探索ToolStripMenuItem";
            this.重要元素探索ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.重要元素探索ToolStripMenuItem.Text = "重要元素探索";
            this.重要元素探索ToolStripMenuItem.Click += new System.EventHandler(this.重要元素探索ToolStripMenuItem_Click);
            // 
            // imEl
            // 
            this.imEl.AutoSize = true;
            this.imEl.Font = new System.Drawing.Font("宋体", 12F);
            this.imEl.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.imEl.Location = new System.Drawing.Point(142, 89);
            this.imEl.Name = "imEl";
            this.imEl.Size = new System.Drawing.Size(104, 16);
            this.imEl.TabIndex = 20;
            this.imEl.Text = "重点元素模式";
            this.imEl.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.Send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(511, 307);
            this.Controls.Add(this.imEl);
            this.Controls.Add(this.rB4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.end);
            this.Controls.Add(this.begin);
            this.Controls.Add(this.Anyli);
            this.Controls.Add(this.RST);
            this.Controls.Add(this.DNA);
            this.Controls.Add(this.Tip);
            this.Controls.Add(this.Wro);
            this.Controls.Add(this.Yes);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Entered);
            this.Controls.Add(this.STWC);
            this.Controls.Add(this.Show);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "元素周期表问答";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button RST;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Label Anyli;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Label begin;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.RadioButton rB4;
        private System.Windows.Forms.ToolStripMenuItem toToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重要元素探索ToolStripMenuItem;
        private System.Windows.Forms.Label imEl;
    }
}

