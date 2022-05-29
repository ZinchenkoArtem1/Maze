using Maze.Model;
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
    public partial class DecorationsForm : Form
    {
        private readonly MenuForm menuForm;
        private readonly Level level;

        public DecorationsForm(MenuForm menuForm, Level level)
        {
            InitializeComponent();
            this.menuForm = menuForm;
            this.level = level;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            menuForm.Show();
        }

        private void DecorationsForm_Load(object sender, EventArgs e)
        {
            RefreshDecorationsLbx();
        }

        private void Clear()
        {
            DoorRb.Checked = false;
            WallRb.Checked = false;
            FirstPropTrueCbx.Checked = false;
            ColorTxb.Clear();
            HeightTxb.Clear();
            WeightTxb.Clear();
            FirstPropLbl.Text = "";
        }

        private void RefreshDecorationsLbx()
        {
            DecoratesLbx.DataSource = null;
            DecoratesLbx.DataSource = level.Decorations;
        }

        private void CreateDecorateBtn_Click(object sender, EventArgs e)
        {
            string color = ColorTxb.Text;
            Cell cell = new()
            {
                X = int.Parse(WeightTxb.Text),
                Y = int.Parse(HeightTxb.Text)
            };
            Decoration decoration;
            
            if (DoorRb.Checked)
            {
                decoration = new Door
                {
                    Color = color,
                    Cell = cell,
                    IsOpen = FirstPropTrueCbx.Checked
                };
            } else
            {
                decoration = new Wall
                {
                    Color = color,
                    Cell = cell,
                    IsDanger = FirstPropTrueCbx.Checked
                };
            }
            
            level.Decorations.Add(decoration);
            RefreshDecorationsLbx();
            Clear();
        }

        private void DecoratesLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Decoration decoration = (Decoration) DecoratesLbx.SelectedItem;
            if (decoration != null)
            {
                if (decoration is Door door)
                {
                    DoorRb.Checked = true;
                    FirstPropTrueCbx.Checked = door.IsOpen;
                }
                else
                {
                    WallRb.Checked = true;
                    FirstPropTrueCbx.Checked = ((Wall) decoration).IsDanger;
                }
                ColorTxb.Text = decoration.Color;
                HeightTxb.Text = decoration.Cell.Y.ToString();
                WeightTxb.Text = decoration.Cell.X.ToString();
            }
        }

        private void RemoveDecorateBtn_Click(object sender, EventArgs e)
        {
            level.Decorations.Remove((Decoration) DecoratesLbx.SelectedItem);
            RefreshDecorationsLbx();
            Clear();
        }

        private void UpdateDecorateBtn_Click(object sender, EventArgs e)
        {
            Decoration decoration = (Decoration) DecoratesLbx.SelectedItem;

            if (decoration is Door && !DoorRb.Checked || decoration is Wall && !WallRb.Checked)
            {
                throw new ArgumentException("We can't update decoration type");
            }

            decoration.Color = ColorTxb.Text;
            decoration.Cell.X = int.Parse(WeightTxb.Text);
            decoration.Cell.Y = int.Parse(HeightTxb.Text);
            if (decoration is Door door)
            {
                door.IsOpen = FirstPropTrueCbx.Checked;
            } else
            {
                ((Wall)decoration).IsDanger = FirstPropTrueCbx.Checked;
            }
            RefreshDecorationsLbx();
            Clear();
        }

        private void DoorRb_CheckedChanged(object sender, EventArgs e)
        {
            FirstPropLbl.Text = "is open?";
        }

        private void WallRb_CheckedChanged(object sender, EventArgs e)
        {
            FirstPropLbl.Text = "is danger?";
        }
    }
}
