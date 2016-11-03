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
            this.labelInstructions = new System.Windows.Forms.Label();
            this.numBMIN = new System.Windows.Forms.NumericUpDown();
            this.numBMAX = new System.Windows.Forms.NumericUpDown();
            this.numSMIN = new System.Windows.Forms.NumericUpDown();
            this.numSMAX = new System.Windows.Forms.NumericUpDown();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numBMIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBMAX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSMIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSMAX)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBMIN
            // 
            this.labelBMIN.AutoSize = true;
            this.labelBMIN.Location = new System.Drawing.Point(41, 64);
            this.labelBMIN.Name = "labelBMIN";
            this.labelBMIN.Size = new System.Drawing.Size(37, 13);
            this.labelBMIN.TabIndex = 0;
            this.labelBMIN.Text = "BMIN:";
            // 
            // labelBMAX
            // 
            this.labelBMAX.AutoSize = true;
            this.labelBMAX.Location = new System.Drawing.Point(41, 94);
            this.labelBMAX.Name = "labelBMAX";
            this.labelBMAX.Size = new System.Drawing.Size(40, 13);
            this.labelBMAX.TabIndex = 1;
            this.labelBMAX.Text = "BMAX:";
            // 
            // labelSMIN
            // 
            this.labelSMIN.AutoSize = true;
            this.labelSMIN.Location = new System.Drawing.Point(41, 121);
            this.labelSMIN.Name = "labelSMIN";
            this.labelSMIN.Size = new System.Drawing.Size(37, 13);
            this.labelSMIN.TabIndex = 2;
            this.labelSMIN.Text = "SMIN:";
            // 
            // labelSMAX
            // 
            this.labelSMAX.AutoSize = true;
            this.labelSMAX.Location = new System.Drawing.Point(41, 153);
            this.labelSMAX.Name = "labelSMAX";
            this.labelSMAX.Size = new System.Drawing.Size(40, 13);
            this.labelSMAX.TabIndex = 3;
            this.labelSMAX.Text = "SMAX:";
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.Location = new System.Drawing.Point(41, 32);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(210, 13);
            this.labelInstructions.TabIndex = 8;
            this.labelInstructions.Text = "Please set the evolution parameters";
            // 
            // numBMIN
            // 
            this.numBMIN.Location = new System.Drawing.Point(110, 64);
            this.numBMIN.Name = "numBMIN";
            this.numBMIN.Size = new System.Drawing.Size(120, 20);
            this.numBMIN.TabIndex = 9;
            // 
            // numBMAX
            // 
            this.numBMAX.Location = new System.Drawing.Point(110, 94);
            this.numBMAX.Name = "numBMAX";
            this.numBMAX.Size = new System.Drawing.Size(120, 20);
            this.numBMAX.TabIndex = 10;
            // 
            // numSMIN
            // 
            this.numSMIN.Location = new System.Drawing.Point(110, 121);
            this.numSMIN.Name = "numSMIN";
            this.numSMIN.Size = new System.Drawing.Size(120, 20);
            this.numSMIN.TabIndex = 11;
            // 
            // numSMAX
            // 
            this.numSMAX.Location = new System.Drawing.Point(110, 151);
            this.numSMAX.Name = "numSMAX";
            this.numSMAX.Size = new System.Drawing.Size(120, 20);
            this.numSMAX.TabIndex = 12;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(154, 219);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 13;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(44, 219);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EvolutionParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.numSMAX);
            this.Controls.Add(this.numSMIN);
            this.Controls.Add(this.numBMAX);
            this.Controls.Add(this.numBMIN);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.labelSMAX);
            this.Controls.Add(this.labelSMIN);
            this.Controls.Add(this.labelBMAX);
            this.Controls.Add(this.labelBMIN);
            this.Name = "EvolutionParameters";
            this.Text = "EvolutionParameters";
            ((System.ComponentModel.ISupportInitialize)(this.numBMIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBMAX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSMIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSMAX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBMIN;
        private System.Windows.Forms.Label labelBMAX;
        private System.Windows.Forms.Label labelSMIN;
        private System.Windows.Forms.Label labelSMAX;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.NumericUpDown numBMIN;
        private System.Windows.Forms.NumericUpDown numBMAX;
        private System.Windows.Forms.NumericUpDown numSMIN;
        private System.Windows.Forms.NumericUpDown numSMAX;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnCancel;
    }
}