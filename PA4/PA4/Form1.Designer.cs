namespace day12
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
        private void InitializeComponent()
        {
            this.lbWords = new System.Windows.Forms.ListBox();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.gbWordSearch = new System.Windows.Forms.GroupBox();
            this.rbMorphChain = new System.Windows.Forms.RadioButton();
            this.rbMorphWord = new System.Windows.Forms.RadioButton();
            this.rbScrabble = new System.Windows.Forms.RadioButton();
            this.rbRhyme = new System.Windows.Forms.RadioButton();
            this.lbWordSearch = new System.Windows.Forms.ListBox();
            this.btnFill2 = new System.Windows.Forms.Button();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Label();
            this.tbEnd = new System.Windows.Forms.TextBox();
            this.end = new System.Windows.Forms.Label();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.maxLength = new System.Windows.Forms.Label();
            this.gbWordSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbWords
            // 
            this.lbWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbWords.FormattingEnabled = true;
            this.lbWords.ItemHeight = 25;
            this.lbWords.Location = new System.Drawing.Point(20, 71);
            this.lbWords.Margin = new System.Windows.Forms.Padding(4);
            this.lbWords.Name = "lbWords";
            this.lbWords.Size = new System.Drawing.Size(262, 554);
            this.lbWords.TabIndex = 0;
            this.lbWords.DoubleClick += new System.EventHandler(this.lbWords_DoubleClick);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(20, 19);
            this.btnFill.Margin = new System.Windows.Forms.Padding(4);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(112, 37);
            this.btnFill.TabIndex = 1;
            this.btnFill.Text = "Fill";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(172, 19);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 37);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.Location = new System.Drawing.Point(292, 71);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(394, 31);
            this.txtUser.TabIndex = 3;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Location = new System.Drawing.Point(696, 69);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(92, 37);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // gbWordSearch
            // 
            this.gbWordSearch.Controls.Add(this.rbMorphChain);
            this.gbWordSearch.Controls.Add(this.rbMorphWord);
            this.gbWordSearch.Controls.Add(this.rbScrabble);
            this.gbWordSearch.Controls.Add(this.rbRhyme);
            this.gbWordSearch.Location = new System.Drawing.Point(292, 284);
            this.gbWordSearch.Margin = new System.Windows.Forms.Padding(6);
            this.gbWordSearch.Name = "gbWordSearch";
            this.gbWordSearch.Padding = new System.Windows.Forms.Padding(6);
            this.gbWordSearch.Size = new System.Drawing.Size(242, 223);
            this.gbWordSearch.TabIndex = 5;
            this.gbWordSearch.TabStop = false;
            this.gbWordSearch.Text = "Options:";
            // 
            // rbMorphChain
            // 
            this.rbMorphChain.AutoSize = true;
            this.rbMorphChain.Location = new System.Drawing.Point(14, 158);
            this.rbMorphChain.Name = "rbMorphChain";
            this.rbMorphChain.Size = new System.Drawing.Size(166, 29);
            this.rbMorphChain.TabIndex = 3;
            this.rbMorphChain.TabStop = true;
            this.rbMorphChain.Text = "Morph Chain";
            this.rbMorphChain.UseVisualStyleBackColor = true;
            // 
            // rbMorphWord
            // 
            this.rbMorphWord.AutoSize = true;
            this.rbMorphWord.Location = new System.Drawing.Point(14, 120);
            this.rbMorphWord.Margin = new System.Windows.Forms.Padding(6);
            this.rbMorphWord.Name = "rbMorphWord";
            this.rbMorphWord.Size = new System.Drawing.Size(161, 29);
            this.rbMorphWord.TabIndex = 2;
            this.rbMorphWord.TabStop = true;
            this.rbMorphWord.Text = "Morph Word";
            this.rbMorphWord.UseVisualStyleBackColor = true;
            // 
            // rbScrabble
            // 
            this.rbScrabble.AutoSize = true;
            this.rbScrabble.Location = new System.Drawing.Point(14, 79);
            this.rbScrabble.Margin = new System.Windows.Forms.Padding(6);
            this.rbScrabble.Name = "rbScrabble";
            this.rbScrabble.Size = new System.Drawing.Size(128, 29);
            this.rbScrabble.TabIndex = 1;
            this.rbScrabble.TabStop = true;
            this.rbScrabble.Text = "Scrabble";
            this.rbScrabble.UseVisualStyleBackColor = true;
            // 
            // rbRhyme
            // 
            this.rbRhyme.AutoSize = true;
            this.rbRhyme.Location = new System.Drawing.Point(14, 38);
            this.rbRhyme.Margin = new System.Windows.Forms.Padding(6);
            this.rbRhyme.Name = "rbRhyme";
            this.rbRhyme.Size = new System.Drawing.Size(110, 29);
            this.rbRhyme.TabIndex = 0;
            this.rbRhyme.TabStop = true;
            this.rbRhyme.Text = "Rhyme";
            this.rbRhyme.UseVisualStyleBackColor = true;
            // 
            // lbWordSearch
            // 
            this.lbWordSearch.FormattingEnabled = true;
            this.lbWordSearch.ItemHeight = 25;
            this.lbWordSearch.Location = new System.Drawing.Point(548, 177);
            this.lbWordSearch.Margin = new System.Windows.Forms.Padding(6);
            this.lbWordSearch.Name = "lbWordSearch";
            this.lbWordSearch.Size = new System.Drawing.Size(236, 429);
            this.lbWordSearch.TabIndex = 6;
            // 
            // btnFill2
            // 
            this.btnFill2.Location = new System.Drawing.Point(548, 121);
            this.btnFill2.Margin = new System.Windows.Forms.Padding(6);
            this.btnFill2.Name = "btnFill2";
            this.btnFill2.Size = new System.Drawing.Size(110, 44);
            this.btnFill2.TabIndex = 7;
            this.btnFill2.Text = "Fill";
            this.btnFill2.UseVisualStyleBackColor = true;
            this.btnFill2.Click += new System.EventHandler(this.btnFill2_Click);
            // 
            // btnClear2
            // 
            this.btnClear2.Location = new System.Drawing.Point(670, 121);
            this.btnClear2.Margin = new System.Windows.Forms.Padding(6);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(118, 44);
            this.btnClear2.TabIndex = 8;
            this.btnClear2.Text = "Clear";
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(291, 106);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(114, 25);
            this.start.TabIndex = 9;
            this.start.Text = "Start Word";
            // 
            // tbEnd
            // 
            this.tbEnd.Location = new System.Drawing.Point(292, 134);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(146, 31);
            this.tbEnd.TabIndex = 10;
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.Location = new System.Drawing.Point(291, 172);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(107, 25);
            this.end.TabIndex = 11;
            this.end.Text = "End Word";
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(292, 200);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(100, 31);
            this.tbMax.TabIndex = 12;
            // 
            // maxLength
            // 
            this.maxLength.AutoSize = true;
            this.maxLength.Location = new System.Drawing.Point(287, 234);
            this.maxLength.Name = "maxLength";
            this.maxLength.Size = new System.Drawing.Size(125, 25);
            this.maxLength.TabIndex = 13;
            this.maxLength.Text = "Max Length";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 654);
            this.Controls.Add(this.maxLength);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.end);
            this.Controls.Add(this.tbEnd);
            this.Controls.Add(this.start);
            this.Controls.Add(this.btnClear2);
            this.Controls.Add(this.btnFill2);
            this.Controls.Add(this.lbWordSearch);
            this.Controls.Add(this.gbWordSearch);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.lbWords);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Word Search";
            this.gbWordSearch.ResumeLayout(false);
            this.gbWordSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbWords;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox gbWordSearch;
        private System.Windows.Forms.RadioButton rbMorphWord;
        private System.Windows.Forms.RadioButton rbScrabble;
        private System.Windows.Forms.RadioButton rbRhyme;
        private System.Windows.Forms.ListBox lbWordSearch;
        private System.Windows.Forms.Button btnFill2;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.RadioButton rbMorphChain;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.TextBox tbEnd;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.Label maxLength;
    }
}

