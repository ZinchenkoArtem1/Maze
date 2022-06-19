using Maze.Desktop.Util;
using Maze.Entity;
using Maze.Service;
using Maze.Service.Impl;

namespace Maze.Desktop
{
    public partial class ArtifactsForm : Form
    {
        private readonly MenuForm menuForm;
        private readonly string levelId;
        private readonly IArtifactTypeService artifactTypeService;
        private readonly IArtifactService artifactService;
        private readonly ILevelService levelService;

        public ArtifactsForm(MenuForm menuForm, string levelId)
        {
            this.menuForm = menuForm;
            this.levelId = levelId;
            this.artifactTypeService = new ArtifactTypeService();
            this.artifactService = new ArtifactService();
            this.levelService = new LevelService();
            InitializeComponent();
        }

        private void ArtifactsForm_Load(object sender, EventArgs e)
        {
            ArtifactTypesLbx.DataSource = artifactTypeService.GetAll();
            RefreshArtifactsLbx();
            Clear();
        }

        private void CreateArtifactBtn_Click(object sender, EventArgs e)
        {
            ArtifactType selectedArtifactType = (ArtifactType) ArtifactTypesLbx.SelectedItem;

            if (selectedArtifactType == null)
            {
                throw new ArgumentException("You must select artifact type");
            }

            Artifact artifact = new()
            {
                ArtifactType = selectedArtifactType,                
                X = TextBoxCheckUtil.ValidateIntTextBox(WeightTxb.Text),
                Y = TextBoxCheckUtil.ValidateIntTextBox(HeightTxb.Text)
            };

            artifactService.Create(artifact, levelId);

            RefreshArtifactsLbx();
            Clear();
        }

        private void ArtifactsLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Artifact selectedArtifact = (Artifact) ArtifactsLbx.SelectedItem;

            if (selectedArtifact != null)
            {
                ArtifactTypesLbx.SelectedItem = selectedArtifact.ArtifactType;
                HeightTxb.Text = selectedArtifact.Y.ToString();
                WeightTxb.Text = selectedArtifact.X.ToString();
            }
        }

        private void RemoveArtifactBtn_Click(object sender, EventArgs e)
        {
            Artifact selectedArtifact = (Artifact)ArtifactsLbx.SelectedItem;

            if (selectedArtifact == null)
            {
                throw new ArgumentException("You must select artifact");
            }

            artifactService.Delete(selectedArtifact, levelId);

            RefreshArtifactsLbx();
            Clear();
        }

        private void UpdateArtifactBtn_Click(object sender, EventArgs e)
        {
            Artifact selectedArtifact = (Artifact)ArtifactsLbx.SelectedItem;
            ArtifactType selectedArtifactType = (ArtifactType)ArtifactTypesLbx.SelectedItem;

            if (selectedArtifact == null)
            {
                throw new ArgumentException("You must select artifact");
            }

            if (selectedArtifactType == null)
            {
                throw new ArgumentException("You must select artifact type");
            }

            Artifact artifact = new()
            {
                Id = selectedArtifact.Id,
                ArtifactType = selectedArtifactType,
                X = TextBoxCheckUtil.ValidateIntTextBox(WeightTxb.Text),
                Y = TextBoxCheckUtil.ValidateIntTextBox(HeightTxb.Text)
            };

            artifactService.Update(artifact, levelId);

            RefreshArtifactsLbx();
            Clear();
        }

        private void RefreshArtifactsLbx()
        {
            ArtifactsLbx.DataSource = null;
            ArtifactsLbx.DataSource = artifactService.GetAllByLevelId(levelId);
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
    }
}
