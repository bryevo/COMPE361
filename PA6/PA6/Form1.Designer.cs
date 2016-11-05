using System.Drawing;

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
            this.components = new System.ComponentModel.Container();
            this.generationTimer = new System.Windows.Forms.Timer(this.components);
            this.generationLabel = new System.Windows.Forms.Label();
            this.numEvoRate = new System.Windows.Forms.NumericUpDown();
            this.menuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.evolutionParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateRandomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creatureColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.singleStepEvolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evolutionRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generateRandomStateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numEvoRate)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // generationTimer
            // 
            this.generationTimer.Interval = 1000;
            this.generationTimer.Tick += new System.EventHandler(this.generationTimer_Tick);
            // 
            // generationLabel
            // 
            this.generationLabel.AutoSize = true;
            this.generationLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.generationLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generationLabel.Location = new System.Drawing.Point(649, 3);
            this.generationLabel.Name = "generationLabel";
            this.generationLabel.Size = new System.Drawing.Size(113, 15);
            this.generationLabel.TabIndex = 2;
            this.generationLabel.Text = "Generation Count: 0";
            // 
            // numEvoRate
            // 
            this.numEvoRate.Location = new System.Drawing.Point(523, 2);
            this.numEvoRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEvoRate.Name = "numEvoRate";
            this.numEvoRate.Size = new System.Drawing.Size(120, 20);
            this.numEvoRate.TabIndex = 5;
            this.numEvoRate.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // menuItem1
            // 
            this.menuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evolutionParametersToolStripMenuItem,
            this.generateRandomToolStripMenuItem,
            this.toggleGridToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Size = new System.Drawing.Size(61, 22);
            this.menuItem1.Text = "Options";
            // 
            // evolutionParametersToolStripMenuItem
            // 
            this.evolutionParametersToolStripMenuItem.Name = "evolutionParametersToolStripMenuItem";
            this.evolutionParametersToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
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
            this.generateRandomToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
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
            // toggleGridToolStripMenuItem
            // 
            this.toggleGridToolStripMenuItem.Checked = true;
            this.toggleGridToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleGridToolStripMenuItem.Name = "toggleGridToolStripMenuItem";
            this.toggleGridToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.toggleGridToolStripMenuItem.Text = "Toggle Grid: ON";
            this.toggleGridToolStripMenuItem.Click += new System.EventHandler(this.toggleGridToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.resetToolStripMenuItem.Text = "Clear Grid";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.clear_Grid);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(41, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem1
            // 
            this.pauseToolStripMenuItem1.Name = "pauseToolStripMenuItem1";
            this.pauseToolStripMenuItem1.Size = new System.Drawing.Size(50, 22);
            this.pauseToolStripMenuItem1.Text = "Pause";
            this.pauseToolStripMenuItem1.Click += new System.EventHandler(this.pauseToolStripMenuItem1_Click);
            // 
            // singleStepEvolutionToolStripMenuItem
            // 
            this.singleStepEvolutionToolStripMenuItem.Name = "singleStepEvolutionToolStripMenuItem";
            this.singleStepEvolutionToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.singleStepEvolutionToolStripMenuItem.Text = "Single Step Evolution";
            this.singleStepEvolutionToolStripMenuItem.Click += new System.EventHandler(this.singleStepEvolutionToolStripMenuItem_Click);
            // 
            // evolutionRateToolStripMenuItem
            // 
            this.evolutionRateToolStripMenuItem.Name = "evolutionRateToolStripMenuItem";
            this.evolutionRateToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.evolutionRateToolStripMenuItem.Text = "Evolution Rate";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem1,
            this.generateRandomStateToolStripMenuItem1,
            this.playToolStripMenuItem,
            this.pauseToolStripMenuItem1,
            this.singleStepEvolutionToolStripMenuItem,
            this.evolutionRateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generateRandomStateToolStripMenuItem1
            // 
            this.generateRandomStateToolStripMenuItem1.Name = "generateRandomStateToolStripMenuItem1";
            this.generateRandomStateToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.generateRandomStateToolStripMenuItem1.Text = "Generate Random State";
            this.generateRandomStateToolStripMenuItem1.Click += new System.EventHandler(this.generateRandomStateToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.numEvoRate);
            this.Controls.Add(this.generationLabel);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numEvoRate)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer generationTimer;
        private System.Windows.Forms.Label generationLabel;
        private System.Windows.Forms.NumericUpDown numEvoRate;
        private System.Windows.Forms.ToolStripMenuItem menuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evolutionParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateRandomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creatureColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem singleStepEvolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evolutionRateToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generateRandomStateToolStripMenuItem1;
    }
}

