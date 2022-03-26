namespace OopPreLab1
{
    partial class Form2
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
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterTwoDimensionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.shapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roundShapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(302, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.CheckOnClick = true;
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.screenToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.difficultyToolStripMenuItem,
            this.shapeToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // difficultyToolStripMenuItem
            // 
            this.difficultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.hardToolStripMenuItem,
            this.customToolStripMenuItem});
            this.difficultyToolStripMenuItem.Name = "difficultyToolStripMenuItem";
            this.difficultyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.difficultyToolStripMenuItem.Text = "Difficulty";
            this.difficultyToolStripMenuItem.Click += new System.EventHandler(this.difficultyToolStripMenuItem_Click);
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.CheckOnClick = true;
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.easyToolStripMenuItem.Text = "Easy";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.CheckOnClick = true;
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.DoubleClickEnabled = true;
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hardToolStripMenuItem.Text = "Hard";
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterTwoDimensionToolStripMenuItem,
            this.toolStripTextBox1,
            this.toolStripSeparator1,
            this.toolStripTextBox2});
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customToolStripMenuItem.Text = "Custom";
            // 
            // enterTwoDimensionToolStripMenuItem
            // 
            this.enterTwoDimensionToolStripMenuItem.Name = "enterTwoDimensionToolStripMenuItem";
            this.enterTwoDimensionToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.enterTwoDimensionToolStripMenuItem.Text = "Enter two dimensions";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            // 
            // shapeToolStripMenuItem
            // 
            this.shapeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.squareToolStripMenuItem,
            this.triangleToolStripMenuItem,
            this.roundShapesToolStripMenuItem});
            this.shapeToolStripMenuItem.Name = "shapeToolStripMenuItem";
            this.shapeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shapeToolStripMenuItem.Text = "Shape";
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.CheckOnClick = true;
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.squareToolStripMenuItem.Text = "Square";
            // 
            // triangleToolStripMenuItem
            // 
            this.triangleToolStripMenuItem.CheckOnClick = true;
            this.triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            this.triangleToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.triangleToolStripMenuItem.Text = "Triangle";
            // 
            // roundShapesToolStripMenuItem
            // 
            this.roundShapesToolStripMenuItem.CheckOnClick = true;
            this.roundShapesToolStripMenuItem.Name = "roundShapesToolStripMenuItem";
            this.roundShapesToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.roundShapesToolStripMenuItem.Text = "Round shapes";
            // 
            // screenToolStripMenuItem
            // 
            this.screenToolStripMenuItem.Name = "screenToolStripMenuItem";
            this.screenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.screenToolStripMenuItem.Text = "Screen";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 248);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem startToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem gameToolStripMenuItem;
        private ToolStripMenuItem difficultyToolStripMenuItem;
        private ToolStripMenuItem easyToolStripMenuItem;
        private ToolStripMenuItem normalToolStripMenuItem;
        private ToolStripMenuItem hardToolStripMenuItem;
        private ToolStripMenuItem customToolStripMenuItem;
        private ToolStripMenuItem enterTwoDimensionToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripMenuItem shapeToolStripMenuItem;
        private ToolStripMenuItem screenToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem squareToolStripMenuItem;
        private ToolStripMenuItem triangleToolStripMenuItem;
        private ToolStripMenuItem roundShapesToolStripMenuItem;
    }
}