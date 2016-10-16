namespace PA5
{
    partial class AppMessageBox
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
            this.dtApp = new System.Windows.Forms.DateTimePicker();
            this.cbApp = new System.Windows.Forms.ComboBox();
            this.lbDue = new System.Windows.Forms.Label();
            this.dtReminder = new System.Windows.Forms.DateTimePicker();
            this.cbReminder = new System.Windows.Forms.ComboBox();
            this.lbReminder = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.RichTextBox();
            this.lbNote = new System.Windows.Forms.Label();
            this.btnSetApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtApp
            // 
            this.dtApp.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtApp.CustomFormat = "hh:mm:ss tt";
            this.dtApp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtApp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtApp.Location = new System.Drawing.Point(78, 11);
            this.dtApp.Name = "dtApp";
            this.dtApp.Size = new System.Drawing.Size(110, 22);
            this.dtApp.TabIndex = 5;
            this.dtApp.Value = new System.DateTime(2016, 10, 14, 19, 55, 36, 960);
            // 
            // cbApp
            // 
            this.cbApp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbApp.FormattingEnabled = true;
            this.cbApp.Items.AddRange(new object[] {
            "Time",
            "Date"});
            this.cbApp.Location = new System.Drawing.Point(194, 11);
            this.cbApp.Name = "cbApp";
            this.cbApp.Size = new System.Drawing.Size(65, 24);
            this.cbApp.TabIndex = 6;
            this.cbApp.SelectedIndexChanged += new System.EventHandler(this.cbApp_SelectedIndexChanged);
            // 
            // lbDue
            // 
            this.lbDue.AutoSize = true;
            this.lbDue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDue.Location = new System.Drawing.Point(12, 16);
            this.lbDue.Name = "lbDue";
            this.lbDue.Size = new System.Drawing.Size(31, 16);
            this.lbDue.TabIndex = 7;
            this.lbDue.Text = "Due";
            // 
            // dtReminder
            // 
            this.dtReminder.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtReminder.CustomFormat = "hh:mm:ss tt";
            this.dtReminder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtReminder.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtReminder.Location = new System.Drawing.Point(78, 36);
            this.dtReminder.Name = "dtReminder";
            this.dtReminder.Size = new System.Drawing.Size(110, 22);
            this.dtReminder.TabIndex = 5;
            this.dtReminder.Value = new System.DateTime(2016, 10, 14, 19, 55, 36, 960);
            // 
            // cbReminder
            // 
            this.cbReminder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReminder.FormattingEnabled = true;
            this.cbReminder.Items.AddRange(new object[] {
            "Time",
            "Date"});
            this.cbReminder.Location = new System.Drawing.Point(194, 37);
            this.cbReminder.Name = "cbReminder";
            this.cbReminder.Size = new System.Drawing.Size(65, 24);
            this.cbReminder.TabIndex = 6;
            this.cbReminder.SelectedIndexChanged += new System.EventHandler(this.cbReminder_SelectedIndexChanged);
            // 
            // lbReminder
            // 
            this.lbReminder.AutoSize = true;
            this.lbReminder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReminder.Location = new System.Drawing.Point(12, 42);
            this.lbReminder.Name = "lbReminder";
            this.lbReminder.Size = new System.Drawing.Size(63, 16);
            this.lbReminder.TabIndex = 7;
            this.lbReminder.Text = "Reminder";
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(16, 95);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(243, 70);
            this.tbNote.TabIndex = 8;
            this.tbNote.Text = "";
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.Location = new System.Drawing.Point(12, 76);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(35, 16);
            this.lbNote.TabIndex = 9;
            this.lbNote.Text = "Note";
            // 
            // btnSetApp
            // 
            this.btnSetApp.Location = new System.Drawing.Point(101, 176);
            this.btnSetApp.Name = "btnSetApp";
            this.btnSetApp.Size = new System.Drawing.Size(75, 23);
            this.btnSetApp.TabIndex = 10;
            this.btnSetApp.Text = "OK";
            this.btnSetApp.UseVisualStyleBackColor = true;
            this.btnSetApp.Click += new System.EventHandler(this.btnSetApp_Click);
            // 
            // AppMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 211);
            this.Controls.Add(this.btnSetApp);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.lbReminder);
            this.Controls.Add(this.lbDue);
            this.Controls.Add(this.cbReminder);
            this.Controls.Add(this.cbApp);
            this.Controls.Add(this.dtReminder);
            this.Controls.Add(this.dtApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AppMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set an Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtApp;
        private System.Windows.Forms.ComboBox cbApp;
        private System.Windows.Forms.Label lbDue;
        private System.Windows.Forms.DateTimePicker dtReminder;
        private System.Windows.Forms.ComboBox cbReminder;
        private System.Windows.Forms.Label lbReminder;
        private System.Windows.Forms.RichTextBox tbNote;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.Button btnSetApp;
    }
}