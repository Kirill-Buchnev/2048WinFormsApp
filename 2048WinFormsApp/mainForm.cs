using _2048ClassLibrary;
using System;

namespace _2048WinFormsApp
{
    public partial class mainForm : Form
    {
        public static FileProvider File = new FileProvider("userName.json");
        private User user = new User("Undefined");
        public static GameResultStorage gameResultStorage = new GameResultStorage();
        public int mapSize = 4;
        private int record { get; set; }
        private bool gameOver;
        private Cell[,] labelsMap;
        private static Random random = new Random();
        private int score;
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            StartGame(mapSize);
        }

        private void StartGame(int mapSize)
        {
            score = 0;
            var widthWindowGap = 22;
            var lengthWindowGap = 54;
            var windowWidth = 2 * Cell.SmallIndent + mapSize * (Cell.SideLength + Cell.GapBetweenCells) - Cell.GapBetweenCells + widthWindowGap;
            var windowHeight = Cell.LargeIndent + Cell.SmallIndent + mapSize * (Cell.SideLength + Cell.GapBetweenCells) - Cell.GapBetweenCells + lengthWindowGap;
            this.Size = new Size(windowWidth, windowHeight);
            userLabel.Location = new Point(windowWidth - 190, 5);
            recordLabel.Location = new Point(windowWidth - 150, 45);
            GetUserName();
            InitMap();
            GenerateNumber();
            ShowScore();
        }
        private void ShowScore()
        {
            scoreLabel.Text = score.ToString();
            record = gameResultStorage.GetAll()?.OrderByDescending(x => x.Result).FirstOrDefault()?.Result ?? record;
            recordLabel.Text = $"Рекорд: {(record >= score ? record.ToString() : score.ToString())}";
        }

        private void InitMap()
        {
            labelsMap = new Cell[mapSize, mapSize];
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = new Cell(i, j);
                    Controls.Add(newLabel);
                    labelsMap[i, j] = newLabel;
                    newLabel.TextChanged += (sender, e) =>
                    {
                        if(newLabel.Text != string.Empty)
                        {
                            newLabel.BackColor = newLabel.CellColors[(int)Math.Log2(Convert.ToDouble(newLabel.Text)) - 1];
                        }
                        else
                        {
                            newLabel.BackColor = Color.Gray;
                        }
                    };
                }
            }
        }

        private void GenerateNumber()
        {
            var emptyCells = GetEmptyCells();
            var randomIndex = random.Next(emptyCells.Length);
            if (emptyCells.Length == 0) return;
            // random generation of 2 or 4
            emptyCells[randomIndex].Text = random.Next(101) <= 75 ? "2" : "4";
        }

        private Cell[] GetEmptyCells()
        {
            return ToLabelsList().Where(cell => cell.Text == string.Empty).ToArray();
        }

        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameOver) return;
            if (e.KeyCode == Keys.Right)
            {
                MoveNumbersRight();
                GenerateNumber();
            }
            if (e.KeyCode == Keys.Left)
            {
                MoveNumbersLeft();
                GenerateNumber();
            }
            if (e.KeyCode == Keys.Up)
            {
                MoveNumbersUp();
                GenerateNumber();
            }
            if (e.KeyCode == Keys.Down)
            {
                MoveNumbersDown();
                GenerateNumber();
            }
            var labelsList = ToLabelsList();
            var emptyCells = labelsList.Where(cell => cell.Text == string.Empty).ToArray();
            if (emptyCells.Length == 0 && labelsList.All(cell => !cellHasEqualNeighbour(cell)))
            {
                gameOver = true;
                ShowScore();
                SaveResults();
                MessageBox.Show("Game Over!");
                return;
            }
            ShowScore();
        }

        private void SaveResults()
        {
            var gameResult = new GameResult(user, Convert.ToInt32(scoreLabel.Text));
            gameResultStorage.Save(gameResult);
        }

        private void MoveNumbersRight()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveNumbersUp()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveNumbersLeft()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveNumbersDown()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private List<Cell> ToLabelsList()
        {
            var newList = new List<Cell>();
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    newList.Add(labelsMap[i, j]);
                }
            }
            return newList;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new gameRulesForm().ShowDialog();
            this.Show();
        }

        private void GetUserName()
        {
            var userName = File.Get();
            user = new User(userName != string.Empty ? userName : "Undefined");
            userLabel.Text = $"Игрок: {user.Name}";
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new profileForm().ShowDialog();
            GetUserName();
            this.Show();
        }

        private bool cellHasEqualNeighbour(Cell cell)
        {
            var labels = ToLabelsList();
            var cellUpText = labels.FirstOrDefault(other => other.Row == cell.Row - 1 && other.Column == cell.Column)?.Text ?? string.Empty;
            var cellDownText = labels.FirstOrDefault(other => other.Row == cell.Row + 1 && other.Column == cell.Column)?.Text ?? string.Empty;
            var cellLeftText = labels.FirstOrDefault(other => other.Column == cell.Column - 1 && other.Row == cell.Row)?.Text ?? string.Empty;
            var cellRightText = labels.FirstOrDefault(other => other.Column == cell.Column + 1 && other.Row == cell.Row)?.Text ?? string.Empty;
            return cellUpText == cell.Text || cellDownText == cell.Text || cellLeftText == cell.Text || cellRightText == cell.Text;
        }

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new resultsForm().ShowDialog();
            this.Show();
        }

        private void x4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mapSize = 4;
            this.Controls.Clear();
            InitializeComponent();
            StartGame(mapSize);
        }

        private void x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mapSize = 5;
            this.Controls.Clear();
            InitializeComponent();
            StartGame(mapSize);
        }

        private void x6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mapSize = 6;
            this.Controls.Clear();
            InitializeComponent();
            StartGame(mapSize);
        }
    }
}