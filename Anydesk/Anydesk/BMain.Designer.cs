namespace Anydesk
{
    partial class BMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMain));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LeftCPS_Label = new System.Windows.Forms.Label();
            this.LeftClick = new System.Windows.Forms.Timer(this.components);
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.LCheck_B = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.siticoneImageButton1 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.krokmouTrackBar1 = new Krokmou_Clicker_V3.UI.Controls.KrokmouTrackBar();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 4;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // LeftCPS_Label
            // 
            this.LeftCPS_Label.AutoSize = true;
            this.LeftCPS_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftCPS_Label.ForeColor = System.Drawing.Color.White;
            this.LeftCPS_Label.Location = new System.Drawing.Point(417, 73);
            this.LeftCPS_Label.Name = "LeftCPS_Label";
            this.LeftCPS_Label.Size = new System.Drawing.Size(51, 30);
            this.LeftCPS_Label.TabIndex = 1;
            this.LeftCPS_Label.Text = "CPS";
            // 
            // LeftClick
            // 
            this.LeftClick.Enabled = true;
            this.LeftClick.Interval = 156;
            this.LeftClick.Tick += new System.EventHandler(this.LeftClick_Tick);
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.siticoneControlBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.siticoneControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.siticoneControlBox1.IconColor = System.Drawing.Color.DimGray;
            this.siticoneControlBox1.Location = new System.Drawing.Point(689, 2);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(24, 24);
            this.siticoneControlBox1.TabIndex = 13;
            this.siticoneControlBox1.Click += new System.EventHandler(this.siticoneControlBox1_Click);
            // 
            // LCheck_B
            // 
            this.LCheck_B.AllowBindingControlAnimation = true;
            this.LCheck_B.AllowBindingControlColorChanges = false;
            this.LCheck_B.AllowBindingControlLocation = true;
            this.LCheck_B.AllowCheckBoxAnimation = false;
            this.LCheck_B.AllowCheckmarkAnimation = true;
            this.LCheck_B.AllowOnHoverStates = true;
            this.LCheck_B.AutoCheck = true;
            this.LCheck_B.BackColor = System.Drawing.Color.Transparent;
            this.LCheck_B.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LCheck_B.BackgroundImage")));
            this.LCheck_B.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LCheck_B.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.LCheck_B.BorderRadius = 12;
            this.LCheck_B.Checked = false;
            this.LCheck_B.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.LCheck_B.Cursor = System.Windows.Forms.Cursors.Default;
            this.LCheck_B.CustomCheckmarkImage = null;
            this.LCheck_B.Location = new System.Drawing.Point(27, 124);
            this.LCheck_B.MinimumSize = new System.Drawing.Size(17, 17);
            this.LCheck_B.Name = "LCheck_B";
            this.LCheck_B.OnCheck.BorderColor = System.Drawing.Color.RoyalBlue;
            this.LCheck_B.OnCheck.BorderRadius = 12;
            this.LCheck_B.OnCheck.BorderThickness = 2;
            this.LCheck_B.OnCheck.CheckBoxColor = System.Drawing.Color.RoyalBlue;
            this.LCheck_B.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.LCheck_B.OnCheck.CheckmarkThickness = 2;
            this.LCheck_B.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.LCheck_B.OnDisable.BorderRadius = 12;
            this.LCheck_B.OnDisable.BorderThickness = 2;
            this.LCheck_B.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.LCheck_B.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.LCheck_B.OnDisable.CheckmarkThickness = 2;
            this.LCheck_B.OnHoverChecked.BorderColor = System.Drawing.Color.RoyalBlue;
            this.LCheck_B.OnHoverChecked.BorderRadius = 12;
            this.LCheck_B.OnHoverChecked.BorderThickness = 2;
            this.LCheck_B.OnHoverChecked.CheckBoxColor = System.Drawing.Color.RoyalBlue;
            this.LCheck_B.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.LCheck_B.OnHoverChecked.CheckmarkThickness = 2;
            this.LCheck_B.OnHoverUnchecked.BorderColor = System.Drawing.Color.RoyalBlue;
            this.LCheck_B.OnHoverUnchecked.BorderRadius = 12;
            this.LCheck_B.OnHoverUnchecked.BorderThickness = 1;
            this.LCheck_B.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.LCheck_B.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.LCheck_B.OnUncheck.BorderRadius = 12;
            this.LCheck_B.OnUncheck.BorderThickness = 1;
            this.LCheck_B.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.LCheck_B.Size = new System.Drawing.Size(21, 21);
            this.LCheck_B.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.LCheck_B.TabIndex = 3;
            this.LCheck_B.ThreeState = false;
            this.LCheck_B.ToolTipText = null;
            this.LCheck_B.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.LCheck_B_CheckedChanged);
            // 
            // siticoneImageButton1
            // 
            this.siticoneImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton1.HoverState.Image = global::Anydesk.Properties.Resources.discorde;
            this.siticoneImageButton1.HoverState.ImageSize = new System.Drawing.Size(26, 26);
            this.siticoneImageButton1.Image = global::Anydesk.Properties.Resources.discorde;
            this.siticoneImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.siticoneImageButton1.ImageRotate = 0F;
            this.siticoneImageButton1.ImageSize = new System.Drawing.Size(26, 26);
            this.siticoneImageButton1.IndicateFocus = true;
            this.siticoneImageButton1.Location = new System.Drawing.Point(12, 456);
            this.siticoneImageButton1.Name = "siticoneImageButton1";
            this.siticoneImageButton1.PressedState.Image = global::Anydesk.Properties.Resources.discorde;
            this.siticoneImageButton1.PressedState.ImageSize = new System.Drawing.Size(26, 26);
            this.siticoneImageButton1.Size = new System.Drawing.Size(29, 33);
            this.siticoneImageButton1.TabIndex = 0;
            this.siticoneImageButton1.Click += new System.EventHandler(this.siticoneImageButton1_Click);
            // 
            // krokmouTrackBar1
            // 
            this.krokmouTrackBar1.Location = new System.Drawing.Point(27, 73);
            this.krokmouTrackBar1.MaximumValue = 25;
            this.krokmouTrackBar1.MinimumValue = 6;
            this.krokmouTrackBar1.Name = "krokmouTrackBar1";
            this.krokmouTrackBar1.Size = new System.Drawing.Size(349, 34);
            this.krokmouTrackBar1.TabIndex = 2;
            this.krokmouTrackBar1.ThumbColor = System.Drawing.Color.RoyalBlue;
            this.krokmouTrackBar1.TrackColor = System.Drawing.Color.DimGray;
            this.krokmouTrackBar1.Value = 6;
            this.krokmouTrackBar1.ValueChanged += new System.EventHandler(this.krokmouTrackBar1_ValueChanged);
            // 
            // BMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(713, 501);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.LCheck_B);
            this.Controls.Add(this.krokmouTrackBar1);
            this.Controls.Add(this.LeftCPS_Label);
            this.Controls.Add(this.siticoneImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BMain";
            this.Text = "BMain";
            this.Load += new System.EventHandler(this.BMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton siticoneImageButton1;
        private System.Windows.Forms.Label LeftCPS_Label;
        private Krokmou_Clicker_V3.UI.Controls.KrokmouTrackBar krokmouTrackBar1;
        private System.Windows.Forms.Timer LeftClick;
        private Bunifu.UI.WinForms.BunifuCheckBox LCheck_B;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
    }
}