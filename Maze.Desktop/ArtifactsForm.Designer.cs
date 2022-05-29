namespace Maze.Desktop
{
    partial class ArtifactsForm
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
            this.WeightLbl = new System.Windows.Forms.Label();
            this.HeightLbl = new System.Windows.Forms.Label();
            this.WeightTxb = new System.Windows.Forms.TextBox();
            this.HeightTxb = new System.Windows.Forms.TextBox();
            this.UpdateArtifactBtn = new System.Windows.Forms.Button();
            this.RemoveArtifactBtn = new System.Windows.Forms.Button();
            this.CreateArtifactBtn = new System.Windows.Forms.Button();
            this.ArtifactsLbx = new System.Windows.Forms.ListBox();
            this.ArtifactTypeLbl = new System.Windows.Forms.Label();
            this.ArtifactCellslLbx = new System.Windows.Forms.ListBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WeightLbl
            // 
            this.WeightLbl.AutoSize = true;
            this.WeightLbl.Location = new System.Drawing.Point(442, 315);
            this.WeightLbl.Name = "WeightLbl";
            this.WeightLbl.Size = new System.Drawing.Size(136, 20);
            this.WeightLbl.TabIndex = 30;
            this.WeightLbl.Text = "coordinates weight";
            // 
            // HeightLbl
            // 
            this.HeightLbl.AutoSize = true;
            this.HeightLbl.Location = new System.Drawing.Point(447, 247);
            this.HeightLbl.Name = "HeightLbl";
            this.HeightLbl.Size = new System.Drawing.Size(131, 20);
            this.HeightLbl.TabIndex = 29;
            this.HeightLbl.Text = "coordinate height ";
            // 
            // WeightTxb
            // 
            this.WeightTxb.Location = new System.Drawing.Point(279, 315);
            this.WeightTxb.Name = "WeightTxb";
            this.WeightTxb.Size = new System.Drawing.Size(151, 27);
            this.WeightTxb.TabIndex = 24;
            // 
            // HeightTxb
            // 
            this.HeightTxb.Location = new System.Drawing.Point(279, 247);
            this.HeightTxb.Name = "HeightTxb";
            this.HeightTxb.Size = new System.Drawing.Size(151, 27);
            this.HeightTxb.TabIndex = 23;
            // 
            // UpdateArtifactBtn
            // 
            this.UpdateArtifactBtn.Location = new System.Drawing.Point(45, 292);
            this.UpdateArtifactBtn.Name = "UpdateArtifactBtn";
            this.UpdateArtifactBtn.Size = new System.Drawing.Size(186, 50);
            this.UpdateArtifactBtn.TabIndex = 22;
            this.UpdateArtifactBtn.Text = "Update artifact";
            this.UpdateArtifactBtn.UseVisualStyleBackColor = true;
            this.UpdateArtifactBtn.Click += new System.EventHandler(this.UpdateArtifactBtn_Click);
            // 
            // RemoveArtifactBtn
            // 
            this.RemoveArtifactBtn.Location = new System.Drawing.Point(45, 186);
            this.RemoveArtifactBtn.Name = "RemoveArtifactBtn";
            this.RemoveArtifactBtn.Size = new System.Drawing.Size(186, 50);
            this.RemoveArtifactBtn.TabIndex = 21;
            this.RemoveArtifactBtn.Text = "Remove artifact";
            this.RemoveArtifactBtn.UseVisualStyleBackColor = true;
            this.RemoveArtifactBtn.Click += new System.EventHandler(this.RemoveArtifactBtn_Click);
            // 
            // CreateArtifactBtn
            // 
            this.CreateArtifactBtn.Location = new System.Drawing.Point(45, 76);
            this.CreateArtifactBtn.Name = "CreateArtifactBtn";
            this.CreateArtifactBtn.Size = new System.Drawing.Size(186, 50);
            this.CreateArtifactBtn.TabIndex = 18;
            this.CreateArtifactBtn.Text = "Create artifact";
            this.CreateArtifactBtn.UseVisualStyleBackColor = true;
            this.CreateArtifactBtn.Click += new System.EventHandler(this.CreateArtifactBtn_Click);
            // 
            // ArtifactsLbx
            // 
            this.ArtifactsLbx.FormattingEnabled = true;
            this.ArtifactsLbx.ItemHeight = 20;
            this.ArtifactsLbx.Location = new System.Drawing.Point(279, 76);
            this.ArtifactsLbx.Name = "ArtifactsLbx";
            this.ArtifactsLbx.Size = new System.Drawing.Size(151, 144);
            this.ArtifactsLbx.TabIndex = 31;
            // 
            // ArtifactTypeLbl
            // 
            this.ArtifactTypeLbl.AutoSize = true;
            this.ArtifactTypeLbl.Location = new System.Drawing.Point(447, 76);
            this.ArtifactTypeLbl.Name = "ArtifactTypeLbl";
            this.ArtifactTypeLbl.Size = new System.Drawing.Size(93, 20);
            this.ArtifactTypeLbl.TabIndex = 32;
            this.ArtifactTypeLbl.Text = "artifact type ";
            // 
            // ArtifactCellslLbx
            // 
            this.ArtifactCellslLbx.FormattingEnabled = true;
            this.ArtifactCellslLbx.ItemHeight = 20;
            this.ArtifactCellslLbx.Location = new System.Drawing.Point(594, 76);
            this.ArtifactCellslLbx.Name = "ArtifactCellslLbx";
            this.ArtifactCellslLbx.Size = new System.Drawing.Size(238, 264);
            this.ArtifactCellslLbx.TabIndex = 33;
            this.ArtifactCellslLbx.SelectedIndexChanged += new System.EventHandler(this.ArtifactCellsLbx_SelectedIndexChanged);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(812, 1);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(94, 29);
            this.CloseBtn.TabIndex = 34;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ArtifactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 435);
            this.ControlBox = false;
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.ArtifactCellslLbx);
            this.Controls.Add(this.ArtifactTypeLbl);
            this.Controls.Add(this.ArtifactsLbx);
            this.Controls.Add(this.WeightLbl);
            this.Controls.Add(this.HeightLbl);
            this.Controls.Add(this.WeightTxb);
            this.Controls.Add(this.HeightTxb);
            this.Controls.Add(this.UpdateArtifactBtn);
            this.Controls.Add(this.RemoveArtifactBtn);
            this.Controls.Add(this.CreateArtifactBtn);
            this.Name = "ArtifactsForm";
            this.Text = "ArtifactsForm";
            this.Load += new System.EventHandler(this.ArtifactsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label WeightLbl;
        private Label HeightLbl;
        private TextBox WeightTxb;
        private TextBox HeightTxb;
        private Button UpdateArtifactBtn;
        private Button RemoveArtifactBtn;
        private Button CreateArtifactBtn;
        private ListBox ArtifactsLbx;
        private Label ArtifactTypeLbl;
        private ListBox ArtifactCellslLbx;
        private Button CloseBtn;
    }
}