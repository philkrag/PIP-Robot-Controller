namespace PIP_Robotic_Controller
{
    partial class FRM_Manual_Control
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
            this.VSB_XAxis_Control = new System.Windows.Forms.VScrollBar();
            this.HSB_YAxis_Control = new System.Windows.Forms.HScrollBar();
            this.PB_Banner = new System.Windows.Forms.PictureBox();
            this.BTN_Stop = new System.Windows.Forms.Button();
            this.STS_Base = new System.Windows.Forms.StatusStrip();
            this.LBL_Copyright = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Banner)).BeginInit();
            this.STS_Base.SuspendLayout();
            this.SuspendLayout();
            // 
            // VSB_XAxis_Control
            // 
            this.VSB_XAxis_Control.Location = new System.Drawing.Point(357, 14);
            this.VSB_XAxis_Control.Maximum = 512;
            this.VSB_XAxis_Control.Name = "VSB_XAxis_Control";
            this.VSB_XAxis_Control.Size = new System.Drawing.Size(48, 205);
            this.VSB_XAxis_Control.TabIndex = 12;
            this.VSB_XAxis_Control.Value = 256;
            this.VSB_XAxis_Control.ValueChanged += new System.EventHandler(this.VSB_XAxis_Control_ValueChanged);
            // 
            // HSB_YAxis_Control
            // 
            this.HSB_YAxis_Control.Location = new System.Drawing.Point(136, 219);
            this.HSB_YAxis_Control.Maximum = 512;
            this.HSB_YAxis_Control.Name = "HSB_YAxis_Control";
            this.HSB_YAxis_Control.Size = new System.Drawing.Size(221, 48);
            this.HSB_YAxis_Control.TabIndex = 11;
            this.HSB_YAxis_Control.Value = 256;
            this.HSB_YAxis_Control.ValueChanged += new System.EventHandler(this.HSB_YAxis_Control_ValueChanged);
            // 
            // PB_Banner
            // 
            this.PB_Banner.BackColor = System.Drawing.Color.White;
            this.PB_Banner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Banner.Image = global::PIP_Robotic_Controller.Properties.Resources.Software_Banner;
            this.PB_Banner.Location = new System.Drawing.Point(0, 13);
            this.PB_Banner.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PB_Banner.Name = "PB_Banner";
            this.PB_Banner.Size = new System.Drawing.Size(119, 267);
            this.PB_Banner.TabIndex = 9;
            this.PB_Banner.TabStop = false;
            // 
            // BTN_Stop
            // 
            this.BTN_Stop.Location = new System.Drawing.Point(126, 14);
            this.BTN_Stop.Name = "BTN_Stop";
            this.BTN_Stop.Size = new System.Drawing.Size(228, 202);
            this.BTN_Stop.TabIndex = 13;
            this.BTN_Stop.Text = "Stop";
            this.BTN_Stop.UseVisualStyleBackColor = true;
            this.BTN_Stop.Click += new System.EventHandler(this.BTN_Stop_Click);
            // 
            // STS_Base
            // 
            this.STS_Base.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.STS_Base.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LBL_Copyright});
            this.STS_Base.Location = new System.Drawing.Point(0, 283);
            this.STS_Base.Name = "STS_Base";
            this.STS_Base.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.STS_Base.Size = new System.Drawing.Size(421, 30);
            this.STS_Base.TabIndex = 14;
            this.STS_Base.Text = "statusStrip1";
            // 
            // LBL_Copyright
            // 
            this.LBL_Copyright.Name = "LBL_Copyright";
            this.LBL_Copyright.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LBL_Copyright.Size = new System.Drawing.Size(338, 25);
            this.LBL_Copyright.Text = "Copyright © 2018 Phillip Kraguljac GPLv3";
            // 
            // FRM_Manual_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 313);
            this.Controls.Add(this.STS_Base);
            this.Controls.Add(this.BTN_Stop);
            this.Controls.Add(this.VSB_XAxis_Control);
            this.Controls.Add(this.HSB_YAxis_Control);
            this.Controls.Add(this.PB_Banner);
            this.Name = "FRM_Manual_Control";
            this.Text = "FRM_Manual_Control";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Banner)).EndInit();
            this.STS_Base.ResumeLayout(false);
            this.STS_Base.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Banner;
        private System.Windows.Forms.VScrollBar VSB_XAxis_Control;
        private System.Windows.Forms.HScrollBar HSB_YAxis_Control;
        private System.Windows.Forms.Button BTN_Stop;
        private System.Windows.Forms.StatusStrip STS_Base;
        private System.Windows.Forms.ToolStripStatusLabel LBL_Copyright;
    }
}