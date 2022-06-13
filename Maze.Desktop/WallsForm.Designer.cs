namespace Maze.Desktop
{
    partial class WallsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CloseBtn = new System.Windows.Forms.Button();
            this.WallsLbx = new System.Windows.Forms.ListBox();
            this.WeightLbl = new System.Windows.Forms.Label();
            this.HeightLbl = new System.Windows.Forms.Label();
            this.WeightTxb = new System.Windows.Forms.TextBox();
            this.HeightTxb = new System.Windows.Forms.TextBox();
            this.UpdateWallBtn = new System.Windows.Forms.Button();
            this.RemoveWallBtn = new System.Windows.Forms.Button();
            this.CreateWallBtn = new System.Windows.Forms.Button();
            this.ColorLbl = new System.Windows.Forms.Label();
            this.ColorTxb = new System.Windows.Forms.TextBox();
            this.IsDangerLbl = new System.Windows.Forms.Label();
            this.IsDangerCbx = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(874, -2);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(94, 29);
            this.CloseBtn.TabIndex = 58;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // WallsLbx
            // 
            this.WallsLbx.FormattingEnabled = true;
            this.WallsLbx.ItemHeight = 20;
            this.WallsLbx.Location = new System.Drawing.Point(603, 48);
            this.WallsLbx.Name = "WallsLbx";
            this.WallsLbx.Size = new System.Drawing.Size(238, 264);
            this.WallsLbx.TabIndex = 57;
            this.WallsLbx.SelectedIndexChanged += new System.EventHandler(this.WallsLbx_SelectedIndexChanged);
            // 
            // WeightLbl
            // 
            this.WeightLbl.Location = new System.Drawing.Point(457, 189);
            this.WeightLbl.Name = "WeightLbl";
            this.WeightLbl.Size = new System.Drawing.Size(100, 19);
            this.WeightLbl.TabIndex = 46;
            this.WeightLbl.Text = "Weight";
            // 
            // HeightLbl
            // 
            this.HeightLbl.Location = new System.Drawing.Point(457, 120);
            this.HeightLbl.Name = "HeightLbl";
            this.HeightLbl.Size = new System.Drawing.Size(100, 23);
            this.HeightLbl.TabIndex = 47;
            this.HeightLbl.Text = "Height";
            // 
            // WeightTxb
            // 
            this.WeightTxb.Location = new System.Drawing.Point(283, 186);
            this.WeightTxb.Name = "WeightTxb";
            this.WeightTxb.Size = new System.Drawing.Size(100, 27);
            this.WeightTxb.TabIndex = 48;
            // 
            // HeightTxb
            // 
            this.HeightTxb.Location = new System.Drawing.Point(283, 116);
            this.HeightTxb.Name = "HeightTxb";
            this.HeightTxb.Size = new System.Drawing.Size(100, 27);
            this.HeightTxb.TabIndex = 49;
            // 
            // UpdateWallBtn
            // 
            this.UpdateWallBtn.Location = new System.Drawing.Point(12, 170);
            this.UpdateWallBtn.Name = "UpdateWallBtn";
            this.UpdateWallBtn.Size = new System.Drawing.Size(189, 38);
            this.UpdateWallBtn.TabIndex = 50;
            this.UpdateWallBtn.Text = "Update wall";
            this.UpdateWallBtn.Click += new System.EventHandler(this.UpdateWallBtn_Click);
            // 
            // RemoveWallBtn
            // 
            this.RemoveWallBtn.Location = new System.Drawing.Point(12, 272);
            this.RemoveWallBtn.Name = "RemoveWallBtn";
            this.RemoveWallBtn.Size = new System.Drawing.Size(189, 40);
            this.RemoveWallBtn.TabIndex = 51;
            this.RemoveWallBtn.Text = "Remove wall";
            this.RemoveWallBtn.Click += new System.EventHandler(this.RemoveWallBtn_Click);
            // 
            // CreateWallBtn
            // 
            this.CreateWallBtn.Location = new System.Drawing.Point(12, 57);
            this.CreateWallBtn.Name = "CreateWallBtn";
            this.CreateWallBtn.Size = new System.Drawing.Size(189, 46);
            this.CreateWallBtn.TabIndex = 52;
            this.CreateWallBtn.Text = "Create wall";
            this.CreateWallBtn.Click += new System.EventHandler(this.CreateWallBtn_Click);
            // 
            // ColorLbl
            // 
            this.ColorLbl.Location = new System.Drawing.Point(457, 57);
            this.ColorLbl.Name = "ColorLbl";
            this.ColorLbl.Size = new System.Drawing.Size(100, 23);
            this.ColorLbl.TabIndex = 53;
            this.ColorLbl.Text = "Color";
            // 
            // ColorTxb
            // 
            this.ColorTxb.Location = new System.Drawing.Point(283, 57);
            this.ColorTxb.Name = "ColorTxb";
            this.ColorTxb.Size = new System.Drawing.Size(100, 27);
            this.ColorTxb.TabIndex = 54;
            // 
            // IsDangerLbl
            // 
            this.IsDangerLbl.Location = new System.Drawing.Point(457, 289);
            this.IsDangerLbl.Name = "IsDangerLbl";
            this.IsDangerLbl.Size = new System.Drawing.Size(100, 23);
            this.IsDangerLbl.TabIndex = 55;
            this.IsDangerLbl.Text = "Is danger?";
            // 
            // IsDangerCbx
            // 
            this.IsDangerCbx.Location = new System.Drawing.Point(283, 288);
            this.IsDangerCbx.Name = "IsDangerCbx";
            this.IsDangerCbx.Size = new System.Drawing.Size(104, 24);
            this.IsDangerCbx.TabIndex = 56;
            this.IsDangerCbx.Text = "true";
            // 
            // WallsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 411);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.WallsLbx);
            this.Controls.Add(this.WeightLbl);
            this.Controls.Add(this.HeightLbl);
            this.Controls.Add(this.WeightTxb);
            this.Controls.Add(this.HeightTxb);
            this.Controls.Add(this.UpdateWallBtn);
            this.Controls.Add(this.RemoveWallBtn);
            this.Controls.Add(this.CreateWallBtn);
            this.Controls.Add(this.ColorLbl);
            this.Controls.Add(this.ColorTxb);
            this.Controls.Add(this.IsDangerLbl);
            this.Controls.Add(this.IsDangerCbx);
            this.Name = "WallsForm";
            this.Text = "WallsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CloseBtn;
        private ListBox WallsLbx;
        private Label WeightLbl;
        private Label HeightLbl;
        private TextBox WeightTxb;
        private TextBox HeightTxb;
        private Button UpdateWallBtn;
        private Button RemoveWallBtn;
        private Button CreateWallBtn;
        private Label ColorLbl;
        private TextBox ColorTxb;
        private Label IsDangerLbl;
        private CheckBox IsDangerCbx;
    }
}