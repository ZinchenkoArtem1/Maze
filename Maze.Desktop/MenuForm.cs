using Maze.Desktop.Util;
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
                Name = TextBoxCheckUtil.ValidateStringTextBox(NameTxb.Text),
                Color = TextBoxCheckUtil.ValidateStringTextBox(ColorTxb.Text),
                Complexity = TextBoxCheckUtil.ValidateStringTextBox(ComplexityTxb.Text),
                Height = TextBoxCheckUtil.ValidateIntTextBox(HeightTxb.Text),
                Weight = TextBoxCheckUtil.ValidateIntTextBox(WeightTxb.Text),
                Points = TextBoxCheckUtil.ValidateIntTextBox(PointsTxb.Text)
            });

            RefreshLevelsLbx();
            Clear();
        }

        private void LevelsLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Level selectedLevel = (Level) LevelsLbx.SelectedItem;

            if (selectedLevel != null)
            {
                NameTxb.Text = selectedLevel.Name;
                ColorTxb.Text = selectedLevel.Color;
                ComplexityTxb.Text = selectedLevel.Complexity;
                HeightTxb.Text = selectedLevel.Height.ToString();
                WeightTxb.Text = selectedLevel.Weight.ToString();
                PointsTxb.Text = selectedLevel.Points.ToString();
            }
        }

        private void RemoveLevelBtn_Click(object sender, EventArgs e)
        {
            Level selectedLevel = (Level)LevelsLbx.SelectedItem;

            if (selectedLevel == null)
            {
                throw new ArgumentException("You must select level");
            }

            levelService.Delete(selectedLevel);

            RefreshLevelsLbx();
            Clear();
        }

        private void UpdateLevelBtn_Click(object sender, EventArgs e)
        {
            Level selectedLevel = (Level)LevelsLbx.SelectedItem;

            if (selectedLevel == null)
            {
                throw new ArgumentException("You must select level");
            }

            Level level = new()
            {
                Id = selectedLevel.Id,
                Name = TextBoxCheckUtil.ValidateStringTextBox(NameTxb.Text),
                Color = TextBoxCheckUtil.ValidateStringTextBox(ColorTxb.Text),
                Complexity = TextBoxCheckUtil.ValidateStringTextBox(ComplexityTxb.Text),
                Height = TextBoxCheckUtil.ValidateIntTextBox(HeightTxb.Text),
                Weight = TextBoxCheckUtil.ValidateIntTextBox(WeightTxb.Text),
                Points = TextBoxCheckUtil.ValidateIntTextBox(PointsTxb.Text),
            };

            levelService.Update(level);

            RefreshLevelsLbx();
            Clear();
        }

        private void ArtifactsBtn_Click(object sender, EventArgs e)
        {
            Level selectedLevel = (Level)LevelsLbx.SelectedItem;

            if (selectedLevel == null)
            {
                throw new ArgumentException("You must select level");
            }

            ArtifactsForm artifactsForm = new ArtifactsForm(this, selectedLevel.Id);
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
            Level selectedLevel = (Level)LevelsLbx.SelectedItem;

            if (selectedLevel == null)
            {
                throw new ArgumentException("You must select level");
            }

            DoorsForm doorsForm = new DoorsForm(this, selectedLevel.Id);
            doorsForm.Show();
            this.Hide();
        }

        private void WallsBtn_Click(object sender, EventArgs e)
        {
            Level selectedLevel = (Level)LevelsLbx.SelectedItem;

            if (selectedLevel == null)
            {
                throw new ArgumentException("You must select level");
            }

            WallsForm wallsForm = new WallsForm(this, selectedLevel.Id);
            wallsForm.Show();
            this.Hide();
        }
    }
}
