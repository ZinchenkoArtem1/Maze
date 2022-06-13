using Maze.Entity;
using Maze.Service;
using Maze.Service.Impl;

namespace Maze.Desktop
{
    public partial class MenuForm : Form
    {
        private readonly ILevelService levelService;

        public MenuForm()
        {
            levelService = new LevelService();
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            RefreshLevelsLbx();
            Clear();
        }

        private void CreateLevelBtn_Click(object sender, EventArgs e)
        {
            
            levelService.Create(new Level
            {
                Name = ValidateStringTextBox(NameTxb.Text),
                Color = ValidateStringTextBox(ColorTxb.Text),
                Complexity = ValidateStringTextBox(ComplexityTxb.Text),
                Height = ValidateIntTextBox(HeightTxb.Text),
                Weight = ValidateIntTextBox(WeightTxb.Text),
                Points = ValidateIntTextBox(PointsTxb.Text)
            });

            RefreshLevelsLbx();
            Clear();
        }

        private void LevelsLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Level level = (Level) LevelsLbx.SelectedItem;
            if (level != null)
            {
                NameTxb.Text = level.Name;
                ColorTxb.Text = level.Color;
                ComplexityTxb.Text = level.Complexity;
                HeightTxb.Text = level.Height.ToString();
                WeightTxb.Text = level.Weight.ToString();
                PointsTxb.Text = level.Points.ToString();
            }
        }

        private void RemoveLevelBtn_Click(object sender, EventArgs e)
        {
            levelService.Delete((Level) LevelsLbx.SelectedItem);

            RefreshLevelsLbx();
            Clear();
        }

        private void UpdateLevelBtn_Click(object sender, EventArgs e)
        {
            Level level = (Level) LevelsLbx.SelectedItem;
            level.Name = ValidateStringTextBox(NameTxb.Text);
            level.Color = ValidateStringTextBox(ColorTxb.Text);
            level.Complexity = ValidateStringTextBox(ComplexityTxb.Text);
            level.Height = ValidateIntTextBox(HeightTxb.Text);
            level.Weight = ValidateIntTextBox(WeightTxb.Text);
            level.Points = ValidateIntTextBox(PointsTxb.Text);

            levelService.Update(level);

            RefreshLevelsLbx();
            Clear();
        }

        private void ArtifactsBtn_Click(object sender, EventArgs e)
        {
            ArtifactsForm artifactsForm = new ArtifactsForm(this, (Level) LevelsLbx.SelectedItem);
            artifactsForm.Show();
            Hide();
        }

        private void Clear()
        {
            NameTxb.Clear();
            ColorTxb.Clear();
            ComplexityTxb.Clear();
            HeightTxb.Clear();
            WeightTxb.Clear();
            PointsTxb.Clear();
            LevelsLbx.SelectedItem = null;
        }

        private void RefreshLevelsLbx()
        {
            LevelsLbx.DataSource = null;
            LevelsLbx.DataSource = levelService.GetAll();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DoorsBtn_Click(object sender, EventArgs e)
        {
            DoorsForm doorsForm = new DoorsForm(this, (Level) LevelsLbx.SelectedItem);
            doorsForm.Show();
            this.Hide();
        }

        private void WallsBtn_Click(object sender, EventArgs e)
        {
            WallsForm wallsForm = new WallsForm(this, (Level)LevelsLbx.SelectedItem);
            wallsForm.Show();
            this.Hide();
        }

        private string ValidateStringTextBox(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new Exception("Text box must be filled");
            }
            else
            {
                return text;
            }
        }

        private int ValidateIntTextBox(string text)
        {
            int retNum;

            bool isNum = int.TryParse(text, out retNum);

            if (!isNum)
            {
                throw new Exception("Text box must be filled by int");
            }

            return retNum;
        }
    }
}
