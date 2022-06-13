namespace Maze.Desktop
{
    partial class DoorsForm
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
            this.DoorsLbx = new System.Windows.Forms.ListBox();
            this.WeightLbl = new System.Windows.Forms.Label();
            this.HeightLbl = new System.Windows.Forms.Label();
            this.WeightTxb = new System.Windows.Forms.TextBox();
            this.HeightTxb = new System.Windows.Forms.TextBox();
            this.UpdateDoorBtn = new System.Windows.Forms.Button();
            this.RemoveDoorBtn = new System.Windows.Forms.Button();
            this.CreateDoorBtn = new System.Windows.Forms.Button();
            this.ColorLbl = new System.Windows.Forms.Label();
            this.ColorTxb = new System.Windows.Forms.TextBox();
            this.IsOpenLbl = new System.Windows.Forms.Label();
            this.IsOpenCbx = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(896, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(94, 29);
            this.CloseBtn.TabIndex = 45;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // DoorsLbx
            // 
            this.DoorsLbx.FormattingEnabled = true;
            this.DoorsLbx.ItemHeight = 20;
            this.DoorsLbx.Location = new System.Drawing.Point(625, 62);
            this.DoorsLbx.Name = "DoorsLbx";
            this.DoorsLbx.Size = new System.Drawing.Size(238, 264);
            this.DoorsLbx.TabIndex = 44;
            this.DoorsLbx.SelectedIndexChanged += new System.EventHandler(this.DoorsLbx_SelectedIndexChanged);
            // 
            // WeightLbl
            // 
            this.WeightLbl.Location = new System.Drawing.Point(479, 203);
            this.WeightLbl.Name = "WeightLbl";
            this.WeightLbl.Size = new System.Drawing.Size(100, 19);
            this.WeightLbl.TabIndex = 0;
            this.WeightLbl.Text = "Weight";
            // 
            // HeightLbl
            // 
            this.HeightLbl.Location = new System.Drawing.Point(479, 134);
            this.HeightLbl.Name = "HeightLbl";
            this.HeightLbl.Size = new System.Drawing.Size(100, 23);
            this.HeightLbl.TabIndex = 0;
            this.HeightLbl.Text = "Height";
            // 
            // WeightTxb
            // 
            this.WeightTxb.Location = new System.Drawing.Point(305, 200);
            this.WeightTxb.Name = "WeightTxb";
            this.WeightTxb.Size = new System.Drawing.Size(100, 27);
            this.WeightTxb.TabIndex = 0;
            // 
            // HeightTxb
            // 
            this.HeightTxb.Location = new System.Drawing.Point(305, 130);
            this.HeightTxb.Name = "HeightTxb";
            this.HeightTxb.Size = new System.Drawing.Size(100, 27);
            this.HeightTxb.TabIndex = 0;
            // 
            // UpdateDoorBtn
            // 
            this.UpdateDoorBtn.Location = new System.Drawing.Point(34, 184);
            this.UpdateDoorBtn.Name = "UpdateDoorBtn";
            this.UpdateDoorBtn.Size = new System.Drawing.Size(189, 38);
            this.UpdateDoorBtn.TabIndex = 0;
            this.UpdateDoorBtn.Text = "Update door";
            this.UpdateDoorBtn.Click += new System.EventHandler(this.UpdateDoorBtn_Click);
            // 
            // RemoveDoorBtn
            // 
            this.RemoveDoorBtn.Location = new System.Drawing.Point(34, 286);
            this.RemoveDoorBtn.Name = "RemoveDoorBtn";
            this.RemoveDoorBtn.Size = new System.Drawing.Size(189, 40);
            this.RemoveDoorBtn.TabIndex = 0;
            this.RemoveDoorBtn.Text = "Remove door";
            this.RemoveDoorBtn.Click += new System.EventHandler(this.RemoveDoorBtn_Click);
            // 
            // CreateDoorBtn
            // 
            this.CreateDoorBtn.Location = new System.Drawing.Point(34, 71);
            this.CreateDoorBtn.Name = "CreateDoorBtn";
            this.CreateDoorBtn.Size = new System.Drawing.Size(189, 46);
            this.CreateDoorBtn.TabIndex = 0;
            this.CreateDoorBtn.Text = "Create door";
            this.CreateDoorBtn.Click += new System.EventHandler(this.CreateDoorBtn_Click);
            // 
            // ColorLbl
            // 
            this.ColorLbl.Location = new System.Drawing.Point(479, 71);
            this.ColorLbl.Name = "ColorLbl";
            this.ColorLbl.Size = new System.Drawing.Size(100, 23);
            this.ColorLbl.TabIndex = 0;
            this.ColorLbl.Text = "Color";
            // 
            // ColorTxb
            // 
            this.ColorTxb.Location = new System.Drawing.Point(305, 71);
            this.ColorTxb.Name = "ColorTxb";
            this.ColorTxb.Size = new System.Drawing.Size(100, 27);
            this.ColorTxb.TabIndex = 0;
            // 
            // IsOpenLbl
            // 
            this.IsOpenLbl.Location = new System.Drawing.Point(479, 303);
            this.IsOpenLbl.Name = "IsOpenLbl";
            this.IsOpenLbl.Size = new System.Drawing.Size(100, 23);
            this.IsOpenLbl.TabIndex = 0;
            this.IsOpenLbl.Text = "Is open?";
            // 
            // IsOpenCbx
            // 
            this.IsOpenCbx.Location = new System.Drawing.Point(305, 302);
            this.IsOpenCbx.Name = "IsOpenCbx";
            this.IsOpenCbx.Size = new System.Drawing.Size(104, 24);
            this.IsOpenCbx.TabIndex = 0;
            this.IsOpenCbx.Text = "true";
            // 
            // DoorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 395);
            this.ControlBox = false;
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.DoorsLbx);
            this.Controls.Add(this.WeightLbl);
            this.Controls.Add(this.HeightLbl);
            this.Controls.Add(this.WeightTxb);
            this.Controls.Add(this.HeightTxb);
            this.Controls.Add(this.UpdateDoorBtn);
            this.Controls.Add(this.RemoveDoorBtn);
            this.Controls.Add(this.CreateDoorBtn);
            this.Controls.Add(this.ColorLbl);
            this.Controls.Add(this.ColorTxb);
            this.Controls.Add(this.IsOpenLbl);
            this.Controls.Add(this.IsOpenCbx);
            this.Name = "DoorsForm";
            this.Text = "DoorsForm";
            this.Load += new System.EventHandler(this.DoorsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CloseBtn;
        private ListBox DoorsLbx;
        private Label WeightLbl;
        private Label HeightLbl;
        private TextBox WeightTxb;
        private TextBox HeightTxb;
        private Button UpdateDoorBtn;
        private Button RemoveDoorBtn;
        private Button CreateDoorBtn;
        private Label ColorLbl;
        private TextBox ColorTxb;
        private Label IsOpenLbl;
        private CheckBox IsOpenCbx;
    }
}