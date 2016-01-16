﻿namespace Timer.View
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.uxNumUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.uxLblHours = new System.Windows.Forms.Label();
            this.uxLblMinutes = new System.Windows.Forms.Label();
            this.uxNumUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.uxLblSeconds = new System.Windows.Forms.Label();
            this.uxNumUpDownSeconds = new System.Windows.Forms.NumericUpDown();
            this.uxBtnSetTimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumUpDownHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumUpDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumUpDownSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // uxNumUpDownHours
            // 
            this.uxNumUpDownHours.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNumUpDownHours.Location = new System.Drawing.Point(79, 19);
            this.uxNumUpDownHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.uxNumUpDownHours.Name = "uxNumUpDownHours";
            this.uxNumUpDownHours.Size = new System.Drawing.Size(71, 27);
            this.uxNumUpDownHours.TabIndex = 0;
            // 
            // uxLblHours
            // 
            this.uxLblHours.AutoSize = true;
            this.uxLblHours.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLblHours.Location = new System.Drawing.Point(12, 21);
            this.uxLblHours.Name = "uxLblHours";
            this.uxLblHours.Size = new System.Drawing.Size(61, 19);
            this.uxLblHours.TabIndex = 1;
            this.uxLblHours.Text = "Horas: ";
            // 
            // uxLblMinutes
            // 
            this.uxLblMinutes.AutoSize = true;
            this.uxLblMinutes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLblMinutes.Location = new System.Drawing.Point(156, 23);
            this.uxLblMinutes.Name = "uxLblMinutes";
            this.uxLblMinutes.Size = new System.Drawing.Size(75, 19);
            this.uxLblMinutes.TabIndex = 3;
            this.uxLblMinutes.Text = "Minutos: ";
            // 
            // uxNumUpDownMinutes
            // 
            this.uxNumUpDownMinutes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNumUpDownMinutes.Location = new System.Drawing.Point(237, 19);
            this.uxNumUpDownMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.uxNumUpDownMinutes.Name = "uxNumUpDownMinutes";
            this.uxNumUpDownMinutes.Size = new System.Drawing.Size(71, 27);
            this.uxNumUpDownMinutes.TabIndex = 2;
            // 
            // uxLblSeconds
            // 
            this.uxLblSeconds.AutoSize = true;
            this.uxLblSeconds.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLblSeconds.Location = new System.Drawing.Point(314, 23);
            this.uxLblSeconds.Name = "uxLblSeconds";
            this.uxLblSeconds.Size = new System.Drawing.Size(89, 19);
            this.uxLblSeconds.TabIndex = 5;
            this.uxLblSeconds.Text = "Segundos: ";
            // 
            // uxNumUpDownSeconds
            // 
            this.uxNumUpDownSeconds.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNumUpDownSeconds.Location = new System.Drawing.Point(409, 19);
            this.uxNumUpDownSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.uxNumUpDownSeconds.Name = "uxNumUpDownSeconds";
            this.uxNumUpDownSeconds.Size = new System.Drawing.Size(71, 27);
            this.uxNumUpDownSeconds.TabIndex = 4;
            // 
            // uxBtnSetTimer
            // 
            this.uxBtnSetTimer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBtnSetTimer.Location = new System.Drawing.Point(502, 15);
            this.uxBtnSetTimer.Name = "uxBtnSetTimer";
            this.uxBtnSetTimer.Size = new System.Drawing.Size(115, 31);
            this.uxBtnSetTimer.TabIndex = 6;
            this.uxBtnSetTimer.Text = "Set timer!";
            this.uxBtnSetTimer.UseVisualStyleBackColor = true;
            this.uxBtnSetTimer.Click += new System.EventHandler(this.uxBtnSetTimer_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(629, 62);
            this.Controls.Add(this.uxBtnSetTimer);
            this.Controls.Add(this.uxLblSeconds);
            this.Controls.Add(this.uxNumUpDownSeconds);
            this.Controls.Add(this.uxLblMinutes);
            this.Controls.Add(this.uxNumUpDownMinutes);
            this.Controls.Add(this.uxLblHours);
            this.Controls.Add(this.uxNumUpDownHours);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Timer";
            ((System.ComponentModel.ISupportInitialize)(this.uxNumUpDownHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumUpDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumUpDownSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown uxNumUpDownHours;
        private System.Windows.Forms.Label uxLblHours;
        private System.Windows.Forms.Label uxLblMinutes;
        private System.Windows.Forms.NumericUpDown uxNumUpDownMinutes;
        private System.Windows.Forms.Label uxLblSeconds;
        private System.Windows.Forms.NumericUpDown uxNumUpDownSeconds;
        private System.Windows.Forms.Button uxBtnSetTimer;
    }
}
