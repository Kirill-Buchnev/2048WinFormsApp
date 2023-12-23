namespace _2048WinFormsApp
{
    partial class gameRulesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameRulesForm));
            gameRulesButton = new Button();
            gameRulesHeadingLabel = new Label();
            gameRulesTextLabel1 = new Label();
            gameRulesTextLabel2 = new Label();
            gameRulesTextLabel3 = new Label();
            gameRulesTextLabel4 = new Label();
            gameRulesTextLabel5 = new Label();
            SuspendLayout();
            // 
            // gameRulesButton
            // 
            gameRulesButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gameRulesButton.Location = new Point(398, 477);
            gameRulesButton.Name = "gameRulesButton";
            gameRulesButton.Size = new Size(143, 62);
            gameRulesButton.TabIndex = 0;
            gameRulesButton.Text = "OK";
            gameRulesButton.UseVisualStyleBackColor = true;
            gameRulesButton.Click += gameRulesButton_Click_1;
            // 
            // gameRulesHeadingLabel
            // 
            gameRulesHeadingLabel.AutoSize = true;
            gameRulesHeadingLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            gameRulesHeadingLabel.Location = new Point(300, 31);
            gameRulesHeadingLabel.Name = "gameRulesHeadingLabel";
            gameRulesHeadingLabel.Size = new Size(293, 38);
            gameRulesHeadingLabel.TabIndex = 1;
            gameRulesHeadingLabel.Text = "Правила игры 2048.";
            // 
            // gameRulesTextLabel1
            // 
            gameRulesTextLabel1.Location = new Point(20, 98);
            gameRulesTextLabel1.Name = "gameRulesTextLabel1";
            gameRulesTextLabel1.Size = new Size(899, 31);
            gameRulesTextLabel1.TabIndex = 2;
            gameRulesTextLabel1.Text = "1. В каждом раунде появляется плитка номинала «2» (с вероятностью 75 %) или «4» (с вероятностью 25 %).";
            // 
            // gameRulesTextLabel2
            // 
            gameRulesTextLabel2.Location = new Point(20, 131);
            gameRulesTextLabel2.Name = "gameRulesTextLabel2";
            gameRulesTextLabel2.Size = new Size(899, 127);
            gameRulesTextLabel2.TabIndex = 2;
            gameRulesTextLabel2.Text = resources.GetString("gameRulesTextLabel2.Text");
            // 
            // gameRulesTextLabel3
            // 
            gameRulesTextLabel3.Location = new Point(20, 267);
            gameRulesTextLabel3.Name = "gameRulesTextLabel3";
            gameRulesTextLabel3.Size = new Size(899, 107);
            gameRulesTextLabel3.TabIndex = 2;
            gameRulesTextLabel3.Text = resources.GetString("gameRulesTextLabel3.Text");
            // 
            // gameRulesTextLabel4
            // 
            gameRulesTextLabel4.Location = new Point(20, 382);
            gameRulesTextLabel4.Name = "gameRulesTextLabel4";
            gameRulesTextLabel4.Size = new Size(899, 31);
            gameRulesTextLabel4.TabIndex = 2;
            gameRulesTextLabel4.Text = "4. За каждое соединение игровые очки увеличиваются на номинал получившейся плитки.";
            // 
            // gameRulesTextLabel5
            // 
            gameRulesTextLabel5.Location = new Point(20, 420);
            gameRulesTextLabel5.Name = "gameRulesTextLabel5";
            gameRulesTextLabel5.Size = new Size(899, 31);
            gameRulesTextLabel5.TabIndex = 2;
            gameRulesTextLabel5.Text = "5. Игра заканчивается поражением, если после очередного хода невозможно совершить действие.";
            // 
            // gameRulesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 567);
            Controls.Add(gameRulesTextLabel2);
            Controls.Add(gameRulesTextLabel3);
            Controls.Add(gameRulesTextLabel5);
            Controls.Add(gameRulesTextLabel4);
            Controls.Add(gameRulesTextLabel1);
            Controls.Add(gameRulesHeadingLabel);
            Controls.Add(gameRulesButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "gameRulesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "2048";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button gameRulesButton;
        private Label gameRulesHeadingLabel;
        private Label gameRulesTextLabel1;
        private Label gameRulesTextLabel2;
        private Label gameRulesTextLabel3;
        private Label gameRulesTextLabel4;
        private Label gameRulesTextLabel5;
    }
}