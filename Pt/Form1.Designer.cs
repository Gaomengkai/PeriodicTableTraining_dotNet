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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.toToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重要元素探索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Anyli = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.begin = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Label();
            this.rB4 = new System.Windows.Forms.RadioButton();
            this.imEl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Show
            // 
            resources.ApplyResources(this.Show, "Show");
            this.Show.BackColor = System.Drawing.Color.Transparent;
            this.Show.Name = "Show";
            // 
            // STWC
            // 
            resources.ApplyResources(this.STWC, "STWC");
            this.STWC.Name = "STWC";
            // 
            // Entered
            // 
            resources.ApplyResources(this.Entered, "Entered");
            this.Entered.Name = "Entered";
            this.Entered.TextChanged += new System.EventHandler(this.Entered_TextChanged);
            // 
            // Send
            // 
            resources.ApplyResources(this.Send, "Send");
            this.Send.Name = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            resources.ApplyResources(this.radioButton3, "radioButton3");
            this.radioButton3.Checked = true;
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Stop
            // 
            resources.ApplyResources(this.Stop, "Stop");
            this.Stop.Name = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Min
            // 
            resources.ApplyResources(this.Min, "Min");
            this.Min.Name = "Min";
            this.Min.TextChanged += new System.EventHandler(this.Min_TextChanged);
            // 
            // Max
            // 
            resources.ApplyResources(this.Max, "Max");
            this.Max.Name = "Max";
            this.Max.TextChanged += new System.EventHandler(this.Max_TextChanged);
            // 
            // Yes
            // 
            resources.ApplyResources(this.Yes, "Yes");
            this.Yes.Name = "Yes";
            // 
            // Wro
            // 
            resources.ApplyResources(this.Wro, "Wro");
            this.Wro.Name = "Wro";
            // 
            // Tip
            // 
            resources.ApplyResources(this.Tip, "Tip");
            this.Tip.ForeColor = System.Drawing.Color.Black;
            this.Tip.Name = "Tip";
            // 
            // DNA
            // 
            resources.ApplyResources(this.DNA, "DNA");
            this.DNA.Name = "DNA";
            // 
            // RST
            // 
            resources.ApplyResources(this.RST, "RST");
            this.RST.Name = "RST";
            this.RST.UseVisualStyleBackColor = true;
            this.RST.Click += new System.EventHandler(this.RST_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseThemeToolStripMenuItem,
            this.toToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // toToolStripMenuItem
            // 
            resources.ApplyResources(this.toToolStripMenuItem, "toToolStripMenuItem");
            this.toToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询工具ToolStripMenuItem,
            this.重要元素探索ToolStripMenuItem});
            this.toToolStripMenuItem.Name = "toToolStripMenuItem";
            // 
            // 查询工具ToolStripMenuItem
            // 
            resources.ApplyResources(this.查询工具ToolStripMenuItem, "查询工具ToolStripMenuItem");
            this.查询工具ToolStripMenuItem.Name = "查询工具ToolStripMenuItem";
            // 
            // 重要元素探索ToolStripMenuItem
            // 
            resources.ApplyResources(this.重要元素探索ToolStripMenuItem, "重要元素探索ToolStripMenuItem");
            this.重要元素探索ToolStripMenuItem.Name = "重要元素探索ToolStripMenuItem";
            this.重要元素探索ToolStripMenuItem.Click += new System.EventHandler(this.重要元素探索ToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // chooseThemeToolStripMenuItem
            // 
            resources.ApplyResources(this.chooseThemeToolStripMenuItem, "chooseThemeToolStripMenuItem");
            this.chooseThemeToolStripMenuItem.Name = "chooseThemeToolStripMenuItem";
            this.chooseThemeToolStripMenuItem.Click += new System.EventHandler(this.chooseThemeToolStripMenuItem_Click);
            // 
            // Anyli
            // 
            resources.ApplyResources(this.Anyli, "Anyli");
            this.Anyli.Name = "Anyli";
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
            resources.ApplyResources(this.begin, "begin");
            this.begin.Name = "begin";
            // 
            // end
            // 
            resources.ApplyResources(this.end, "end");
            this.end.BackColor = System.Drawing.Color.Transparent;
            this.end.Name = "end";
            // 
            // rB4
            // 
            resources.ApplyResources(this.rB4, "rB4");
            this.rB4.Name = "rB4";
            this.rB4.UseVisualStyleBackColor = true;
            this.rB4.CheckedChanged += new System.EventHandler(this.rB4_CheckedChanged);
            // 
            // imEl
            // 
            resources.ApplyResources(this.imEl, "imEl");
            this.imEl.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.imEl.Name = "imEl";
            // 
            // Form1
            // 
            this.AcceptButton = this.Send;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
            this.Name = "Form1";
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
        private System.Windows.Forms.Label Anyli;
        public Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Label begin;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.RadioButton rB4;
        private System.Windows.Forms.ToolStripMenuItem toToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重要元素探索ToolStripMenuItem;
        private System.Windows.Forms.Label imEl;
        private System.Windows.Forms.ToolStripMenuItem chooseThemeToolStripMenuItem;
    }
}

