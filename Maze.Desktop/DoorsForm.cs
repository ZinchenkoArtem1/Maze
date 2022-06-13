using Maze.Entity;
using Maze.Service;
using Maze.Service.Impl;

namespace Maze.Desktop
{
    public partial class DoorsForm : Form
    {
        private readonly MenuForm menuForm;
        private readonly Level level;
        private readonly IDoorService doorService;

        public DoorsForm(MenuForm menuForm, Level level)
        {
            InitializeComponent();
            this.menuForm = menuForm;
            this.level = level;
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
            DoorsLbx.DataSource = level.Doors;
        }

        private void CreateDoorBtn_Click(object sender, EventArgs e)
        {
            Door door = new()
            {
                Color = ValidateStringTextBox(ColorTxb.Text),
                X = ValidateIntTextBox(WeightTxb.Text),
                Y = ValidateIntTextBox(HeightTxb.Text),
                IsOpen = IsOpenCbx.Checked,
                Level = this.level
            };

            doorService.Create(door);

            RefreshDoorsLbx();
            Clear();
        }

        private void DoorsLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Door door = (Door) DoorsLbx.SelectedItem;
            if (door != null)
            {
                ColorTxb.Text = door.Color;
                HeightTxb.Text = door.Y.ToString();
                WeightTxb.Text = door.X.ToString();
                IsOpenCbx.Checked = door.IsOpen;
            }
        }

        private void RemoveDoorBtn_Click(object sender, EventArgs e)
        {
            Door door = (Door)DoorsLbx.SelectedItem;
            
            level.Doors.Remove(door);
            doorService.Delete(door);

            RefreshDoorsLbx();
            Clear();
        }

        private void UpdateDoorBtn_Click(object sender, EventArgs e)
        {
            Door door = (Door) DoorsLbx.SelectedItem;

            door.Color = ValidateStringTextBox(ColorTxb.Text);
            door.X = ValidateIntTextBox(WeightTxb.Text);
            door.Y = ValidateIntTextBox(HeightTxb.Text);
            door.IsOpen = IsOpenCbx.Checked;

            doorService.Update(door);

            RefreshDoorsLbx();
            Clear();
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
