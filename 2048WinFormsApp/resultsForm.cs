namespace _2048WinFormsApp
{
    public partial class resultsForm : Form
    {
        public resultsForm()
        {
            InitializeComponent();
            var row = 1;
            mainForm.gameResultStorage.GetAll().OrderByDescending(x => x.Result).ToList().ForEach(result =>
                                        resultsDataGridView.Rows.Add(row++, result.User.Name, result.Result));
        }

        private void resultsOkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
