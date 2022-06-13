using Maze.Entity;
using Maze.Service;
using Maze.Service.Impl;

namespace Maze.Desktop
{
    public partial class ArtifactsForm : Form
    {
        private readonly MenuForm menuForm;
        private readonly Level level;
        private readonly IArtifactTypeService artifactTypeService;
        private readonly IArtifactService artifactService;  

        public ArtifactsForm(MenuForm menuForm, Level level)
        {
            this.menuForm = menuForm;
            this.level = level;
            this.artifactTypeService = new ArtifactTypeService();
            this.artifactService = new ArtifactService();
            InitializeComponent();
        }

        private void ArtifactsForm_Load(object sender, EventArgs e)
        {
            ArtifactTypesLbx.DataSource = artifactTypeService.GetAll();
            RefreshArtifactsLbx();
            Clear();
        }

        //ToDo: add check that cell x and y less that level size
        private void CreateArtifactBtn_Click(object sender, EventArgs e)
        {
            Artifact artifact = new()
            {
                ArtifactType = (ArtifactType)ArtifactTypesLbx.SelectedItem,                
                X = ValidateIntTextBox(WeightTxb.Text),
                Y = ValidateIntTextBox(HeightTxb.Text),
                Level = level
            };

            artifactService.Create(artifact);

            RefreshArtifactsLbx();
            Clear();
        }

        private void ArtifactsLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Artifact artifact = (Artifact) ArtifactsLbx.SelectedItem;
            if (artifact != null)
            {
                ArtifactTypesLbx.SelectedItem = artifact.ArtifactType;
                HeightTxb.Text = artifact.Y.ToString();
                WeightTxb.Text = artifact.X.ToString();
            }
        }

        private void RemoveArtifactBtn_Click(object sender, EventArgs e)
        {
            Artifact artifact = (Artifact)ArtifactsLbx.SelectedItem;

            level.Artifacts.Remove(artifact);
            artifactService.Delete(artifact);

            RefreshArtifactsLbx();
            Clear();
        }

        //ToDo: add check that cell x and y less that level size
        private void UpdateArtifactBtn_Click(object sender, EventArgs e)
        {
            Artifact artifact = (Artifact) ArtifactsLbx.SelectedItem;

            artifact.ArtifactType = (ArtifactType) ArtifactTypesLbx.SelectedItem;
            artifact.X = ValidateIntTextBox(WeightTxb.Text);
            artifact.Y = ValidateIntTextBox(HeightTxb.Text);

            artifactService.Update(artifact);

            RefreshArtifactsLbx();
            Clear();
        }

        private void RefreshArtifactsLbx()
        {
            ArtifactsLbx.DataSource = null;
            ArtifactsLbx.DataSource = level.Artifacts;
        }

        private void Clear()
        {
            ArtifactTypesLbx.SelectedItem = null;
            ArtifactsLbx.SelectedItem = null;
            HeightTxb.Clear();
            WeightTxb.Clear();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            menuForm.Show();
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
