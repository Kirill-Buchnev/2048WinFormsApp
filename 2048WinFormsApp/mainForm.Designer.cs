namespace _2048WinFormsApp
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            scoreLabel = new Label();
            scoreHeadingLabel = new Label();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            fieldSizeToolStripMenuItem = new ToolStripMenuItem();
            x4ToolStripMenuItem = new ToolStripMenuItem();
            x5ToolStripMenuItem = new ToolStripMenuItem();
            x6ToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            resultsToolStripMenuItem = new ToolStripMenuItem();
            rulesToolStripMenuItem = new ToolStripMenuItem();
            restartToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            userLabel = new Label();
            recordLabel = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(70, 45);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(22, 25);
            scoreLabel.TabIndex = 0;
            scoreLabel.Text = "0";
            // 
            // scoreHeadingLabel
            // 
            scoreHeadingLabel.AutoSize = true;
            scoreHeadingLabel.Location = new Point(15, 45);
            scoreHeadingLabel.Name = "scoreHeadingLabel";
            scoreHeadingLabel.Size = new Size(53, 25);
            scoreHeadingLabel.TabIndex = 1;
            scoreHeadingLabel.Text = "Счет:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(358, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fieldSizeToolStripMenuItem, profileToolStripMenuItem, resultsToolStripMenuItem, rulesToolStripMenuItem, restartToolStripMenuItem, exitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(78, 29);
            menuToolStripMenuItem.Text = "Меню";
            // 
            // fieldSizeToolStripMenuItem
            // 
            fieldSizeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { x4ToolStripMenuItem, x5ToolStripMenuItem, x6ToolStripMenuItem });
            fieldSizeToolStripMenuItem.Name = "fieldSizeToolStripMenuItem";
            fieldSizeToolStripMenuItem.Size = new Size(270, 34);
            fieldSizeToolStripMenuItem.Text = "Размер поля...";
            // 
            // x4ToolStripMenuItem
            // 
            x4ToolStripMenuItem.Name = "x4ToolStripMenuItem";
            x4ToolStripMenuItem.Size = new Size(142, 34);
            x4ToolStripMenuItem.Text = "4x4";
            x4ToolStripMenuItem.Click += x4ToolStripMenuItem_Click;
            // 
            // x5ToolStripMenuItem
            // 
            x5ToolStripMenuItem.Name = "x5ToolStripMenuItem";
            x5ToolStripMenuItem.Size = new Size(142, 34);
            x5ToolStripMenuItem.Text = "5x5";
            x5ToolStripMenuItem.Click += x5ToolStripMenuItem_Click;
            // 
            // x6ToolStripMenuItem
            // 
            x6ToolStripMenuItem.Name = "x6ToolStripMenuItem";
            x6ToolStripMenuItem.Size = new Size(142, 34);
            x6ToolStripMenuItem.Text = "6x6";
            x6ToolStripMenuItem.Click += x6ToolStripMenuItem_Click;
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(270, 34);
            profileToolStripMenuItem.Text = "Профиль...";
            profileToolStripMenuItem.Click += profileToolStripMenuItem_Click;
            // 
            // resultsToolStripMenuItem
            // 
            resultsToolStripMenuItem.Name = "resultsToolStripMenuItem";
            resultsToolStripMenuItem.Size = new Size(270, 34);
            resultsToolStripMenuItem.Text = "Результаты...";
            resultsToolStripMenuItem.Click += resultsToolStripMenuItem_Click;
            // 
            // rulesToolStripMenuItem
            // 
            rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            rulesToolStripMenuItem.Size = new Size(270, 34);
            rulesToolStripMenuItem.Text = "Правила...";
            rulesToolStripMenuItem.Click += rulesToolStripMenuItem_Click;
            // 
            // restartToolStripMenuItem
            // 
            restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            restartToolStripMenuItem.Size = new Size(270, 34);
            restartToolStripMenuItem.Text = "Рестарт...";
            restartToolStripMenuItem.Click += restartToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(270, 34);
            exitToolStripMenuItem.Text = "Выход...";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new Point(177, 3);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(67, 25);
            userLabel.TabIndex = 3;
            userLabel.Text = "Игрок:";
            // 
            // recordLabel
            // 
            recordLabel.AutoSize = true;
            recordLabel.Location = new Point(250, 45);
            recordLabel.Name = "recordLabel";
            recordLabel.Size = new Size(91, 25);
            recordLabel.TabIndex = 4;
            recordLabel.Text = "Рекорд: 0";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 421);
            Controls.Add(recordLabel);
            Controls.Add(userLabel);
            Controls.Add(scoreHeadingLabel);
            Controls.Add(scoreLabel);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "2048";
            Load += mainForm_Load;
            KeyDown += mainForm_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label scoreLabel;
        private Label scoreHeadingLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem rulesToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label userLabel;
        private ToolStripMenuItem profileToolStripMenuItem;
        private Label recordLabel;
        private ToolStripMenuItem resultsToolStripMenuItem;
        private ToolStripMenuItem fieldSizeToolStripMenuItem;
        private ToolStripMenuItem x4ToolStripMenuItem;
        private ToolStripMenuItem x5ToolStripMenuItem;
        private ToolStripMenuItem x6ToolStripMenuItem;
    }
}