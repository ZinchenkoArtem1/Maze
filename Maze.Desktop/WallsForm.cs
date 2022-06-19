using Maze.Desktop.Util;
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
        private readonly string levelId;
        private readonly IWallService wallService;

        public WallsForm(MenuForm menuForm, string levelId)
        {
            InitializeComponent();
            this.menuForm = menuForm;
            this.levelId = levelId;
            this.wallService = new WallService();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            menuForm.Show();
        }

        private void WallsForm_Load(object sender, EventArgs e)
        {
            RefreshWallsLbx();
            Clear();
        }

        private void Clear()
        {
            IsDangerCbx.Checked = false;
            ColorTxb.Clear();
            HeightTxb.Clear();
            WeightTxb.Clear();
            WallsLbx.SelectedItem = null;
        }

        private void RefreshWallsLbx()
        {
            WallsLbx.DataSource = null;
            WallsLbx.DataSource = wallService.GetAllByLevelId(levelId);
        }

        private void CreateWallBtn_Click(object sender, EventArgs e)
        {
            Wall wall = new()
            {
                Color = TextBoxCheckUtil.ValidateStringTextBox(ColorTxb.Text),
                X = TextBoxCheckUtil.ValidateIntTextBox(WeightTxb.Text),
                Y = TextBoxCheckUtil.ValidateIntTextBox(HeightTxb.Text),
                IsDanger = IsDangerCbx.Checked
            };

            wallService.Create(wall, levelId);

            RefreshWallsLbx();
            Clear();
        }

        private void WallsLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Wall selectedWall = (Wall)WallsLbx.SelectedItem;

            if (selectedWall != null)
            {
                ColorTxb.Text = selectedWall.Color;
                HeightTxb.Text = selectedWall.Y.ToString();
                WeightTxb.Text = selectedWall.X.ToString();
                IsDangerCbx.Checked = selectedWall.IsDanger;
            }
        }

        private void RemoveWallBtn_Click(object sender, EventArgs e)
        {
            Wall selectedWall = (Wall)WallsLbx.SelectedItem;

            if (selectedWall == null)
            {
                throw new ArgumentException("You must select wall");
            }

            wallService.Delete(selectedWall, levelId);

            RefreshWallsLbx();
            Clear();
        }

        private void UpdateWallBtn_Click(object sender, EventArgs e)
        {
            Wall selectedWall = (Wall)WallsLbx.SelectedItem;

            if (selectedWall == null)
            {
                throw new ArgumentException("You must select wall");
            }

            Wall wall = new()
            {
                Id = selectedWall.Id,
                Color = TextBoxCheckUtil.ValidateStringTextBox(ColorTxb.Text),
                X = TextBoxCheckUtil.ValidateIntTextBox(WeightTxb.Text),
                Y = TextBoxCheckUtil.ValidateIntTextBox(HeightTxb.Text),
                IsDanger = IsDangerCbx.Checked
            };

            wallService.Update(wall, levelId);

            RefreshWallsLbx();
            Clear();
        }
    }
}
