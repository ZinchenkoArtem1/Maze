using Maze.Model;
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
        }

        private void CreateLevelBtn_Click(object sender, EventArgs e)
        {
            levelService.Create(new Level
            {
                Name = NameTxb.Text,
                Color = ColorTxb.Text,
                Complexity = ComplexityTxb.Text,
                Height = int.Parse(HeightTxb.Text),
                Weight = int.Parse(WeightTxb.Text),
                Points = int.Parse(PointsTxb.Text)
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
            level.Name = NameTxb.Text;
            level.Color = ColorTxb.Text;
            level.Complexity = ComplexityTxb.Text;
            level.Height = int.Parse(HeightTxb.Text);
            level.Weight = int.Parse(WeightTxb.Text);
            level.Points = int.Parse(PointsTxb.Text);
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

        private void DecorationsBtn_Click(object sender, EventArgs e)
        {
            DecorationsForm decorationsForm = new DecorationsForm(this, (Level) LevelsLbx.SelectedItem);
            decorationsForm.Show();
            this.Hide();
        }
    }
}
