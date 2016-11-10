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
            this.labelGenerations = new System.Windows.Forms.Label();
            this.numericUpDownGenerations = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numBMIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSMIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSMAX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBMAX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenerations)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBMIN
            // 
            this.labelBMIN.AutoSize = true;
            this.labelBMIN.Location = new System.Drawing.Point(92, 100);
            this.labelBMIN.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelBMIN.Name = "labelBMIN";
            this.labelBMIN.Size = new System.Drawing.Size(70, 25);
            this.labelBMIN.TabIndex = 0;
            this.labelBMIN.Text = "BMIN:";
            // 
            // labelBMAX
            // 
            this.labelBMAX.AutoSize = true;
            this.labelBMAX.Location = new System.Drawing.Point(86, 165);
            this.labelBMAX.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelBMAX.Name = "labelBMAX";
            this.labelBMAX.Size = new System.Drawing.Size(78, 25);
            this.labelBMAX.TabIndex = 1;
            this.labelBMAX.Text = "BMAX:";
            // 
            // labelSMIN
            // 
            this.labelSMIN.AutoSize = true;
            this.labelSMIN.Location = new System.Drawing.Point(86, 235);
            this.labelSMIN.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSMIN.Name = "labelSMIN";
            this.labelSMIN.Size = new System.Drawing.Size(70, 25);
            this.labelSMIN.TabIndex = 2;
            this.labelSMIN.Text = "SMIN:";
            // 
            // labelSMAX
            // 
            this.labelSMAX.AutoSize = true;
            this.labelSMAX.Location = new System.Drawing.Point(86, 290);
            this.labelSMAX.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSMAX.Name = "labelSMAX";
            this.labelSMAX.Size = new System.Drawing.Size(78, 25);
            this.labelSMAX.TabIndex = 3;
            this.labelSMAX.Text = "SMAX:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(394, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Please set the evolution parameters";
            // 
            // numBMIN
            // 
            this.numBMIN.Location = new System.Drawing.Point(204, 87);
            this.numBMIN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numBMIN.Name = "numBMIN";
            this.numBMIN.Size = new System.Drawing.Size(240, 31);
            this.numBMIN.TabIndex = 1;
            // 
            // numSMIN
            // 
            this.numSMIN.Location = new System.Drawing.Point(204, 221);
            this.numSMIN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numSMIN.Name = "numSMIN";
            this.numSMIN.Size = new System.Drawing.Size(240, 31);
            this.numSMIN.TabIndex = 3;
            // 
            // numSMAX
            // 
            this.numSMAX.Location = new System.Drawing.Point(204, 287);
            this.numSMAX.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numSMAX.Name = "numSMAX";
            this.numSMAX.Size = new System.Drawing.Size(240, 31);
            this.numSMAX.TabIndex = 4;
            // 
            // numBMAX
            // 
            this.numBMAX.Location = new System.Drawing.Point(204, 152);
            this.numBMAX.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numBMAX.Name = "numBMAX";
            this.numBMAX.Size = new System.Drawing.Size(240, 31);
            this.numBMAX.TabIndex = 2;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(364, 427);
            this.btnDone.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(150, 44);
            this.btnDone.TabIndex = 0;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // labelGenerations
            // 
            this.labelGenerations.AutoSize = true;
            this.labelGenerations.Location = new System.Drawing.Point(32, 350);
            this.labelGenerations.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelGenerations.Name = "labelGenerations";
            this.labelGenerations.Size = new System.Drawing.Size(135, 25);
            this.labelGenerations.TabIndex = 10;
            this.labelGenerations.Text = "Generations:";
            // 
            // numericUpDownGenerations
            // 
            this.numericUpDownGenerations.Location = new System.Drawing.Point(204, 346);
            this.numericUpDownGenerations.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numericUpDownGenerations.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownGenerations.Name = "numericUpDownGenerations";
            this.numericUpDownGenerations.Size = new System.Drawing.Size(240, 31);
            this.numericUpDownGenerations.TabIndex = 6;
            this.numericUpDownGenerations.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // EvolutionParameters
            // 
            this.AcceptButton = this.btnDone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 502);
            this.Controls.Add(this.numericUpDownGenerations);
            this.Controls.Add(this.labelGenerations);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "EvolutionParameters";
            this.Text = "EvolutionParameters";
            ((System.ComponentModel.ISupportInitialize)(this.numBMIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSMIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSMAX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBMAX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenerations)).EndInit();
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
        private System.Windows.Forms.Label labelGenerations;
        private System.Windows.Forms.NumericUpDown numericUpDownGenerations;
    }
}