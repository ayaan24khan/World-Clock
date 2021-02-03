
using System;

namespace World_Clock
{
    partial class World_Clock_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(World_Clock_Form));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Clocktab = new System.Windows.Forms.TabPage();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lbldisplay = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblEntrCity = new System.Windows.Forms.Label();
            this.bttnAddCity = new System.Windows.Forms.Button();
            this.Stopwatchtab = new System.Windows.Forms.TabPage();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.bttnReset = new System.Windows.Forms.Button();
            this.bttnLap = new System.Windows.Forms.Button();
            this.bttnStart = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.Timertab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerStopwatch = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.Clocktab.SuspendLayout();
            this.Stopwatchtab.SuspendLayout();
            this.Timertab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Clocktab);
            this.tabControl1.Controls.Add(this.Stopwatchtab);
            this.tabControl1.Controls.Add(this.Timertab);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(965, 615);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // Clocktab
            // 
            this.Clocktab.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.Clocktab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Clocktab.BackgroundImage")));
            this.Clocktab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Clocktab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Clocktab.Controls.Add(this.lblLocal);
            this.Clocktab.Controls.Add(this.lbldisplay);
            this.Clocktab.Controls.Add(this.textBox1);
            this.Clocktab.Controls.Add(this.lblEntrCity);
            this.Clocktab.Controls.Add(this.bttnAddCity);
            this.Clocktab.Location = new System.Drawing.Point(4, 22);
            this.Clocktab.Name = "Clocktab";
            this.Clocktab.Padding = new System.Windows.Forms.Padding(3);
            this.Clocktab.Size = new System.Drawing.Size(957, 589);
            this.Clocktab.TabIndex = 0;
            this.Clocktab.Text = "Clock";
            this.Clocktab.UseVisualStyleBackColor = true;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(293, 157);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(108, 25);
            this.lblLocal.TabIndex = 4;
            this.lblLocal.Text = "Local Time";
            // 
            // lbldisplay
            // 
            this.lbldisplay.AutoSize = true;
            this.lbldisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisplay.Location = new System.Drawing.Point(293, 277);
            this.lbldisplay.Name = "lbldisplay";
            this.lbldisplay.Size = new System.Drawing.Size(95, 25);
            this.lbldisplay.TabIndex = 3;
            this.lbldisplay.Text = "City Time";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(134, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(460, 24);
            this.textBox1.TabIndex = 2;
            this.textBox1.Enter += new System.EventHandler(this.bttnAddCity_Click);
            // 
            // lblEntrCity
            // 
            this.lblEntrCity.AutoSize = true;
            this.lblEntrCity.Location = new System.Drawing.Point(7, 17);
            this.lblEntrCity.Name = "lblEntrCity";
            this.lblEntrCity.Size = new System.Drawing.Size(89, 13);
            this.lblEntrCity.TabIndex = 1;
            this.lblEntrCity.Text = "Enter City Name :";
            // 
            // bttnAddCity
            // 
            this.bttnAddCity.Location = new System.Drawing.Point(825, 6);
            this.bttnAddCity.Name = "bttnAddCity";
            this.bttnAddCity.Size = new System.Drawing.Size(104, 28);
            this.bttnAddCity.TabIndex = 0;
            this.bttnAddCity.Text = "Get Time";
            this.bttnAddCity.UseVisualStyleBackColor = true;
            this.bttnAddCity.Click += new System.EventHandler(this.bttnAddCity_Click);
            // 
            // Stopwatchtab
            // 
            this.Stopwatchtab.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.Stopwatchtab.Controls.Add(this.ListBox1);
            this.Stopwatchtab.Controls.Add(this.bttnReset);
            this.Stopwatchtab.Controls.Add(this.bttnLap);
            this.Stopwatchtab.Controls.Add(this.bttnStart);
            this.Stopwatchtab.Controls.Add(this.lblTime);
            this.Stopwatchtab.Location = new System.Drawing.Point(4, 22);
            this.Stopwatchtab.Name = "Stopwatchtab";
            this.Stopwatchtab.Padding = new System.Windows.Forms.Padding(3);
            this.Stopwatchtab.Size = new System.Drawing.Size(957, 589);
            this.Stopwatchtab.TabIndex = 1;
            this.Stopwatchtab.Text = "Stopwatch";
            this.Stopwatchtab.UseVisualStyleBackColor = true;
            // 
            // ListBox1
            // 
            this.ListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 24;
            this.ListBox1.Location = new System.Drawing.Point(311, 350);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(382, 172);
            this.ListBox1.TabIndex = 2;
            // 
            // bttnReset
            // 
            this.bttnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnReset.Location = new System.Drawing.Point(439, 253);
            this.bttnReset.Name = "bttnReset";
            this.bttnReset.Size = new System.Drawing.Size(117, 46);
            this.bttnReset.TabIndex = 1;
            this.bttnReset.Text = "Reset";
            this.bttnReset.UseVisualStyleBackColor = true;
            this.bttnReset.Click += new System.EventHandler(this.bttnReset_Click);
           
            // 
            // bttnLap
            // 
            this.bttnLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLap.Location = new System.Drawing.Point(576, 253);
            this.bttnLap.Name = "bttnLap";
            this.bttnLap.Size = new System.Drawing.Size(117, 46);
            this.bttnLap.TabIndex = 1;
            this.bttnLap.Text = "Lap";
            this.bttnLap.UseVisualStyleBackColor = true;
            this.bttnLap.Click += new System.EventHandler(this.bttnLap_Click);
            // 
            // bttnStart
            // 
            this.bttnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnStart.Location = new System.Drawing.Point(302, 253);
            this.bttnStart.Name = "bttnStart";
            this.bttnStart.Size = new System.Drawing.Size(117, 46);
            this.bttnStart.TabIndex = 1;
            this.bttnStart.Text = "Start";
            this.bttnStart.UseVisualStyleBackColor = true;
            this.bttnStart.Click += new System.EventHandler(this.bttnStart_Click);
            
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(287, 111);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(241, 85);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "label2";
            // 
            // Timertab
            // 
            this.Timertab.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.Timertab.AutoScroll = true;
            this.Timertab.Controls.Add(this.label1);
            this.Timertab.Controls.Add(this.btnStop);
            this.Timertab.Controls.Add(this.btnStart);
            this.Timertab.Controls.Add(this.lblMinutes);
            this.Timertab.Controls.Add(this.comboBox2);
            this.Timertab.Controls.Add(this.label3);
            this.Timertab.Controls.Add(this.comboBox3);
            this.Timertab.Controls.Add(this.lblSeconds);
            this.Timertab.Controls.Add(this.comboBox1);
            this.Timertab.Location = new System.Drawing.Point(4, 22);
            this.Timertab.Margin = new System.Windows.Forms.Padding(0);
            this.Timertab.Name = "Timertab";
            this.Timertab.Size = new System.Drawing.Size(957, 589);
            this.Timertab.TabIndex = 2;
            this.Timertab.Text = "Timer";
            this.Timertab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 108);
            this.label1.TabIndex = 3;
            this.label1.Text = "00:00:00";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(510, 372);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(143, 49);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(294, 372);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 49);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.Location = new System.Drawing.Point(403, 99);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(97, 29);
            this.lblMinutes.TabIndex = 1;
            this.lblMinutes.Text = "Minutes";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(259, 144);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hours";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(550, 144);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 28);
            this.comboBox3.TabIndex = 0;
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.Location = new System.Drawing.Point(545, 99);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(108, 29);
            this.lblSeconds.TabIndex = 1;
            this.lblSeconds.Text = "Seconds";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(408, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerStopwatch
            // 
            this.timerStopwatch.Interval = 25;
            this.timerStopwatch.Tick += new System.EventHandler(this.timerStopwatch_Tick);
            // 
            // World_Clock_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 617);
            this.Controls.Add(this.tabControl1);
            this.Name = "World_Clock_Form";
            this.Text = "World Clock";
            this.Load += new System.EventHandler(this.World_Clock_Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.Clocktab.ResumeLayout(false);
            this.Clocktab.PerformLayout();
            this.Stopwatchtab.ResumeLayout(false);
            this.Stopwatchtab.PerformLayout();
            this.Timertab.ResumeLayout(false);
            this.Timertab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Clocktab;
        private System.Windows.Forms.TabPage Stopwatchtab;
        private System.Windows.Forms.TabPage Timertab;
        private System.Windows.Forms.Label lblEntrCity;
        private System.Windows.Forms.Button bttnAddCity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bttnReset;
        private System.Windows.Forms.Button bttnLap;
        private System.Windows.Forms.Button bttnStart;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timerStopwatch;
        private System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.Label lbldisplay;
        private System.Windows.Forms.Label lblLocal;
    }
}

