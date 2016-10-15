using System;

namespace PA5
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAddAlarm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbAlarm = new System.Windows.Forms.Label();
            this.lbSnooze = new System.Windows.Forms.Label();
            this.snzText = new System.Windows.Forms.TextBox();
            this.cbOptions = new System.Windows.Forms.ComboBox();
            this.dateTimeAlarm = new System.Windows.Forms.DateTimePicker();
            this.cbAlarm = new System.Windows.Forms.CheckedListBox();
            this.snzDec = new System.Windows.Forms.Button();
            this.btnDelAlarm = new System.Windows.Forms.Button();
            this.snzAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbAppointment = new System.Windows.Forms.CheckedListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.timer_Time = new System.Windows.Forms.Timer(this.components);
            this.timer_Alarm = new System.Windows.Forms.Timer(this.components);
            this.timer_Snooze = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddAlarm
            // 
            this.btnAddAlarm.ForeColor = System.Drawing.Color.Black;
            this.btnAddAlarm.Location = new System.Drawing.Point(9, 49);
            this.btnAddAlarm.Name = "btnAddAlarm";
            this.btnAddAlarm.Size = new System.Drawing.Size(31, 24);
            this.btnAddAlarm.TabIndex = 2;
            this.btnAddAlarm.Text = "+";
            this.btnAddAlarm.UseVisualStyleBackColor = true;
            this.btnAddAlarm.Click += new System.EventHandler(this.btnAddAlarm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.lbAlarm);
            this.groupBox1.Controls.Add(this.lbSnooze);
            this.groupBox1.Controls.Add(this.snzText);
            this.groupBox1.Controls.Add(this.cbOptions);
            this.groupBox1.Controls.Add(this.dateTimeAlarm);
            this.groupBox1.Controls.Add(this.cbAlarm);
            this.groupBox1.Controls.Add(this.snzDec);
            this.groupBox1.Controls.Add(this.btnDelAlarm);
            this.groupBox1.Controls.Add(this.snzAdd);
            this.groupBox1.Controls.Add(this.btnAddAlarm);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(13, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 329);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alarm";
            // 
            // lbAlarm
            // 
            this.lbAlarm.AutoSize = true;
            this.lbAlarm.Location = new System.Drawing.Point(57, 53);
            this.lbAlarm.Name = "lbAlarm";
            this.lbAlarm.Size = new System.Drawing.Size(81, 16);
            this.lbAlarm.TabIndex = 8;
            this.lbAlarm.Text = "Add/Remove";
            // 
            // lbSnooze
            // 
            this.lbSnooze.AutoSize = true;
            this.lbSnooze.Location = new System.Drawing.Point(6, 304);
            this.lbSnooze.Name = "lbSnooze";
            this.lbSnooze.Size = new System.Drawing.Size(85, 16);
            this.lbSnooze.TabIndex = 7;
            this.lbSnooze.Text = "Snooze (sec)";
            // 
            // snzText
            // 
            this.snzText.Location = new System.Drawing.Point(131, 302);
            this.snzText.Name = "snzText";
            this.snzText.Size = new System.Drawing.Size(30, 22);
            this.snzText.TabIndex = 6;
            this.snzText.Text = "5";
            // 
            // cbOptions
            // 
            this.cbOptions.FormattingEnabled = true;
            this.cbOptions.Items.AddRange(new object[] {
            "Time",
            "Date"});
            this.cbOptions.Location = new System.Drawing.Point(122, 21);
            this.cbOptions.Name = "cbOptions";
            this.cbOptions.Size = new System.Drawing.Size(65, 24);
            this.cbOptions.TabIndex = 5;
            this.cbOptions.SelectedIndexChanged += new System.EventHandler(this.cbOptions_SelectedIndexChanged);
            // 
            // dateTimeAlarm
            // 
            this.dateTimeAlarm.CustomFormat = "hh:mm:ss tt";
            this.dateTimeAlarm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeAlarm.Location = new System.Drawing.Point(6, 21);
            this.dateTimeAlarm.Name = "dateTimeAlarm";
            this.dateTimeAlarm.Size = new System.Drawing.Size(110, 22);
            this.dateTimeAlarm.TabIndex = 4;
            this.dateTimeAlarm.Value = new System.DateTime(2016, 10, 14, 19, 55, 36, 960);
            // 
            // cbAlarm
            // 
            this.cbAlarm.BackColor = System.Drawing.Color.Black;
            this.cbAlarm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbAlarm.ForeColor = System.Drawing.Color.White;
            this.cbAlarm.FormattingEnabled = true;
            this.cbAlarm.Location = new System.Drawing.Point(7, 79);
            this.cbAlarm.Name = "cbAlarm";
            this.cbAlarm.Size = new System.Drawing.Size(180, 221);
            this.cbAlarm.TabIndex = 3;
            // 
            // snzDec
            // 
            this.snzDec.ForeColor = System.Drawing.Color.Black;
            this.snzDec.Location = new System.Drawing.Point(105, 302);
            this.snzDec.Name = "snzDec";
            this.snzDec.Size = new System.Drawing.Size(20, 22);
            this.snzDec.TabIndex = 2;
            this.snzDec.Text = "-";
            this.snzDec.UseVisualStyleBackColor = true;
            this.snzDec.Click += new System.EventHandler(this.snzDel_Click);
            // 
            // btnDelAlarm
            // 
            this.btnDelAlarm.ForeColor = System.Drawing.Color.Black;
            this.btnDelAlarm.Location = new System.Drawing.Point(156, 49);
            this.btnDelAlarm.Name = "btnDelAlarm";
            this.btnDelAlarm.Size = new System.Drawing.Size(31, 24);
            this.btnDelAlarm.TabIndex = 2;
            this.btnDelAlarm.Text = "-";
            this.btnDelAlarm.UseVisualStyleBackColor = true;
            this.btnDelAlarm.Click += new System.EventHandler(this.btnDelAlarm_Click);
            // 
            // snzAdd
            // 
            this.snzAdd.ForeColor = System.Drawing.Color.Black;
            this.snzAdd.Location = new System.Drawing.Point(167, 301);
            this.snzAdd.Name = "snzAdd";
            this.snzAdd.Size = new System.Drawing.Size(20, 22);
            this.snzAdd.TabIndex = 2;
            this.snzAdd.Text = "+";
            this.snzAdd.UseVisualStyleBackColor = true;
            this.snzAdd.Click += new System.EventHandler(this.snzAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.cbAppointment);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(213, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 329);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointments";
            // 
            // cbAppointment
            // 
            this.cbAppointment.BackColor = System.Drawing.Color.Black;
            this.cbAppointment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbAppointment.ForeColor = System.Drawing.Color.White;
            this.cbAppointment.FormattingEnabled = true;
            this.cbAppointment.Location = new System.Drawing.Point(6, 21);
            this.cbAppointment.Name = "cbAppointment";
            this.cbAppointment.Size = new System.Drawing.Size(145, 272);
            this.cbAppointment.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(157, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 24);
            this.button4.TabIndex = 2;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(157, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Bodoni MT", 24F);
            this.lbTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbTime.Location = new System.Drawing.Point(13, 9);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(0, 38);
            this.lbTime.TabIndex = 4;
            // 
            // timer_Time
            // 
            this.timer_Time.Enabled = true;
            this.timer_Time.Tick += new System.EventHandler(this.timer_Time_Tick);
            // 
            // timer_Alarm
            // 
            this.timer_Alarm.Enabled = true;
            this.timer_Alarm.Interval = 1000;
            this.timer_Alarm.Tick += new System.EventHandler(this.alarm_Elapsed);
            // 
            // timer_Snooze
            // 
            this.timer_Snooze.Tick += new System.EventHandler(this.timer_Snooze_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(424, 391);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Program Assignment 5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAlarm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelAlarm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.CheckedListBox cbAlarm;
        private System.Windows.Forms.CheckedListBox cbAppointment;
        private System.Windows.Forms.Timer timer_Time;
        private System.Windows.Forms.DateTimePicker dateTimeAlarm;
        private System.Windows.Forms.ComboBox cbOptions;
        private System.Windows.Forms.Timer timer_Alarm;
        private System.Windows.Forms.TextBox snzText;
        private System.Windows.Forms.Button snzDec;
        private System.Windows.Forms.Button snzAdd;
        private System.Windows.Forms.Label lbAlarm;
        private System.Windows.Forms.Label lbSnooze;
        public System.Windows.Forms.Timer timer_Snooze;
    }
}

