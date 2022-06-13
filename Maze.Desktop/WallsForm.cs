using Maze.Entity;
using Maze.Service;
using Maze.Service.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze.Desktop
{
    public partial class WallsForm : Form
    {
        private readonly MenuForm menuForm;
        private readonly Level level;
        private readonly IWallService wallService;

        public WallsForm(MenuForm menuForm, Level level)
        {
            InitializeComponent();
            this.menuForm = menuForm;
            this.level = level;
            this.wallService = new WallService();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            menuForm.Show();
        }

        private void WallsForm_Load(object sender, EventArgs e)
        {
            Clear();
            RefreshDoorsLbx();
        }

        private void Clear()
        {
            IsDangerCbx.Checked = false;
            ColorTxb.Clear();
            HeightTxb.Clear();
            WeightTxb.Clear();
            WallsLbx.SelectedItem = null;
        }

        private void RefreshDoorsLbx()
        {
            WallsLbx.DataSource = null;
            WallsLbx.DataSource = level.Walls;
        }

        private void CreateWallBtn_Click(object sender, EventArgs e)
        {
            Wall wall = new()
            {
                Color = ValidateStringTextBox(ColorTxb.Text),
                X = ValidateIntTextBox(WeightTxb.Text),
                Y = ValidateIntTextBox(HeightTxb.Text),
                IsDanger = IsDangerCbx.Checked,
                Level = this.level
            };

            wallService.Create(wall);

            RefreshDoorsLbx();
            Clear();
        }

        private void WallsLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Wall wall = (Wall)WallsLbx.SelectedItem;
            if (wall != null)
            {
                ColorTxb.Text = wall.Color;
                HeightTxb.Text = wall.Y.ToString();
                WeightTxb.Text = wall.X.ToString();
                IsDangerCbx.Checked = wall.IsDanger;
            }
        }

        private void RemoveWallBtn_Click(object sender, EventArgs e)
        {
            Wall wall = (Wall)WallsLbx.SelectedItem;

            level.Walls.Remove(wall);
            wallService.Delete(wall);

            RefreshDoorsLbx();
            Clear();
        }

        private void UpdateWallBtn_Click(object sender, EventArgs e)
        {
            Wall wall = (Wall)WallsLbx.SelectedItem;

            wall.Color = ValidateStringTextBox(ColorTxb.Text);
            wall.X = ValidateIntTextBox(WeightTxb.Text);
            wall.Y = ValidateIntTextBox(HeightTxb.Text);
            wall.IsDanger = IsDangerCbx.Checked;

            wallService.Update(wall);

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
