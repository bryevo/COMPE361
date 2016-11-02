namespace PA6
{
    partial class ResizeGrid
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
            this.lbRow = new System.Windows.Forms.Label();
            this.lbCol = new System.Windows.Forms.Label();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.txtCol = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRow
            // 
            this.lbRow.AutoSize = true;
            this.lbRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRow.Location = new System.Drawing.Point(12, 28);
            this.lbRow.Name = "lbRow";
            this.lbRow.Size = new System.Drawing.Size(41, 15);
            this.lbRow.TabIndex = 0;
            this.lbRow.Text = "Rows:";
            // 
            // lbCol
            // 
            this.lbCol.AutoSize = true;
            this.lbCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCol.Location = new System.Drawing.Point(12, 64);
            this.lbCol.Name = "lbCol";
            this.lbCol.Size = new System.Drawing.Size(59, 15);
            this.lbCol.TabIndex = 1;
            this.lbCol.Text = "Columns:";
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(77, 23);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(60, 20);
            this.txtRow.TabIndex = 1;
            // 
            // txtCol
            // 
            this.txtCol.Location = new System.Drawing.Point(77, 59);
            this.txtCol.Name = "txtCol";
            this.txtCol.Size = new System.Drawing.Size(60, 20);
            this.txtCol.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(60, 110);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(51, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // ResizeGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 145);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtCol);
            this.Controls.Add(this.txtRow);
            this.Controls.Add(this.lbCol);
            this.Controls.Add(this.lbRow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResizeGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resize the grid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRow;
        private System.Windows.Forms.Label lbCol;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.TextBox txtCol;
        private System.Windows.Forms.Button btnOk;
    }
}