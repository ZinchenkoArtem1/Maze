namespace Maze.Desktop
{
    partial class MenuForm
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
            this.CreateLevelBtn = new System.Windows.Forms.Button();
            this.NameTxb = new System.Windows.Forms.TextBox();
            this.LevelsLbx = new System.Windows.Forms.ListBox();
            this.RemoveLevelBtn = new System.Windows.Forms.Button();
            this.UpdateLevelBtn = new System.Windows.Forms.Button();
            this.ColorTxb = new System.Windows.Forms.TextBox();
            this.ComplexityTxb = new System.Windows.Forms.TextBox();
            this.HeightTxb = new System.Windows.Forms.TextBox();
            this.WeightTxb = new System.Windows.Forms.TextBox();
            this.PointsTxb = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.ColorLbl = new System.Windows.Forms.Label();
            this.ComplexityLbl = new System.Windows.Forms.Label();
            this.HeightLbl = new System.Windows.Forms.Label();
            this.WeightLbl = new System.Windows.Forms.Label();
            this.PointsLbl = new System.Windows.Forms.Label();
            this.DoorsBtn = new System.Windows.Forms.Button();
            this.ArtifactsBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.WallsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateLevelBtn
            // 
            this.CreateLevelBtn.Location = new System.Drawing.Point(34, 43);
            this.CreateLevelBtn.Name = "CreateLevelBtn";
            this.CreateLevelBtn.Size = new System.Drawing.Size(186, 50);
            this.CreateLevelBtn.TabIndex = 0;
            this.CreateLevelBtn.Text = "Create level";
            this.CreateLevelBtn.UseVisualStyleBackColor = true;
            this.CreateLevelBtn.Click += new System.EventHandler(this.CreateLevelBtn_Click);
            // 
            // NameTxb
            // 
            this.NameTxb.Location = new System.Drawing.Point(280, 43);
            this.NameTxb.Name = "NameTxb";
            this.NameTxb.Size = new System.Drawing.Size(125, 27);
            this.NameTxb.TabIndex = 1;
            // 
            // LevelsLbx
            // 
            this.LevelsLbx.FormattingEnabled = true;
            this.LevelsLbx.ItemHeight = 20;
            this.LevelsLbx.Location = new System.Drawing.Point(523, 43);
            this.LevelsLbx.Name = "LevelsLbx";
            this.LevelsLbx.Size = new System.Drawing.Size(310, 224);
            this.LevelsLbx.TabIndex = 2;
            this.LevelsLbx.SelectedIndexChanged += new System.EventHandler(this.LevelsLbx_SelectedIndexChanged);
            // 
            // RemoveLevelBtn
            // 
            this.RemoveLevelBtn.Location = new System.Drawing.Point(34, 160);
            this.RemoveLevelBtn.Name = "RemoveLevelBtn";
            this.RemoveLevelBtn.Size = new System.Drawing.Size(186, 50);
            this.RemoveLevelBtn.TabIndex = 3;
            this.RemoveLevelBtn.Text = "Remove level";
            this.RemoveLevelBtn.UseVisualStyleBackColor = true;
            this.RemoveLevelBtn.Click += new System.EventHandler(this.RemoveLevelBtn_Click);
            // 
            // UpdateLevelBtn
            // 
            this.UpdateLevelBtn.Location = new System.Drawing.Point(34, 259);
            this.UpdateLevelBtn.Name = "UpdateLevelBtn";
            this.UpdateLevelBtn.Size = new System.Drawing.Size(186, 50);
            this.UpdateLevelBtn.TabIndex = 4;
            this.UpdateLevelBtn.Text = "Update level";
            this.UpdateLevelBtn.UseVisualStyleBackColor = true;
            this.UpdateLevelBtn.Click += new System.EventHandler(this.UpdateLevelBtn_Click);
            // 
            // ColorTxb
            // 
            this.ColorTxb.Location = new System.Drawing.Point(280, 109);
            this.ColorTxb.Name = "ColorTxb";
            this.ColorTxb.Size = new System.Drawing.Size(125, 27);
            this.ColorTxb.TabIndex = 5;
            // 
            // ComplexityTxb
            // 
            this.ComplexityTxb.Location = new System.Drawing.Point(280, 168);
            this.ComplexityTxb.Name = "ComplexityTxb";
            this.ComplexityTxb.Size = new System.Drawing.Size(125, 27);
            this.ComplexityTxb.TabIndex = 6;
            // 
            // HeightTxb
            // 
            this.HeightTxb.Location = new System.Drawing.Point(280, 238);
            this.HeightTxb.Name = "HeightTxb";
            this.HeightTxb.Size = new System.Drawing.Size(125, 27);
            this.HeightTxb.TabIndex = 7;
            // 
            // WeightTxb
            // 
            this.WeightTxb.Location = new System.Drawing.Point(280, 294);
            this.WeightTxb.Name = "WeightTxb";
            this.WeightTxb.Size = new System.Drawing.Size(125, 27);
            this.WeightTxb.TabIndex = 8;
            // 
            // PointsTxb
            // 
            this.PointsTxb.Location = new System.Drawing.Point(280, 346);
            this.PointsTxb.Name = "PointsTxb";
            this.PointsTxb.Size = new System.Drawing.Size(125, 27);
            this.PointsTxb.TabIndex = 9;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(426, 50);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(46, 20);
            this.NameLbl.TabIndex = 10;
            this.NameLbl.Text = "name";
            // 
            // ColorLbl
            // 
            this.ColorLbl.AutoSize = true;
            this.ColorLbl.Location = new System.Drawing.Point(426, 116);
            this.ColorLbl.Name = "ColorLbl";
            this.ColorLbl.Size = new System.Drawing.Size(43, 20);
            this.ColorLbl.TabIndex = 11;
            this.ColorLbl.Text = "color";
            // 
            // ComplexityLbl
            // 
            this.ComplexityLbl.AutoSize = true;
            this.ComplexityLbl.Location = new System.Drawing.Point(426, 175);
            this.ComplexityLbl.Name = "ComplexityLbl";
            this.ComplexityLbl.Size = new System.Drawing.Size(82, 20);
            this.ComplexityLbl.TabIndex = 12;
            this.ComplexityLbl.Text = "complexity";
            // 
            // HeightLbl
            // 
            this.HeightLbl.AutoSize = true;
            this.HeightLbl.Location = new System.Drawing.Point(426, 245);
            this.HeightLbl.Name = "HeightLbl";
            this.HeightLbl.Size = new System.Drawing.Size(51, 20);
            this.HeightLbl.TabIndex = 13;
            this.HeightLbl.Text = "height";
            // 
            // WeightLbl
            // 
            this.WeightLbl.AutoSize = true;
            this.WeightLbl.Location = new System.Drawing.Point(426, 301);
            this.WeightLbl.Name = "WeightLbl";
            this.WeightLbl.Size = new System.Drawing.Size(54, 20);
            this.WeightLbl.TabIndex = 14;
            this.WeightLbl.Text = "weight";
            // 
            // PointsLbl
            // 
            this.PointsLbl.AutoSize = true;
            this.PointsLbl.Location = new System.Drawing.Point(426, 353);
            this.PointsLbl.Name = "PointsLbl";
            this.PointsLbl.Size = new System.Drawing.Size(50, 20);
            this.PointsLbl.TabIndex = 15;
            this.PointsLbl.Text = "points";
            // 
            // DoorsBtn
            // 
            this.DoorsBtn.Location = new System.Drawing.Point(523, 300);
            this.DoorsBtn.Name = "DoorsBtn";
            this.DoorsBtn.Size = new System.Drawing.Size(134, 44);
            this.DoorsBtn.TabIndex = 16;
            this.DoorsBtn.Text = "Doors";
            this.DoorsBtn.UseVisualStyleBackColor = true;
            this.DoorsBtn.Click += new System.EventHandler(this.DoorsBtn_Click);
            // 
            // ArtifactsBtn
            // 
            this.ArtifactsBtn.Location = new System.Drawing.Point(702, 301);
            this.ArtifactsBtn.Name = "ArtifactsBtn";
            this.ArtifactsBtn.Size = new System.Drawing.Size(131, 43);
            this.ArtifactsBtn.TabIndex = 17;
            this.ArtifactsBtn.Text = "Artifacts";
            this.ArtifactsBtn.UseVisualStyleBackColor = true;
            this.ArtifactsBtn.Click += new System.EventHandler(this.ArtifactsBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(860, 2);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(94, 29);
            this.CloseBtn.TabIndex = 35;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // WallsBtn
            // 
            this.WallsBtn.Location = new System.Drawing.Point(523, 357);
            this.WallsBtn.Name = "WallsBtn";
            this.WallsBtn.Size = new System.Drawing.Size(134, 44);
            this.WallsBtn.TabIndex = 36;
            this.WallsBtn.Text = "Walls";
            this.WallsBtn.UseVisualStyleBackColor = true;
            this.WallsBtn.Click += new System.EventHandler(this.WallsBtn_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 413);
            this.ControlBox = false;
            this.Controls.Add(this.WallsBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.ArtifactsBtn);
            this.Controls.Add(this.DoorsBtn);
            this.Controls.Add(this.PointsLbl);
            this.Controls.Add(this.WeightLbl);
            this.Controls.Add(this.HeightLbl);
            this.Controls.Add(this.ComplexityLbl);
            this.Controls.Add(this.ColorLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.PointsTxb);
            this.Controls.Add(this.WeightTxb);
            this.Controls.Add(this.HeightTxb);
            this.Controls.Add(this.ComplexityTxb);
            this.Controls.Add(this.ColorTxb);
            this.Controls.Add(this.UpdateLevelBtn);
            this.Controls.Add(this.RemoveLevelBtn);
            this.Controls.Add(this.LevelsLbx);
            this.Controls.Add(this.NameTxb);
            this.Controls.Add(this.CreateLevelBtn);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CreateLevelBtn;
        private TextBox NameTxb;
        private ListBox LevelsLbx;
        private Button RemoveLevelBtn;
        private Button UpdateLevelBtn;
        private TextBox ColorTxb;
        private TextBox ComplexityTxb;
        private TextBox HeightTxb;
        private TextBox WeightTxb;
        private TextBox PointsTxb;
        private Label NameLbl;
        private Label ColorLbl;
        private Label ComplexityLbl;
        private Label HeightLbl;
        private Label WeightLbl;
        private Label PointsLbl;
        private Button DoorsBtn;
        private Button ArtifactsBtn;
        private Button CloseBtn;
        private Button WallsBtn;
    }
}