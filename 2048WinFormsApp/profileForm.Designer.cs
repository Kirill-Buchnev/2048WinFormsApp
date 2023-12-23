namespace _2048WinFormsApp
{
    partial class profileForm
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
            profileLabel = new Label();
            profileTextBox = new TextBox();
            profileCancelButton = new Button();
            profileOkButton = new Button();
            SuspendLayout();
            // 
            // profileLabel
            // 
            profileLabel.AutoSize = true;
            profileLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            profileLabel.Location = new Point(29, 38);
            profileLabel.Name = "profileLabel";
            profileLabel.Size = new Size(303, 38);
            profileLabel.TabIndex = 0;
            profileLabel.Text = "Введите имя игрока:";
            // 
            // profileTextBox
            // 
            profileTextBox.Location = new Point(46, 111);
            profileTextBox.Name = "profileTextBox";
            profileTextBox.Size = new Size(257, 31);
            profileTextBox.TabIndex = 2;
            // 
            // profileCancelButton
            // 
            profileCancelButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            profileCancelButton.Location = new Point(46, 181);
            profileCancelButton.Name = "profileCancelButton";
            profileCancelButton.Size = new Size(101, 56);
            profileCancelButton.TabIndex = 3;
            profileCancelButton.Text = "Отмена";
            profileCancelButton.UseVisualStyleBackColor = true;
            profileCancelButton.Click += profileCancelButton_Click;
            // 
            // profileOkButton
            // 
            profileOkButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            profileOkButton.Location = new Point(193, 181);
            profileOkButton.Name = "profileOkButton";
            profileOkButton.Size = new Size(110, 56);
            profileOkButton.TabIndex = 4;
            profileOkButton.Text = "ОК";
            profileOkButton.UseVisualStyleBackColor = true;
            profileOkButton.Click += profileOkButton_Click;
            // 
            // profileForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 278);
            Controls.Add(profileOkButton);
            Controls.Add(profileCancelButton);
            Controls.Add(profileTextBox);
            Controls.Add(profileLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "profileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "2048";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label profileLabel;
        private TextBox profileTextBox;
        private Button profileCancelButton;
        private Button profileOkButton;
    }
}