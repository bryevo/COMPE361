namespace PA6
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.populateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evolutionParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateRandomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creatureColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateRandomStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItem1
            // 
            this.menuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.populateToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.evolutionParametersToolStripMenuItem,
            this.generateRandomToolStripMenuItem,
            this.generateRandomStateToolStripMenuItem});
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Size = new System.Drawing.Size(61, 22);
            this.menuItem1.Text = "Options";
            // 
            // populateToolStripMenuItem
            // 
            this.populateToolStripMenuItem.Name = "populateToolStripMenuItem";
            this.populateToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.populateToolStripMenuItem.Text = "Populate";
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.pauseToolStripMenuItem.Text = "Start";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.StartMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.resetToolStripMenuItem.Text = "Clear";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.clear_Grid);
            // 
            // evolutionParametersToolStripMenuItem
            // 
            this.evolutionParametersToolStripMenuItem.Name = "evolutionParametersToolStripMenuItem";
            this.evolutionParametersToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.evolutionParametersToolStripMenuItem.Text = "Evolution Parameters";
            this.evolutionParametersToolStripMenuItem.Click += new System.EventHandler(this.evolutionParametersToolStripMenuItem_Click);
            // 
            // generateRandomToolStripMenuItem
            // 
            this.generateRandomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorToolStripMenuItem,
            this.creatureColorToolStripMenuItem,
            this.gridColorToolStripMenuItem});
            this.generateRandomToolStripMenuItem.Name = "generateRandomToolStripMenuItem";
            this.generateRandomToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.generateRandomToolStripMenuItem.Text = "Color";
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background Color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // creatureColorToolStripMenuItem
            // 
            this.creatureColorToolStripMenuItem.Name = "creatureColorToolStripMenuItem";
            this.creatureColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.creatureColorToolStripMenuItem.Text = "Creature Color";
            this.creatureColorToolStripMenuItem.Click += new System.EventHandler(this.creatureColorToolStripMenuItem_Click);
            // 
            // gridColorToolStripMenuItem
            // 
            this.gridColorToolStripMenuItem.Name = "gridColorToolStripMenuItem";
            this.gridColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.gridColorToolStripMenuItem.Text = "Grid Color";
            this.gridColorToolStripMenuItem.Click += new System.EventHandler(this.gridColorToolStripMenuItem_Click);
            // 
            // generateRandomStateToolStripMenuItem
            // 
            this.generateRandomStateToolStripMenuItem.Name = "generateRandomStateToolStripMenuItem";
            this.generateRandomStateToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.generateRandomStateToolStripMenuItem.Text = "Generate Random State";
            this.generateRandomStateToolStripMenuItem.Click += new System.EventHandler(this.generateRandomStateToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(87, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 454);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItem1;
        private System.Windows.Forms.ToolStripMenuItem populateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem evolutionParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateRandomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creatureColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateRandomStateToolStripMenuItem;
    }
}

