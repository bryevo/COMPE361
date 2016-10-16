﻿using System;

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
            this.cbAppointment = new System.Windows.Forms.CheckedListBox();
            this.btnDelApp = new System.Windows.Forms.Button();
            this.btnAddApp = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.timer_Time = new System.Windows.Forms.Timer(this.components);
            this.timer_Alarm = new System.Windows.Forms.Timer(this.components);
            this.timer_Snooze = new System.Windows.Forms.Timer(this.components);
            this.gbAlarm.SuspendLayout();
            this.gbApp.SuspendLayout();
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
            this.gbAlarm.Location = new System.Drawing.Point(13, 50);
            this.gbAlarm.Name = "gbAlarm";
            this.gbAlarm.Size = new System.Drawing.Size(194, 329);
            this.gbAlarm.TabIndex = 3;
            this.gbAlarm.TabStop = false;
            this.gbAlarm.Text = "Alarm";
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
            this.cbAlarm.FormatString = "G";
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
            // gbApp
            // 
            this.gbApp.BackColor = System.Drawing.Color.Black;
            this.gbApp.Controls.Add(this.cbAppointment);
            this.gbApp.Controls.Add(this.btnDelApp);
            this.gbApp.Controls.Add(this.btnAddApp);
            this.gbApp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbApp.Location = new System.Drawing.Point(213, 50);
            this.gbApp.Name = "gbApp";
            this.gbApp.Size = new System.Drawing.Size(194, 329);
            this.gbApp.TabIndex = 3;
            this.gbApp.TabStop = false;
            this.gbApp.Text = "Appointments";
            // 
            // cbAppointment
            // 
            this.cbAppointment.BackColor = System.Drawing.Color.Black;
            this.cbAppointment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbAppointment.ForeColor = System.Drawing.Color.White;
            this.cbAppointment.FormattingEnabled = true;
            this.cbAppointment.Location = new System.Drawing.Point(6, 21);
            this.cbAppointment.Name = "cbAppointment";
            this.cbAppointment.Size = new System.Drawing.Size(145, 170);
            this.cbAppointment.TabIndex = 3;
            // 
            // btnDelApp
            // 
            this.btnDelApp.ForeColor = System.Drawing.Color.Black;
            this.btnDelApp.Location = new System.Drawing.Point(157, 40);
            this.btnDelApp.Name = "btnDelApp";
            this.btnDelApp.Size = new System.Drawing.Size(31, 24);
            this.btnDelApp.TabIndex = 2;
            this.btnDelApp.Text = "-";
            this.btnDelApp.UseVisualStyleBackColor = true;
            this.btnDelApp.Click += new System.EventHandler(this.btnDelApp_Click);
            // 
            // btnAddApp
            // 
            this.btnAddApp.BackColor = System.Drawing.Color.Transparent;
            this.btnAddApp.ForeColor = System.Drawing.Color.Black;
            this.btnAddApp.Location = new System.Drawing.Point(157, 10);
            this.btnAddApp.Name = "btnAddApp";
            this.btnAddApp.Size = new System.Drawing.Size(31, 24);
            this.btnAddApp.TabIndex = 2;
            this.btnAddApp.Text = "+";
            this.btnAddApp.UseVisualStyleBackColor = false;
            this.btnAddApp.Click += new System.EventHandler(this.btnAddApp_Click);
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
            this.timer_Snooze.Interval = 1000;
            this.timer_Snooze.Tick += new System.EventHandler(this.timer_Snooze_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(424, 391);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.gbApp);
            this.Controls.Add(this.gbAlarm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Program Assignment 5";
            this.gbAlarm.ResumeLayout(false);
            this.gbAlarm.PerformLayout();
            this.gbApp.ResumeLayout(false);
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

