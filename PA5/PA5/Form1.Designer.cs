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
            this.gbAlarm = new System.Windows.Forms.GroupBox();
            this.lbAlarm = new System.Windows.Forms.Label();
            this.lbSnooze = new System.Windows.Forms.Label();
            this.snzText = new System.Windows.Forms.TextBox();
            this.cbOptions = new System.Windows.Forms.ComboBox();
            this.dateTimeAlarm = new System.Windows.Forms.DateTimePicker();
            this.cbAlarm = new System.Windows.Forms.CheckedListBox();
            this.snzDec = new System.Windows.Forms.Button();
            this.btnDelAlarm = new System.Windows.Forms.Button();
            this.snzAdd = new System.Windows.Forms.Button();
            this.gbApp = new System.Windows.Forms.GroupBox();
            this.lbReminder = new System.Windows.Forms.LinkLabel();
            this.picRemind = new System.Windows.Forms.PictureBox();
            this.lbApp = new System.Windows.Forms.ListBox();
            this.btnDelApp = new System.Windows.Forms.Button();
            this.btnAddApp = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.timer_Time = new System.Windows.Forms.Timer(this.components);
            this.timer_Alarm = new System.Windows.Forms.Timer(this.components);
            this.timer_Snooze = new System.Windows.Forms.Timer(this.components);
            this.timer_Appointment = new System.Windows.Forms.Timer(this.components);
            this.timer_Reminder = new System.Windows.Forms.Timer(this.components);
            this.gbAlarm.SuspendLayout();
            this.gbApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRemind)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddAlarm
            // 
            this.btnAddAlarm.ForeColor = System.Drawing.Color.Black;
            this.btnAddAlarm.Location = new System.Drawing.Point(312, 94);
            this.btnAddAlarm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddAlarm.Name = "btnAddAlarm";
            this.btnAddAlarm.Size = new System.Drawing.Size(62, 46);
            this.btnAddAlarm.TabIndex = 2;
            this.btnAddAlarm.Text = "+";
            this.btnAddAlarm.UseVisualStyleBackColor = true;
            this.btnAddAlarm.Click += new System.EventHandler(this.btnAddAlarm_Click);
            // 
            // gbAlarm
            // 
            this.gbAlarm.BackColor = System.Drawing.Color.Black;
            this.gbAlarm.Controls.Add(this.lbAlarm);
            this.gbAlarm.Controls.Add(this.lbSnooze);
            this.gbAlarm.Controls.Add(this.snzText);
            this.gbAlarm.Controls.Add(this.cbOptions);
            this.gbAlarm.Controls.Add(this.dateTimeAlarm);
            this.gbAlarm.Controls.Add(this.cbAlarm);
            this.gbAlarm.Controls.Add(this.snzDec);
            this.gbAlarm.Controls.Add(this.btnDelAlarm);
            this.gbAlarm.Controls.Add(this.snzAdd);
            this.gbAlarm.Controls.Add(this.btnAddAlarm);
            this.gbAlarm.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAlarm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbAlarm.Location = new System.Drawing.Point(26, 96);
            this.gbAlarm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbAlarm.Name = "gbAlarm";
            this.gbAlarm.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbAlarm.Size = new System.Drawing.Size(388, 633);
            this.gbAlarm.TabIndex = 10;
            this.gbAlarm.TabStop = false;
            this.gbAlarm.Text = "Alarm";
            // 
            // lbAlarm
            // 
            this.lbAlarm.AutoSize = true;
            this.lbAlarm.Location = new System.Drawing.Point(114, 102);
            this.lbAlarm.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAlarm.Name = "lbAlarm";
            this.lbAlarm.Size = new System.Drawing.Size(164, 31);
            this.lbAlarm.TabIndex = 10;
            this.lbAlarm.Text = "Remove/Add";
            // 
            // lbSnooze
            // 
            this.lbSnooze.AutoSize = true;
            this.lbSnooze.Location = new System.Drawing.Point(12, 585);
            this.lbSnooze.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSnooze.Name = "lbSnooze";
            this.lbSnooze.Size = new System.Drawing.Size(165, 31);
            this.lbSnooze.TabIndex = 10;
            this.lbSnooze.Text = "Snooze (sec)";
            // 
            // snzText
            // 
            this.snzText.Location = new System.Drawing.Point(262, 581);
            this.snzText.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.snzText.Name = "snzText";
            this.snzText.Size = new System.Drawing.Size(56, 37);
            this.snzText.TabIndex = 4;
            this.snzText.Text = "5";
            // 
            // cbOptions
            // 
            this.cbOptions.FormattingEnabled = true;
            this.cbOptions.Items.AddRange(new object[] {
            "Time",
            "Date"});
            this.cbOptions.Location = new System.Drawing.Point(244, 40);
            this.cbOptions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbOptions.Name = "cbOptions";
            this.cbOptions.Size = new System.Drawing.Size(126, 39);
            this.cbOptions.TabIndex = 1;
            this.cbOptions.SelectedIndexChanged += new System.EventHandler(this.cbOptions_SelectedIndexChanged);
            // 
            // dateTimeAlarm
            // 
            this.dateTimeAlarm.CustomFormat = "hh:mm:ss tt";
            this.dateTimeAlarm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeAlarm.Location = new System.Drawing.Point(12, 40);
            this.dateTimeAlarm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTimeAlarm.Name = "dateTimeAlarm";
            this.dateTimeAlarm.Size = new System.Drawing.Size(216, 37);
            this.dateTimeAlarm.TabIndex = 0;
            this.dateTimeAlarm.Value = new System.DateTime(2016, 10, 14, 19, 55, 36, 960);
            // 
            // cbAlarm
            // 
            this.cbAlarm.BackColor = System.Drawing.Color.Black;
            this.cbAlarm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbAlarm.ForeColor = System.Drawing.Color.White;
            this.cbAlarm.FormatString = "G";
            this.cbAlarm.FormattingEnabled = true;
            this.cbAlarm.Location = new System.Drawing.Point(14, 152);
            this.cbAlarm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbAlarm.Name = "cbAlarm";
            this.cbAlarm.Size = new System.Drawing.Size(360, 416);
            this.cbAlarm.TabIndex = 3;
            // 
            // snzDec
            // 
            this.snzDec.ForeColor = System.Drawing.Color.Black;
            this.snzDec.Location = new System.Drawing.Point(210, 581);
            this.snzDec.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.snzDec.Name = "snzDec";
            this.snzDec.Size = new System.Drawing.Size(40, 42);
            this.snzDec.TabIndex = 2;
            this.snzDec.Text = "-";
            this.snzDec.UseVisualStyleBackColor = true;
            this.snzDec.Click += new System.EventHandler(this.snzDel_Click);
            // 
            // btnDelAlarm
            // 
            this.btnDelAlarm.ForeColor = System.Drawing.Color.Black;
            this.btnDelAlarm.Location = new System.Drawing.Point(14, 94);
            this.btnDelAlarm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDelAlarm.Name = "btnDelAlarm";
            this.btnDelAlarm.Size = new System.Drawing.Size(62, 46);
            this.btnDelAlarm.TabIndex = 3;
            this.btnDelAlarm.Text = "-";
            this.btnDelAlarm.UseVisualStyleBackColor = true;
            this.btnDelAlarm.Click += new System.EventHandler(this.btnDelAlarm_Click);
            // 
            // snzAdd
            // 
            this.snzAdd.ForeColor = System.Drawing.Color.Black;
            this.snzAdd.Location = new System.Drawing.Point(334, 579);
            this.snzAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.snzAdd.Name = "snzAdd";
            this.snzAdd.Size = new System.Drawing.Size(40, 42);
            this.snzAdd.TabIndex = 2;
            this.snzAdd.Text = "+";
            this.snzAdd.UseVisualStyleBackColor = true;
            this.snzAdd.Click += new System.EventHandler(this.snzAdd_Click);
            // 
            // gbApp
            // 
            this.gbApp.BackColor = System.Drawing.Color.Black;
            this.gbApp.Controls.Add(this.lbReminder);
            this.gbApp.Controls.Add(this.picRemind);
            this.gbApp.Controls.Add(this.lbApp);
            this.gbApp.Controls.Add(this.btnDelApp);
            this.gbApp.Controls.Add(this.btnAddApp);
            this.gbApp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbApp.Location = new System.Drawing.Point(426, 96);
            this.gbApp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbApp.Name = "gbApp";
            this.gbApp.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbApp.Size = new System.Drawing.Size(388, 633);
            this.gbApp.TabIndex = 3;
            this.gbApp.TabStop = false;
            this.gbApp.Text = "Appointments";
            // 
            // lbReminder
            // 
            this.lbReminder.AutoSize = true;
            this.lbReminder.LinkColor = System.Drawing.Color.Red;
            this.lbReminder.Location = new System.Drawing.Point(14, 362);
            this.lbReminder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbReminder.Name = "lbReminder";
            this.lbReminder.Size = new System.Drawing.Size(188, 31);
            this.lbReminder.TabIndex = 10;
            this.lbReminder.TabStop = true;
            this.lbReminder.Text = "Hide Reminder";
            this.lbReminder.Visible = false;
            this.lbReminder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbAppointment_Clicked);
            // 
            // picRemind
            // 
            this.picRemind.Image = global::PA5.Properties.Resources.pleaseno;
            this.picRemind.Location = new System.Drawing.Point(12, 398);
            this.picRemind.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picRemind.Name = "picRemind";
            this.picRemind.Size = new System.Drawing.Size(364, 217);
            this.picRemind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRemind.TabIndex = 10;
            this.picRemind.TabStop = false;
            this.picRemind.Visible = false;
            // 
            // lbApp
            // 
            this.lbApp.BackColor = System.Drawing.Color.Black;
            this.lbApp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbApp.ForeColor = System.Drawing.Color.White;
            this.lbApp.FormatString = "M";
            this.lbApp.FormattingEnabled = true;
            this.lbApp.ItemHeight = 31;
            this.lbApp.Location = new System.Drawing.Point(12, 40);
            this.lbApp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbApp.Name = "lbApp";
            this.lbApp.Size = new System.Drawing.Size(290, 279);
            this.lbApp.TabIndex = 3;
            this.lbApp.DoubleClick += new System.EventHandler(this.lbApp_DoubleClick);
            // 
            // btnDelApp
            // 
            this.btnDelApp.ForeColor = System.Drawing.Color.Black;
            this.btnDelApp.Location = new System.Drawing.Point(314, 77);
            this.btnDelApp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDelApp.Name = "btnDelApp";
            this.btnDelApp.Size = new System.Drawing.Size(62, 46);
            this.btnDelApp.TabIndex = 6;
            this.btnDelApp.Text = "-";
            this.btnDelApp.UseVisualStyleBackColor = true;
            this.btnDelApp.Click += new System.EventHandler(this.btnDelApp_Click);
            // 
            // btnAddApp
            // 
            this.btnAddApp.BackColor = System.Drawing.Color.Transparent;
            this.btnAddApp.ForeColor = System.Drawing.Color.Black;
            this.btnAddApp.Location = new System.Drawing.Point(314, 19);
            this.btnAddApp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddApp.Name = "btnAddApp";
            this.btnAddApp.Size = new System.Drawing.Size(62, 46);
            this.btnAddApp.TabIndex = 5;
            this.btnAddApp.Text = "+";
            this.btnAddApp.UseVisualStyleBackColor = false;
            this.btnAddApp.Click += new System.EventHandler(this.btnAddApp_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Bodoni MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbTime.Location = new System.Drawing.Point(26, 17);
            this.lbTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(0, 77);
            this.lbTime.TabIndex = 10;
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
            this.timer_Snooze.Interval = 1000;
            this.timer_Snooze.Tick += new System.EventHandler(this.timer_Snooze_Tick);
            // 
            // timer_Appointment
            // 
            this.timer_Appointment.Enabled = true;
            this.timer_Appointment.Interval = 1000;
            //this.timer_Appointment.Tick += new System.EventHandler(this.timer_Appointment_Tick);
            // 
            // timer_Reminder
            // 
            this.timer_Reminder.Enabled = true;
            this.timer_Reminder.Interval = 1000;
            this.timer_Reminder.Tick += new System.EventHandler(this.timer_Reminder_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(848, 752);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.gbApp);
            this.Controls.Add(this.gbAlarm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Program Assignment 5";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.gbAlarm.ResumeLayout(false);
            this.gbAlarm.PerformLayout();
            this.gbApp.ResumeLayout(false);
            this.gbApp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRemind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAlarm;
        private System.Windows.Forms.GroupBox gbAlarm;
        private System.Windows.Forms.Button btnDelAlarm;
        private System.Windows.Forms.GroupBox gbApp;
        private System.Windows.Forms.Button btnDelApp;
        private System.Windows.Forms.Button btnAddApp;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.CheckedListBox cbAlarm;
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
        private System.Windows.Forms.ListBox lbApp;
        private System.Windows.Forms.Timer timer_Appointment;
        private System.Windows.Forms.PictureBox picRemind;
        private System.Windows.Forms.Timer timer_Reminder;
        private System.Windows.Forms.LinkLabel lbReminder;
    }
}

