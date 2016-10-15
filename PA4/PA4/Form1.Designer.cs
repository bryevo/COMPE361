namespace PA4
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
            this.start = new System.Windows.Forms.Label();
            this.tbEnd = new System.Windows.Forms.TextBox();
            this.end = new System.Windows.Forms.Label();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.maxLength = new System.Windows.Forms.Label();
            this.gbWordSearch = new System.Windows.Forms.GroupBox();
            this.rbMorphChain = new System.Windows.Forms.RadioButton();
            this.rbMorphWord = new System.Windows.Forms.RadioButton();
            this.rbScrabble = new System.Windows.Forms.RadioButton();
            this.rbRhyme = new System.Windows.Forms.RadioButton();
            this.lbWordSearch = new System.Windows.Forms.ListBox();
            this.btnFill2 = new System.Windows.Forms.Button();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.labelHelp = new System.Windows.Forms.LinkLabel();
            this.labelError = new System.Windows.Forms.LinkLabel();
            this.dictionary = new System.Windows.Forms.Label();
            this.gbWordSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbWords
            // 
            this.lbWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbWords.FormattingEnabled = true;
            this.lbWords.Location = new System.Drawing.Point(10, 53);
            this.lbWords.Margin = new System.Windows.Forms.Padding(2);
            this.lbWords.Name = "lbWords";
            this.lbWords.Size = new System.Drawing.Size(133, 264);
            this.lbWords.TabIndex = 0;
            this.lbWords.DoubleClick += new System.EventHandler(this.lbWords_DoubleClick);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(10, 10);
            this.btnFill.Margin = new System.Windows.Forms.Padding(2);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(56, 19);
            this.btnFill.TabIndex = 1;
            this.btnFill.Text = "Fill";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(86, 10);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 19);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.Location = new System.Drawing.Point(146, 37);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(190, 20);
            this.txtUser.TabIndex = 3;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Location = new System.Drawing.Point(340, 36);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(53, 21);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(143, 59);
            this.start.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(58, 13);
            this.start.TabIndex = 9;
            this.start.Text = "Start Word";
            // 
            // tbEnd
            // 
            this.tbEnd.Location = new System.Drawing.Point(147, 92);
            this.tbEnd.Margin = new System.Windows.Forms.Padding(2);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(75, 20);
            this.tbEnd.TabIndex = 10;
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.Location = new System.Drawing.Point(143, 114);
            this.end.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(55, 13);
            this.end.TabIndex = 11;
            this.end.Text = "End Word";
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(147, 142);
            this.tbMax.Margin = new System.Windows.Forms.Padding(2);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(52, 20);
            this.tbMax.TabIndex = 12;
            // 
            // maxLength
            // 
            this.maxLength.AutoSize = true;
            this.maxLength.Location = new System.Drawing.Point(144, 164);
            this.maxLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxLength.Name = "maxLength";
            this.maxLength.Size = new System.Drawing.Size(63, 13);
            this.maxLength.TabIndex = 13;
            this.maxLength.Text = "Max Length";
            // 
            // gbWordSearch
            // 
            this.gbWordSearch.Controls.Add(this.rbMorphChain);
            this.gbWordSearch.Controls.Add(this.rbMorphWord);
            this.gbWordSearch.Controls.Add(this.rbScrabble);
            this.gbWordSearch.Controls.Add(this.rbRhyme);
            this.gbWordSearch.Location = new System.Drawing.Point(146, 201);
            this.gbWordSearch.Name = "gbWordSearch";
            this.gbWordSearch.Size = new System.Drawing.Size(122, 116);
            this.gbWordSearch.TabIndex = 5;
            this.gbWordSearch.TabStop = false;
            this.gbWordSearch.Text = "Options:";
            // 
            // rbMorphChain
            // 
            this.rbMorphChain.AutoSize = true;
            this.rbMorphChain.Location = new System.Drawing.Point(7, 82);
            this.rbMorphChain.Margin = new System.Windows.Forms.Padding(2);
            this.rbMorphChain.Name = "rbMorphChain";
            this.rbMorphChain.Size = new System.Drawing.Size(85, 17);
            this.rbMorphChain.TabIndex = 3;
            this.rbMorphChain.TabStop = true;
            this.rbMorphChain.Text = "Morph Chain";
            this.rbMorphChain.UseVisualStyleBackColor = true;
            // 
            // rbMorphWord
            // 
            this.rbMorphWord.AutoSize = true;
            this.rbMorphWord.Location = new System.Drawing.Point(7, 62);
            this.rbMorphWord.Name = "rbMorphWord";
            this.rbMorphWord.Size = new System.Drawing.Size(84, 17);
            this.rbMorphWord.TabIndex = 2;
            this.rbMorphWord.TabStop = true;
            this.rbMorphWord.Text = "Morph Word";
            this.rbMorphWord.UseVisualStyleBackColor = true;
            // 
            // rbScrabble
            // 
            this.rbScrabble.AutoSize = true;
            this.rbScrabble.Location = new System.Drawing.Point(7, 41);
            this.rbScrabble.Name = "rbScrabble";
            this.rbScrabble.Size = new System.Drawing.Size(67, 17);
            this.rbScrabble.TabIndex = 1;
            this.rbScrabble.TabStop = true;
            this.rbScrabble.Text = "Scrabble";
            this.rbScrabble.UseVisualStyleBackColor = true;
            // 
            // rbRhyme
            // 
            this.rbRhyme.AutoSize = true;
            this.rbRhyme.Location = new System.Drawing.Point(7, 20);
            this.rbRhyme.Name = "rbRhyme";
            this.rbRhyme.Size = new System.Drawing.Size(58, 17);
            this.rbRhyme.TabIndex = 0;
            this.rbRhyme.TabStop = true;
            this.rbRhyme.Text = "Rhyme";
            this.rbRhyme.UseVisualStyleBackColor = true;
            // 
            // lbWordSearch
            // 
            this.lbWordSearch.FormattingEnabled = true;
            this.lbWordSearch.Location = new System.Drawing.Point(274, 92);
            this.lbWordSearch.Name = "lbWordSearch";
            this.lbWordSearch.Size = new System.Drawing.Size(120, 225);
            this.lbWordSearch.TabIndex = 6;
            // 
            // btnFill2
            // 
            this.btnFill2.Location = new System.Drawing.Point(274, 63);
            this.btnFill2.Name = "btnFill2";
            this.btnFill2.Size = new System.Drawing.Size(55, 23);
            this.btnFill2.TabIndex = 7;
            this.btnFill2.Text = "Fill";
            this.btnFill2.UseVisualStyleBackColor = true;
            this.btnFill2.Click += new System.EventHandler(this.btnFill2_Click);
            // 
            // btnClear2
            // 
            this.btnClear2.Location = new System.Drawing.Point(335, 63);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(59, 23);
            this.btnClear2.TabIndex = 8;
            this.btnClear2.Text = "Clear";
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // labelHelp
            // 
            this.labelHelp.ActiveLinkColor = System.Drawing.Color.Red;
            this.labelHelp.AutoSize = true;
            this.labelHelp.LinkColor = System.Drawing.Color.Black;
            this.labelHelp.Location = new System.Drawing.Point(364, 9);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(29, 13);
            this.labelHelp.TabIndex = 14;
            this.labelHelp.TabStop = true;
            this.labelHelp.Text = "Help";
            this.labelHelp.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelHelp.Click += new System.EventHandler(this.labelHelp_Click);
            // 
            // labelError
            // 
            this.labelError.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelError.AutoSize = true;
            this.labelError.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelError.DisabledLinkColor = System.Drawing.Color.Gray;
            this.labelError.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.labelError.LinkColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(146, 13);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(75, 13);
            this.labelError.TabIndex = 15;
            this.labelError.TabStop = true;
            this.labelError.Text = "Error Message";
            this.labelError.Visible = false;
            // 
            // dictionary
            // 
            this.dictionary.AutoSize = true;
            this.dictionary.Location = new System.Drawing.Point(51, 36);
            this.dictionary.Name = "dictionary";
            this.dictionary.Size = new System.Drawing.Size(54, 13);
            this.dictionary.TabIndex = 16;
            this.dictionary.Text = "Dictionary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 339);
            this.Controls.Add(this.dictionary);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelHelp);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.TextBox tbEnd;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.Label maxLength;
        private System.Windows.Forms.GroupBox gbWordSearch;
        private System.Windows.Forms.RadioButton rbMorphWord;
        private System.Windows.Forms.RadioButton rbScrabble;
        private System.Windows.Forms.RadioButton rbRhyme;
        private System.Windows.Forms.ListBox lbWordSearch;
        private System.Windows.Forms.Button btnFill2;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.RadioButton rbMorphChain;
        private System.Windows.Forms.LinkLabel labelHelp;
        private System.Windows.Forms.LinkLabel labelError;
        private System.Windows.Forms.Label dictionary;

    }
}

