namespace _2048WinFormsApp
{
    partial class resultsForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            resultsOkButton = new Button();
            resultsLabel = new Label();
            resultsDataGridView = new DataGridView();
            numberColumn = new DataGridViewTextBoxColumn();
            userNameColumn = new DataGridViewTextBoxColumn();
            resultColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // resultsOkButton
            // 
            resultsOkButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            resultsOkButton.Location = new Point(223, 343);
            resultsOkButton.Name = "resultsOkButton";
            resultsOkButton.Size = new Size(135, 67);
            resultsOkButton.TabIndex = 0;
            resultsOkButton.Text = "OK";
            resultsOkButton.UseVisualStyleBackColor = true;
            resultsOkButton.Click += resultsOkButton_Click;
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            resultsLabel.Location = new Point(208, 24);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(171, 38);
            resultsLabel.TabIndex = 1;
            resultsLabel.Text = "Результаты";
            // 
            // resultsDataGridView
            // 
            resultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsDataGridView.Columns.AddRange(new DataGridViewColumn[] { numberColumn, userNameColumn, resultColumn });
            resultsDataGridView.Location = new Point(31, 90);
            resultsDataGridView.Name = "resultsDataGridView";
            resultsDataGridView.RowHeadersWidth = 62;
            resultsDataGridView.RowTemplate.Height = 33;
            resultsDataGridView.Size = new Size(512, 225);
            resultsDataGridView.TabIndex = 2;
            // 
            // numberColumn
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            numberColumn.DefaultCellStyle = dataGridViewCellStyle4;
            numberColumn.HeaderText = "№";
            numberColumn.MinimumWidth = 8;
            numberColumn.Name = "numberColumn";
            numberColumn.Width = 50;
            // 
            // userNameColumn
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            userNameColumn.DefaultCellStyle = dataGridViewCellStyle5;
            userNameColumn.HeaderText = "Имя";
            userNameColumn.MinimumWidth = 8;
            userNameColumn.Name = "userNameColumn";
            userNameColumn.Width = 250;
            // 
            // resultColumn
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            resultColumn.DefaultCellStyle = dataGridViewCellStyle6;
            resultColumn.HeaderText = "Результат";
            resultColumn.MinimumWidth = 8;
            resultColumn.Name = "resultColumn";
            // 
            // resultsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 435);
            Controls.Add(resultsDataGridView);
            Controls.Add(resultsLabel);
            Controls.Add(resultsOkButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "resultsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "2048";
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button resultsOkButton;
        private Label resultsLabel;
        private DataGridView resultsDataGridView;
        private DataGridViewTextBoxColumn numberColumn;
        private DataGridViewTextBoxColumn userNameColumn;
        private DataGridViewTextBoxColumn resultColumn;
    }
}