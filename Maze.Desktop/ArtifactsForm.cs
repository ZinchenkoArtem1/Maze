using Maze.Model;
using Maze.Service;
using Maze.Service.Impl;

namespace Maze.Desktop
{
    public partial class ArtifactsForm : Form
    {
        private readonly MenuForm menuForm;
        private readonly Level level;
        private readonly IArtifactService artifactService;

        public ArtifactsForm(MenuForm menuForm, Level level)
        {
            this.menuForm = menuForm;
            this.level = level;
            this.artifactService = new ArtifactService();
            InitializeComponent();
        }

        private void ArtifactsForm_Load(object sender, EventArgs e)
        {
            ArtifactsLbx.DataSource = artifactService.GetAll();
            RefreshArtifactCellLb();
        }

        //ToDo: add check that cell x and y less that level size
        private void CreateArtifactBtn_Click(object sender, EventArgs e)
        {
            ArtifactCell artifactCell = new()
            {
                Artifact = (Artifact)ArtifactsLbx.SelectedItem,
                Cell = new Cell
                {
                    X = int.Parse(WeightTxb.Text),
                    Y = int.Parse(HeightTxb.Text)
                }
            };
            level.ArtifactCells.Add(artifactCell);
            RefreshArtifactCellLb();
            Clear();
        }

        private void ArtifactCellsLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArtifactCell artifactCell = (ArtifactCell) ArtifactCellslLbx.SelectedItem;
            if (artifactCell != null)
            {
                ArtifactsLbx.SelectedItem = artifactCell.Artifact;
                HeightTxb.Text = artifactCell.Cell.Y.ToString();
                WeightTxb.Text = artifactCell.Cell.X.ToString();
            }
        }

        private void RemoveArtifactBtn_Click(object sender, EventArgs e)
        {
            level.ArtifactCells.Remove((ArtifactCell) ArtifactCellslLbx.SelectedItem);
            RefreshArtifactCellLb();
            Clear();
        }

        //ToDo: add check that cell x and y less that level size
        private void UpdateArtifactBtn_Click(object sender, EventArgs e)
        {
            ArtifactCell artifactCell = (ArtifactCell) ArtifactCellslLbx.SelectedItem;
            artifactCell.Artifact = (Artifact) ArtifactsLbx.SelectedItem;
            artifactCell.Cell.X = int.Parse(WeightTxb.Text);
            artifactCell.Cell.Y = int.Parse(HeightTxb.Text);
            RefreshArtifactCellLb();
            Clear();
        }

        private void RefreshArtifactCellLb()
        {
            ArtifactCellslLbx.DataSource = null;
            ArtifactCellslLbx.DataSource = level.ArtifactCells;
        }

        private void Clear()
        {
            ArtifactsLbx.SelectedItem = null;
            ArtifactCellslLbx.SelectedItem = null;
            HeightTxb.Clear();
            WeightTxb.Clear();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            menuForm.Show();
        }
    }
}
