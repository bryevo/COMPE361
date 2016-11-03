namespace PA6
{
    partial class EvolutionParameters
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
            this.labelBMIN = new System.Windows.Forms.Label();
            this.labelBMAX = new System.Windows.Forms.Label();
            this.labelSMIN = new System.Windows.Forms.Label();
            this.labelSMAX = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numBMIN = new System.Windows.Forms.NumericUpDown();
            this.numSMIN = new System.Windows.Forms.NumericUpDown();
            this.numSMAX = new System.Windows.Forms.NumericUpDown();
            this.numBMAX = new System.Windows.Forms.NumericUpDown();
            this.btnDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numBMIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSMIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSMAX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBMAX)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBMIN
            // 
            this.labelBMIN.AutoSize = true;
            this.labelBMIN.Location = new System.Drawing.Point(46, 52);
            this.labelBMIN.Name = "labelBMIN";
            this.labelBMIN.Size = new System.Drawing.Size(37, 13);
            this.labelBMIN.TabIndex = 0;
            this.labelBMIN.Text = "BMIN:";
            // 
            // labelBMAX
            // 
            this.labelBMAX.AutoSize = true;
            this.labelBMAX.Location = new System.Drawing.Point(43, 86);
            this.labelBMAX.Name = "labelBMAX";
            this.labelBMAX.Size = new System.Drawing.Size(40, 13);
            this.labelBMAX.TabIndex = 1;
            this.labelBMAX.Text = "BMAX:";
            // 
            // labelSMIN
            // 
            this.labelSMIN.AutoSize = true;
            this.labelSMIN.Location = new System.Drawing.Point(43, 122);
            this.labelSMIN.Name = "labelSMIN";
            this.labelSMIN.Size = new System.Drawing.Size(37, 13);
            this.labelSMIN.TabIndex = 2;
            this.labelSMIN.Text = "SMIN:";
            // 
            // labelSMAX
            // 
            this.labelSMAX.AutoSize = true;
            this.labelSMAX.Location = new System.Drawing.Point(43, 151);
            this.labelSMAX.Name = "labelSMAX";
            this.labelSMAX.Size = new System.Drawing.Size(40, 13);
            this.labelSMAX.TabIndex = 3;
            this.labelSMAX.Text = "SMAX:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Please set the evolution parameters";
            // 
            // numBMIN
            // 
            this.numBMIN.Location = new System.Drawing.Point(102, 45);
            this.numBMIN.Name = "numBMIN";
            this.numBMIN.Size = new System.Drawing.Size(120, 20);
            this.numBMIN.TabIndex = 5;
            // 
            // numSMIN
            // 
            this.numSMIN.Location = new System.Drawing.Point(102, 115);
            this.numSMIN.Name = "numSMIN";
            this.numSMIN.Size = new System.Drawing.Size(120, 20);
            this.numSMIN.TabIndex = 6;
            // 
            // numSMAX
            // 
            this.numSMAX.Location = new System.Drawing.Point(102, 149);
            this.numSMAX.Name = "numSMAX";
            this.numSMAX.Size = new System.Drawing.Size(120, 20);
            this.numSMAX.TabIndex = 7;
            // 
            // numBMAX
            // 
            this.numBMAX.Location = new System.Drawing.Point(102, 79);
            this.numBMAX.Name = "numBMAX";
            this.numBMAX.Size = new System.Drawing.Size(120, 20);
            this.numBMAX.TabIndex = 8;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(146, 205);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // EvolutionParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.numBMAX);
            this.Controls.Add(this.numSMAX);
            this.Controls.Add(this.numSMIN);
            this.Controls.Add(this.numBMIN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelSMAX);
            this.Controls.Add(this.labelSMIN);
            this.Controls.Add(this.labelBMAX);
            this.Controls.Add(this.labelBMIN);
            this.Name = "EvolutionParameters";
            this.Text = "EvolutionParameters";
            ((System.ComponentModel.ISupportInitialize)(this.numBMIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSMIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSMAX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBMAX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBMIN;
        private System.Windows.Forms.Label labelBMAX;
        private System.Windows.Forms.Label labelSMIN;
        private System.Windows.Forms.Label labelSMAX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numBMIN;
        private System.Windows.Forms.NumericUpDown numSMIN;
        private System.Windows.Forms.NumericUpDown numSMAX;
        private System.Windows.Forms.NumericUpDown numBMAX;
        private System.Windows.Forms.Button btnDone;
    }
}