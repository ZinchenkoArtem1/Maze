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
            Level level = new()
            {
                Id = ((Level)LevelsLbx.SelectedItem).Id,
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
            ArtifactsForm artifactsForm = new ArtifactsForm(this, ((Level) LevelsLbx.SelectedItem).Id);
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
            DoorsForm doorsForm = new DoorsForm(this, ((Level) LevelsLbx.SelectedItem).Id);
            doorsForm.Show();
            this.Hide();
        }

        private void WallsBtn_Click(object sender, EventArgs e)
        {
            WallsForm wallsForm = new WallsForm(this, ((Level)LevelsLbx.SelectedItem).Id);
            wallsForm.Show();
            this.Hide();
        }
    }
}
