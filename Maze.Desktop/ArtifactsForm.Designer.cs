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
            this.ArtifactTypesLbx = new System.Windows.Forms.ListBox();
            this.ArtifactTypeLbl = new System.Windows.Forms.Label();
            this.ArtifactsLbx = new System.Windows.Forms.ListBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WeightLbl
            // 
            this.WeightLbl.AutoSize = true;
            this.WeightLbl.Location = new System.Drawing.Point(433, 282);
            this.WeightLbl.Name = "WeightLbl";
            this.WeightLbl.Size = new System.Drawing.Size(56, 20);
            this.WeightLbl.TabIndex = 30;
            this.WeightLbl.Text = "Weight";
            // 
            // HeightLbl
            // 
            this.HeightLbl.AutoSize = true;
            this.HeightLbl.Location = new System.Drawing.Point(433, 202);
            this.HeightLbl.Name = "HeightLbl";
            this.HeightLbl.Size = new System.Drawing.Size(54, 20);
            this.HeightLbl.TabIndex = 29;
            this.HeightLbl.Text = "Height";
            // 
            // WeightTxb
            // 
            this.WeightTxb.Location = new System.Drawing.Point(259, 275);
            this.WeightTxb.Name = "WeightTxb";
            this.WeightTxb.Size = new System.Drawing.Size(117, 27);
            this.WeightTxb.TabIndex = 24;
            // 
            // HeightTxb
            // 
            this.HeightTxb.Location = new System.Drawing.Point(259, 195);
            this.HeightTxb.Name = "HeightTxb";
            this.HeightTxb.Size = new System.Drawing.Size(117, 27);
            this.HeightTxb.TabIndex = 23;
            // 
            // UpdateArtifactBtn
            // 
            this.UpdateArtifactBtn.Location = new System.Drawing.Point(46, 153);
            this.UpdateArtifactBtn.Name = "UpdateArtifactBtn";
            this.UpdateArtifactBtn.Size = new System.Drawing.Size(186, 50);
            this.UpdateArtifactBtn.TabIndex = 22;
            this.UpdateArtifactBtn.Text = "Update artifact";
            this.UpdateArtifactBtn.UseVisualStyleBackColor = true;
            this.UpdateArtifactBtn.Click += new System.EventHandler(this.UpdateArtifactBtn_Click);
            // 
            // RemoveArtifactBtn
            // 
            this.RemoveArtifactBtn.Location = new System.Drawing.Point(46, 252);
            this.RemoveArtifactBtn.Name = "RemoveArtifactBtn";
            this.RemoveArtifactBtn.Size = new System.Drawing.Size(186, 50);
            this.RemoveArtifactBtn.TabIndex = 21;
            this.RemoveArtifactBtn.Text = "Remove artifact";
            this.RemoveArtifactBtn.UseVisualStyleBackColor = true;
            this.RemoveArtifactBtn.Click += new System.EventHandler(this.RemoveArtifactBtn_Click);
            // 
            // CreateArtifactBtn
            // 
            this.CreateArtifactBtn.Location = new System.Drawing.Point(46, 51);
            this.CreateArtifactBtn.Name = "CreateArtifactBtn";
            this.CreateArtifactBtn.Size = new System.Drawing.Size(186, 50);
            this.CreateArtifactBtn.TabIndex = 18;
            this.CreateArtifactBtn.Text = "Create artifact";
            this.CreateArtifactBtn.UseVisualStyleBackColor = true;
            this.CreateArtifactBtn.Click += new System.EventHandler(this.CreateArtifactBtn_Click);
            // 
            // ArtifactTypesLbx
            // 
            this.ArtifactTypesLbx.FormattingEnabled = true;
            this.ArtifactTypesLbx.ItemHeight = 20;
            this.ArtifactTypesLbx.Location = new System.Drawing.Point(259, 51);
            this.ArtifactTypesLbx.Name = "ArtifactTypesLbx";
            this.ArtifactTypesLbx.Size = new System.Drawing.Size(131, 104);
            this.ArtifactTypesLbx.TabIndex = 31;
            // 
            // ArtifactTypeLbl
            // 
            this.ArtifactTypeLbl.AutoSize = true;
            this.ArtifactTypeLbl.Location = new System.Drawing.Point(433, 135);
            this.ArtifactTypeLbl.Name = "ArtifactTypeLbl";
            this.ArtifactTypeLbl.Size = new System.Drawing.Size(91, 20);
            this.ArtifactTypeLbl.TabIndex = 32;
            this.ArtifactTypeLbl.Text = "Artifact type";
            // 
            // ArtifactsLbx
            // 
            this.ArtifactsLbx.FormattingEnabled = true;
            this.ArtifactsLbx.ItemHeight = 20;
            this.ArtifactsLbx.Location = new System.Drawing.Point(554, 38);
            this.ArtifactsLbx.Name = "ArtifactsLbx";
            this.ArtifactsLbx.Size = new System.Drawing.Size(238, 264);
            this.ArtifactsLbx.TabIndex = 33;
            this.ArtifactsLbx.SelectedIndexChanged += new System.EventHandler(this.ArtifactsLbx_SelectedIndexChanged);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(871, -1);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(86, 32);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ArtifactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 374);
            this.ControlBox = false;
            this.Controls.Add(this.WeightLbl);
            this.Controls.Add(this.HeightLbl);
            this.Controls.Add(this.HeightTxb);
            this.Controls.Add(this.WeightTxb);
            this.Controls.Add(this.UpdateArtifactBtn);
            this.Controls.Add(this.RemoveArtifactBtn);
            this.Controls.Add(this.CreateArtifactBtn);
            this.Controls.Add(this.ArtifactTypesLbx);
            this.Controls.Add(this.ArtifactTypeLbl);
            this.Controls.Add(this.ArtifactsLbx);
            this.Controls.Add(this.CloseBtn);
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
        private ListBox ArtifactTypesLbx;
        private Label ArtifactTypeLbl;
        private ListBox ArtifactsLbx;
        private Button CloseBtn;
    }
}