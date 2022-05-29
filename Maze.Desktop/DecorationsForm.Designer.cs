namespace Maze.Desktop
{
    partial class DecorationsForm
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
            this.DecoratesLbx = new System.Windows.Forms.ListBox();
            this.WeightLbl = new System.Windows.Forms.Label();
            this.HeightLbl = new System.Windows.Forms.Label();
            this.WeightTxb = new System.Windows.Forms.TextBox();
            this.HeightTxb = new System.Windows.Forms.TextBox();
            this.UpdateDecorateBtn = new System.Windows.Forms.Button();
            this.RemoveDecorateBtn = new System.Windows.Forms.Button();
            this.CreateDecorateBtn = new System.Windows.Forms.Button();
            this.ColorLbl = new System.Windows.Forms.Label();
            this.ColorTxb = new System.Windows.Forms.TextBox();
            this.DoorRb = new System.Windows.Forms.RadioButton();
            this.WallRb = new System.Windows.Forms.RadioButton();
            this.DecorationTypeGbx = new System.Windows.Forms.GroupBox();
            this.FirstPropLbl = new System.Windows.Forms.Label();
            this.FirstPropTrueCbx = new System.Windows.Forms.CheckBox();
            this.DecorationTypeGbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(779, 4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(94, 29);
            this.CloseBtn.TabIndex = 45;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // DecoratesLbx
            // 
            this.DecoratesLbx.FormattingEnabled = true;
            this.DecoratesLbx.ItemHeight = 20;
            this.DecoratesLbx.Location = new System.Drawing.Point(561, 79);
            this.DecoratesLbx.Name = "DecoratesLbx";
            this.DecoratesLbx.Size = new System.Drawing.Size(238, 264);
            this.DecoratesLbx.TabIndex = 44;
            this.DecoratesLbx.SelectedIndexChanged += new System.EventHandler(this.DecoratesLbx_SelectedIndexChanged);
            // 
            // WeightLbl
            // 
            this.WeightLbl.AutoSize = true;
            this.WeightLbl.Location = new System.Drawing.Point(414, 325);
            this.WeightLbl.Name = "WeightLbl";
            this.WeightLbl.Size = new System.Drawing.Size(136, 20);
            this.WeightLbl.TabIndex = 41;
            this.WeightLbl.Text = "coordinates weight";
            // 
            // HeightLbl
            // 
            this.HeightLbl.AutoSize = true;
            this.HeightLbl.Location = new System.Drawing.Point(414, 269);
            this.HeightLbl.Name = "HeightLbl";
            this.HeightLbl.Size = new System.Drawing.Size(131, 20);
            this.HeightLbl.TabIndex = 40;
            this.HeightLbl.Text = "coordinate height ";
            // 
            // WeightTxb
            // 
            this.WeightTxb.Location = new System.Drawing.Point(246, 318);
            this.WeightTxb.Name = "WeightTxb";
            this.WeightTxb.Size = new System.Drawing.Size(151, 27);
            this.WeightTxb.TabIndex = 39;
            // 
            // HeightTxb
            // 
            this.HeightTxb.Location = new System.Drawing.Point(246, 262);
            this.HeightTxb.Name = "HeightTxb";
            this.HeightTxb.Size = new System.Drawing.Size(151, 27);
            this.HeightTxb.TabIndex = 38;
            // 
            // UpdateDecorateBtn
            // 
            this.UpdateDecorateBtn.Location = new System.Drawing.Point(12, 295);
            this.UpdateDecorateBtn.Name = "UpdateDecorateBtn";
            this.UpdateDecorateBtn.Size = new System.Drawing.Size(186, 50);
            this.UpdateDecorateBtn.TabIndex = 37;
            this.UpdateDecorateBtn.Text = "Update decorate";
            this.UpdateDecorateBtn.UseVisualStyleBackColor = true;
            this.UpdateDecorateBtn.Click += new System.EventHandler(this.UpdateDecorateBtn_Click);
            // 
            // RemoveDecorateBtn
            // 
            this.RemoveDecorateBtn.Location = new System.Drawing.Point(12, 189);
            this.RemoveDecorateBtn.Name = "RemoveDecorateBtn";
            this.RemoveDecorateBtn.Size = new System.Drawing.Size(186, 50);
            this.RemoveDecorateBtn.TabIndex = 36;
            this.RemoveDecorateBtn.Text = "Remove decorate";
            this.RemoveDecorateBtn.UseVisualStyleBackColor = true;
            this.RemoveDecorateBtn.Click += new System.EventHandler(this.RemoveDecorateBtn_Click);
            // 
            // CreateDecorateBtn
            // 
            this.CreateDecorateBtn.Location = new System.Drawing.Point(12, 79);
            this.CreateDecorateBtn.Name = "CreateDecorateBtn";
            this.CreateDecorateBtn.Size = new System.Drawing.Size(186, 50);
            this.CreateDecorateBtn.TabIndex = 35;
            this.CreateDecorateBtn.Text = "Create decorate";
            this.CreateDecorateBtn.UseVisualStyleBackColor = true;
            this.CreateDecorateBtn.Click += new System.EventHandler(this.CreateDecorateBtn_Click);
            // 
            // ColorLbl
            // 
            this.ColorLbl.AutoSize = true;
            this.ColorLbl.Location = new System.Drawing.Point(414, 208);
            this.ColorLbl.Name = "ColorLbl";
            this.ColorLbl.Size = new System.Drawing.Size(43, 20);
            this.ColorLbl.TabIndex = 47;
            this.ColorLbl.Text = "color";
            // 
            // ColorTxb
            // 
            this.ColorTxb.Location = new System.Drawing.Point(246, 201);
            this.ColorTxb.Name = "ColorTxb";
            this.ColorTxb.Size = new System.Drawing.Size(151, 27);
            this.ColorTxb.TabIndex = 46;
            // 
            // DoorRb
            // 
            this.DoorRb.AutoSize = true;
            this.DoorRb.Location = new System.Drawing.Point(6, 39);
            this.DoorRb.Name = "DoorRb";
            this.DoorRb.Size = new System.Drawing.Size(62, 24);
            this.DoorRb.TabIndex = 50;
            this.DoorRb.TabStop = true;
            this.DoorRb.Text = "door";
            this.DoorRb.UseVisualStyleBackColor = true;
            this.DoorRb.CheckedChanged += new System.EventHandler(this.DoorRb_CheckedChanged);
            // 
            // WallRb
            // 
            this.WallRb.AutoSize = true;
            this.WallRb.Location = new System.Drawing.Point(145, 39);
            this.WallRb.Name = "WallRb";
            this.WallRb.Size = new System.Drawing.Size(57, 24);
            this.WallRb.TabIndex = 51;
            this.WallRb.TabStop = true;
            this.WallRb.Text = "wall";
            this.WallRb.UseVisualStyleBackColor = true;
            this.WallRb.CheckedChanged += new System.EventHandler(this.WallRb_CheckedChanged);
            // 
            // DecorationTypeGbx
            // 
            this.DecorationTypeGbx.Controls.Add(this.DoorRb);
            this.DecorationTypeGbx.Controls.Add(this.WallRb);
            this.DecorationTypeGbx.Location = new System.Drawing.Point(246, 79);
            this.DecorationTypeGbx.Name = "DecorationTypeGbx";
            this.DecorationTypeGbx.Size = new System.Drawing.Size(280, 99);
            this.DecorationTypeGbx.TabIndex = 52;
            this.DecorationTypeGbx.TabStop = false;
            this.DecorationTypeGbx.Text = "decoration type";
            // 
            // FirstPropLbl
            // 
            this.FirstPropLbl.AutoSize = true;
            this.FirstPropLbl.Location = new System.Drawing.Point(414, 378);
            this.FirstPropLbl.Name = "FirstPropLbl";
            this.FirstPropLbl.Size = new System.Drawing.Size(0, 20);
            this.FirstPropLbl.TabIndex = 53;
            // 
            // FirstPropTrueCbx
            // 
            this.FirstPropTrueCbx.AutoSize = true;
            this.FirstPropTrueCbx.Location = new System.Drawing.Point(246, 394);
            this.FirstPropTrueCbx.Name = "FirstPropTrueCbx";
            this.FirstPropTrueCbx.Size = new System.Drawing.Size(57, 24);
            this.FirstPropTrueCbx.TabIndex = 54;
            this.FirstPropTrueCbx.Text = "true";
            this.FirstPropTrueCbx.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.FirstPropTrueCbx.UseVisualStyleBackColor = true;
            // 
            // DecorationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 449);
            this.ControlBox = false;
            this.Controls.Add(this.FirstPropTrueCbx);
            this.Controls.Add(this.FirstPropLbl);
            this.Controls.Add(this.DecorationTypeGbx);
            this.Controls.Add(this.ColorLbl);
            this.Controls.Add(this.ColorTxb);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.DecoratesLbx);
            this.Controls.Add(this.WeightLbl);
            this.Controls.Add(this.HeightLbl);
            this.Controls.Add(this.WeightTxb);
            this.Controls.Add(this.HeightTxb);
            this.Controls.Add(this.UpdateDecorateBtn);
            this.Controls.Add(this.RemoveDecorateBtn);
            this.Controls.Add(this.CreateDecorateBtn);
            this.Name = "DecorationsForm";
            this.Text = "DecorationsForm";
            this.Load += new System.EventHandler(this.DecorationsForm_Load);
            this.DecorationTypeGbx.ResumeLayout(false);
            this.DecorationTypeGbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CloseBtn;
        private ListBox DecoratesLbx;
        private Label WeightLbl;
        private Label HeightLbl;
        private TextBox WeightTxb;
        private TextBox HeightTxb;
        private Button UpdateDecorateBtn;
        private Button RemoveDecorateBtn;
        private Button CreateDecorateBtn;
        private Label ColorLbl;
        private TextBox ColorTxb;
        private RadioButton DoorRb;
        private RadioButton WallRb;
        private GroupBox DecorationTypeGbx;
        private Label FirstPropLbl;
        private CheckBox FirstPropTrueCbx;
    }
}