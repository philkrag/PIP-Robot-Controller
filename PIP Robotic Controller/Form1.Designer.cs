namespace PIP_Robotic_Controller
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IND_Serial_Connected = new System.Windows.Forms.PictureBox();
            this.BTN_Connect = new System.Windows.Forms.Button();
            this.CMB_Port_Listing = new System.Windows.Forms.ComboBox();
            this.BTN_Refresh_Ports = new System.Windows.Forms.Button();
            this.LBL_Port_Address = new System.Windows.Forms.Label();
            this.TMR_Sample_Engine = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NUD_Repsonse_Timer = new System.Windows.Forms.NumericUpDown();
            this.PB_Banner = new System.Windows.Forms.PictureBox();
            this.STS_Base = new System.Windows.Forms.StatusStrip();
            this.LBL_Copyright = new System.Windows.Forms.ToolStripStatusLabel();
            this.BW_Serial_Engine = new System.ComponentModel.BackgroundWorker();
            this.TMR_Display_Engine = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IND_Serial_Connected)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Repsonse_Timer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Banner)).BeginInit();
            this.STS_Base.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.IND_Serial_Connected);
            this.groupBox2.Controls.Add(this.BTN_Connect);
            this.groupBox2.Controls.Add(this.CMB_Port_Listing);
            this.groupBox2.Controls.Add(this.BTN_Refresh_Ports);
            this.groupBox2.Controls.Add(this.LBL_Port_Address);
            this.groupBox2.Location = new System.Drawing.Point(128, 38);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(508, 325);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Communications Setup";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(298, 262);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 26);
            this.textBox2.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(298, 222);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 26);
            this.textBox1.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 272);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Serial Input";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 232);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Selected Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "System Running";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(470, 142);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 30);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Connection State";
            // 
            // IND_Serial_Connected
            // 
            this.IND_Serial_Connected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IND_Serial_Connected.Location = new System.Drawing.Point(470, 182);
            this.IND_Serial_Connected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IND_Serial_Connected.Name = "IND_Serial_Connected";
            this.IND_Serial_Connected.Size = new System.Drawing.Size(29, 30);
            this.IND_Serial_Connected.TabIndex = 10;
            this.IND_Serial_Connected.TabStop = false;
            // 
            // BTN_Connect
            // 
            this.BTN_Connect.Location = new System.Drawing.Point(297, 103);
            this.BTN_Connect.Name = "BTN_Connect";
            this.BTN_Connect.Size = new System.Drawing.Size(202, 31);
            this.BTN_Connect.TabIndex = 9;
            this.BTN_Connect.Text = "Connect / Disconnect";
            this.BTN_Connect.UseVisualStyleBackColor = true;
            this.BTN_Connect.Click += new System.EventHandler(this.BTN_Connect_Click);
            // 
            // CMB_Port_Listing
            // 
            this.CMB_Port_Listing.FormattingEnabled = true;
            this.CMB_Port_Listing.Location = new System.Drawing.Point(297, 65);
            this.CMB_Port_Listing.Name = "CMB_Port_Listing";
            this.CMB_Port_Listing.Size = new System.Drawing.Size(200, 28);
            this.CMB_Port_Listing.TabIndex = 8;
            this.CMB_Port_Listing.SelectedIndexChanged += new System.EventHandler(this.CMB_Port_Listing_SelectedIndexChanged);
            // 
            // BTN_Refresh_Ports
            // 
            this.BTN_Refresh_Ports.Location = new System.Drawing.Point(297, 28);
            this.BTN_Refresh_Ports.Name = "BTN_Refresh_Ports";
            this.BTN_Refresh_Ports.Size = new System.Drawing.Size(202, 31);
            this.BTN_Refresh_Ports.TabIndex = 7;
            this.BTN_Refresh_Ports.Text = "Refresh";
            this.BTN_Refresh_Ports.UseVisualStyleBackColor = true;
            this.BTN_Refresh_Ports.Click += new System.EventHandler(this.BTN_Refresh_Ports_Click);
            // 
            // LBL_Port_Address
            // 
            this.LBL_Port_Address.AutoSize = true;
            this.LBL_Port_Address.Location = new System.Drawing.Point(8, 77);
            this.LBL_Port_Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Port_Address.Name = "LBL_Port_Address";
            this.LBL_Port_Address.Size = new System.Drawing.Size(103, 20);
            this.LBL_Port_Address.TabIndex = 6;
            this.LBL_Port_Address.Text = "Listen to Port";
            // 
            // TMR_Sample_Engine
            // 
            this.TMR_Sample_Engine.Enabled = true;
            this.TMR_Sample_Engine.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(648, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualControlToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // manualControlToolStripMenuItem
            // 
            this.manualControlToolStripMenuItem.Name = "manualControlToolStripMenuItem";
            this.manualControlToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
            this.manualControlToolStripMenuItem.Text = "Manual Control";
            this.manualControlToolStripMenuItem.Click += new System.EventHandler(this.manualControlToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NUD_Repsonse_Timer);
            this.groupBox1.Location = new System.Drawing.Point(128, 372);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(508, 75);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Response Time (ms)";
            // 
            // NUD_Repsonse_Timer
            // 
            this.NUD_Repsonse_Timer.Location = new System.Drawing.Point(284, 18);
            this.NUD_Repsonse_Timer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NUD_Repsonse_Timer.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUD_Repsonse_Timer.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUD_Repsonse_Timer.Name = "NUD_Repsonse_Timer";
            this.NUD_Repsonse_Timer.Size = new System.Drawing.Size(152, 26);
            this.NUD_Repsonse_Timer.TabIndex = 7;
            this.NUD_Repsonse_Timer.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NUD_Repsonse_Timer.ValueChanged += new System.EventHandler(this.NUD_Repsonse_Timer_ValueChanged);
            // 
            // PB_Banner
            // 
            this.PB_Banner.BackColor = System.Drawing.Color.White;
            this.PB_Banner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Banner.Image = global::PIP_Robotic_Controller.Properties.Resources.Software_Banner;
            this.PB_Banner.Location = new System.Drawing.Point(0, 38);
            this.PB_Banner.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PB_Banner.Name = "PB_Banner";
            this.PB_Banner.Size = new System.Drawing.Size(119, 408);
            this.PB_Banner.TabIndex = 8;
            this.PB_Banner.TabStop = false;
            // 
            // STS_Base
            // 
            this.STS_Base.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.STS_Base.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LBL_Copyright});
            this.STS_Base.Location = new System.Drawing.Point(0, 572);
            this.STS_Base.Name = "STS_Base";
            this.STS_Base.Padding = new System.Windows.Forms.Padding(14, 0, 2, 0);
            this.STS_Base.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.STS_Base.Size = new System.Drawing.Size(648, 30);
            this.STS_Base.TabIndex = 15;
            this.STS_Base.Text = "statusStrip1";
            // 
            // LBL_Copyright
            // 
            this.LBL_Copyright.Name = "LBL_Copyright";
            this.LBL_Copyright.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LBL_Copyright.Size = new System.Drawing.Size(338, 25);
            this.LBL_Copyright.Text = "Copyright © 2018 Phillip Kraguljac GPLv3";
            // 
            // BW_Serial_Engine
            // 
            this.BW_Serial_Engine.WorkerSupportsCancellation = true;
            this.BW_Serial_Engine.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW_Serial_Engine_DoWork);
            this.BW_Serial_Engine.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BW_Serial_Engine_ProgressChanged);
            this.BW_Serial_Engine.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BW_Serial_Engine_RunWorkerCompleted);
            // 
            // TMR_Display_Engine
            // 
            this.TMR_Display_Engine.Enabled = true;
            this.TMR_Display_Engine.Tick += new System.EventHandler(this.TMR_Display_Engine_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 602);
            this.Controls.Add(this.STS_Base);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PB_Banner);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IND_Serial_Connected)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Repsonse_Timer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Banner)).EndInit();
            this.STS_Base.ResumeLayout(false);
            this.STS_Base.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Banner;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LBL_Port_Address;
        private System.Windows.Forms.Timer TMR_Sample_Engine;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualControlToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUD_Repsonse_Timer;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip STS_Base;
        private System.Windows.Forms.ToolStripStatusLabel LBL_Copyright;
        private System.ComponentModel.BackgroundWorker BW_Serial_Engine;
        private System.Windows.Forms.Button BTN_Refresh_Ports;
        private System.Windows.Forms.ComboBox CMB_Port_Listing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox IND_Serial_Connected;
        private System.Windows.Forms.Button BTN_Connect;
        private System.Windows.Forms.Timer TMR_Display_Engine;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

