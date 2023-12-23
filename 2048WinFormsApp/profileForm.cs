using _2048ClassLibrary;

namespace _2048WinFormsApp
{
    public partial class profileForm : Form
    {
        public profileForm()
        {
            InitializeComponent();
        }

        private void profileOkButton_Click(object sender, EventArgs e)
        {
            mainForm.File.Write(profileTextBox.Text);
            this.Close();
        }

        private void profileCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
