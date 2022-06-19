using Maze.Desktop.Util;
using Maze.Entity;
using Maze.Service;
using Maze.Service.Impl;

namespace Maze.Desktop
{
    public partial class DoorsForm : Form
    {
        private readonly MenuForm menuForm;
        private readonly string levelId;
        private readonly IDoorService doorService;

        public DoorsForm(MenuForm menuForm, string levelId)
        {
            InitializeComponent();
            this.menuForm = menuForm;
            this.levelId = levelId;
            this.doorService = new DoorService();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            menuForm.Show();
        }

        private void DoorsForm_Load(object sender, EventArgs e)
        {
            RefreshDoorsLbx();
            Clear();
        }

        private void Clear()
        {
            IsOpenCbx.Checked = false;
            ColorTxb.Clear();
            HeightTxb.Clear();
            WeightTxb.Clear();
            DoorsLbx.SelectedItem = null;
        }

        private void RefreshDoorsLbx()
        {
            DoorsLbx.DataSource = null;
            DoorsLbx.DataSource = doorService.GetAllByLevelId(levelId);
        }

        private void CreateDoorBtn_Click(object sender, EventArgs e)
        {
            Door door = new()
            {
                Color = TextBoxCheckUtil.ValidateStringTextBox(ColorTxb.Text),
                X = TextBoxCheckUtil.ValidateIntTextBox(WeightTxb.Text),
                Y = TextBoxCheckUtil.ValidateIntTextBox(HeightTxb.Text),
                IsOpen = IsOpenCbx.Checked
            };

            doorService.Create(door, levelId);

            RefreshDoorsLbx();
            Clear();
        }

        private void DoorsLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Door selectedDoor = (Door) DoorsLbx.SelectedItem;

            if (selectedDoor != null)
            {
                ColorTxb.Text = selectedDoor.Color;
                HeightTxb.Text = selectedDoor.Y.ToString();
                WeightTxb.Text = selectedDoor.X.ToString();
                IsOpenCbx.Checked = selectedDoor.IsOpen;
            }
        }

        private void RemoveDoorBtn_Click(object sender, EventArgs e)
        {
            Door selectedDoor = (Door)DoorsLbx.SelectedItem;

            if (selectedDoor == null)
            {
                throw new ArgumentException("You must select door");
            }
            
            doorService.Delete(selectedDoor, levelId);

            RefreshDoorsLbx();
            Clear();
        }

        private void UpdateDoorBtn_Click(object sender, EventArgs e)
        {
            Door selectedDoor = (Door)DoorsLbx.SelectedItem;

            if (selectedDoor == null)
            {
                throw new ArgumentException("You must select door");
            }

            Door door = new()
            {
                Id = selectedDoor.Id,
                Color = TextBoxCheckUtil.ValidateStringTextBox(ColorTxb.Text),
                X = TextBoxCheckUtil.ValidateIntTextBox(WeightTxb.Text),
                Y = TextBoxCheckUtil.ValidateIntTextBox(HeightTxb.Text),
                IsOpen = IsOpenCbx.Checked
            };

            doorService.Update(door, levelId);

            RefreshDoorsLbx();
            Clear();
        }
    }
}
