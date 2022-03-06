
namespace Gorkido_s_GT_Unbanner
{
    partial class Unbanner_Form
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
            Guna.UI2.AnimatorNS.Animation animation5 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Unbanner_Form));
            this.BackgroundPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.AdaptersComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.longkey = new System.Windows.Forms.Label();
            this.shortkey = new System.Windows.Forms.Label();
            this.ActualMacLabel = new System.Windows.Forms.Label();
            this.CurrentMacTextBox = new System.Windows.Forms.Label();
            this.label146 = new System.Windows.Forms.Label();
            this.label3437 = new System.Windows.Forms.Label();
            this.label143 = new System.Windows.Forms.Label();
            this.label142 = new System.Windows.Forms.Label();
            this.Unban = new Guna.UI2.WinForms.Guna2GradientButton();
            this.UnbanLog = new Guna.UI2.WinForms.Guna2TextBox();
            this.TopBar = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Title = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.FormElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TextBox_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TitleDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.TopBarDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Startup_Transition = new Guna.UI2.WinForms.Guna2Transition();
            this.BackgroundPanel.SuspendLayout();
            this.TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundPanel.Controls.Add(this.AdaptersComboBox);
            this.BackgroundPanel.Controls.Add(this.longkey);
            this.BackgroundPanel.Controls.Add(this.shortkey);
            this.BackgroundPanel.Controls.Add(this.ActualMacLabel);
            this.BackgroundPanel.Controls.Add(this.CurrentMacTextBox);
            this.BackgroundPanel.Controls.Add(this.label146);
            this.BackgroundPanel.Controls.Add(this.label3437);
            this.BackgroundPanel.Controls.Add(this.label143);
            this.BackgroundPanel.Controls.Add(this.label142);
            this.BackgroundPanel.Controls.Add(this.Unban);
            this.BackgroundPanel.Controls.Add(this.UnbanLog);
            this.BackgroundPanel.Controls.Add(this.TopBar);
            this.Startup_Transition.SetDecoration(this.BackgroundPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanel.FillColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundPanel.FillColor2 = System.Drawing.Color.LightSkyBlue;
            this.BackgroundPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(386, 398);
            this.BackgroundPanel.TabIndex = 1;
            // 
            // AdaptersComboBox
            // 
            this.AdaptersComboBox.AutoRoundedCorners = true;
            this.AdaptersComboBox.BackColor = System.Drawing.Color.Transparent;
            this.AdaptersComboBox.BorderColor = System.Drawing.Color.Transparent;
            this.AdaptersComboBox.BorderRadius = 17;
            this.AdaptersComboBox.BorderThickness = 0;
            this.Startup_Transition.SetDecoration(this.AdaptersComboBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.AdaptersComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AdaptersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdaptersComboBox.FillColor = System.Drawing.Color.SteelBlue;
            this.AdaptersComboBox.FocusedColor = System.Drawing.Color.SteelBlue;
            this.AdaptersComboBox.FocusedState.BorderColor = System.Drawing.Color.SteelBlue;
            this.AdaptersComboBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdaptersComboBox.ForeColor = System.Drawing.Color.White;
            this.AdaptersComboBox.ItemHeight = 30;
            this.AdaptersComboBox.Location = new System.Drawing.Point(103, 336);
            this.AdaptersComboBox.Name = "AdaptersComboBox";
            this.AdaptersComboBox.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.AdaptersComboBox.Size = new System.Drawing.Size(180, 36);
            this.AdaptersComboBox.TabIndex = 215;
            this.AdaptersComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdaptersComboBox.Visible = false;
            // 
            // longkey
            // 
            this.longkey.AutoSize = true;
            this.Startup_Transition.SetDecoration(this.longkey, Guna.UI2.AnimatorNS.DecorationType.None);
            this.longkey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.longkey.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longkey.ForeColor = System.Drawing.Color.White;
            this.longkey.Location = new System.Drawing.Point(87, 343);
            this.longkey.Name = "longkey";
            this.longkey.Size = new System.Drawing.Size(0, 16);
            this.longkey.TabIndex = 223;
            this.longkey.Visible = false;
            // 
            // shortkey
            // 
            this.shortkey.AutoSize = true;
            this.Startup_Transition.SetDecoration(this.shortkey, Guna.UI2.AnimatorNS.DecorationType.None);
            this.shortkey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shortkey.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortkey.ForeColor = System.Drawing.Color.White;
            this.shortkey.Location = new System.Drawing.Point(67, 326);
            this.shortkey.Name = "shortkey";
            this.shortkey.Size = new System.Drawing.Size(0, 16);
            this.shortkey.TabIndex = 222;
            this.shortkey.Visible = false;
            // 
            // ActualMacLabel
            // 
            this.ActualMacLabel.AutoSize = true;
            this.Startup_Transition.SetDecoration(this.ActualMacLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ActualMacLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActualMacLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualMacLabel.ForeColor = System.Drawing.Color.White;
            this.ActualMacLabel.Location = new System.Drawing.Point(134, 360);
            this.ActualMacLabel.Name = "ActualMacLabel";
            this.ActualMacLabel.Size = new System.Drawing.Size(0, 16);
            this.ActualMacLabel.TabIndex = 221;
            this.ActualMacLabel.Visible = false;
            // 
            // CurrentMacTextBox
            // 
            this.CurrentMacTextBox.AutoSize = true;
            this.Startup_Transition.SetDecoration(this.CurrentMacTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.CurrentMacTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentMacTextBox.ForeColor = System.Drawing.Color.White;
            this.CurrentMacTextBox.Location = new System.Drawing.Point(162, 376);
            this.CurrentMacTextBox.Name = "CurrentMacTextBox";
            this.CurrentMacTextBox.Size = new System.Drawing.Size(0, 16);
            this.CurrentMacTextBox.TabIndex = 220;
            this.CurrentMacTextBox.Visible = false;
            // 
            // label146
            // 
            this.label146.AutoSize = true;
            this.Startup_Transition.SetDecoration(this.label146, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label146.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label146.ForeColor = System.Drawing.Color.White;
            this.label146.Location = new System.Drawing.Point(3, 375);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(164, 16);
            this.label146.TabIndex = 219;
            this.label146.Text = "Mac Address To Change:";
            this.label146.Visible = false;
            // 
            // label3437
            // 
            this.label3437.AutoSize = true;
            this.Startup_Transition.SetDecoration(this.label3437, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3437.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3437.ForeColor = System.Drawing.Color.White;
            this.label3437.Location = new System.Drawing.Point(3, 359);
            this.label3437.Name = "label3437";
            this.label3437.Size = new System.Drawing.Size(135, 16);
            this.label3437.TabIndex = 218;
            this.label3437.Text = "Current Mac Adress:";
            this.label3437.Visible = false;
            // 
            // label143
            // 
            this.label143.AutoSize = true;
            this.Startup_Transition.SetDecoration(this.label143, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label143.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label143.ForeColor = System.Drawing.Color.White;
            this.label143.Location = new System.Drawing.Point(3, 341);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(88, 16);
            this.label143.TabIndex = 217;
            this.label143.Text = "Second Key:";
            this.label143.Visible = false;
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.Startup_Transition.SetDecoration(this.label142, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label142.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label142.ForeColor = System.Drawing.Color.White;
            this.label142.Location = new System.Drawing.Point(4, 325);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(67, 16);
            this.label142.TabIndex = 216;
            this.label142.Text = "First Key:";
            this.label142.Visible = false;
            // 
            // Unban
            // 
            this.Unban.Animated = true;
            this.Unban.AutoRoundedCorners = true;
            this.Unban.BackColor = System.Drawing.Color.Transparent;
            this.Unban.BorderColor = System.Drawing.Color.Transparent;
            this.Unban.BorderRadius = 24;
            this.Unban.BorderThickness = 1;
            this.Startup_Transition.SetDecoration(this.Unban, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Unban.FillColor = System.Drawing.Color.MidnightBlue;
            this.Unban.FillColor2 = System.Drawing.Color.LightSkyBlue;
            this.Unban.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unban.ForeColor = System.Drawing.Color.White;
            this.Unban.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.Unban.Location = new System.Drawing.Point(103, 61);
            this.Unban.Name = "Unban";
            this.Unban.Size = new System.Drawing.Size(180, 50);
            this.Unban.TabIndex = 214;
            this.Unban.Text = "Unban";
            this.Unban.Visible = false;
            this.Unban.Click += new System.EventHandler(this.Unban_Click);
            // 
            // UnbanLog
            // 
            this.UnbanLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UnbanLog.BorderColor = System.Drawing.Color.SteelBlue;
            this.UnbanLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Startup_Transition.SetDecoration(this.UnbanLog, Guna.UI2.AnimatorNS.DecorationType.None);
            this.UnbanLog.DefaultText = "";
            this.UnbanLog.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UnbanLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UnbanLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UnbanLog.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UnbanLog.FillColor = System.Drawing.Color.SteelBlue;
            this.UnbanLog.FocusedState.BorderColor = System.Drawing.Color.SteelBlue;
            this.UnbanLog.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnbanLog.ForeColor = System.Drawing.Color.White;
            this.UnbanLog.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.UnbanLog.Location = new System.Drawing.Point(20, 123);
            this.UnbanLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UnbanLog.Multiline = true;
            this.UnbanLog.Name = "UnbanLog";
            this.UnbanLog.PasswordChar = '\0';
            this.UnbanLog.PlaceholderForeColor = System.Drawing.Color.White;
            this.UnbanLog.PlaceholderText = "";
            this.UnbanLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.UnbanLog.SelectedText = "";
            this.UnbanLog.Size = new System.Drawing.Size(346, 188);
            this.UnbanLog.TabIndex = 208;
            this.UnbanLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UnbanLog.Visible = false;
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.Transparent;
            this.TopBar.BorderRadius = 7;
            this.TopBar.Controls.Add(this.Title);
            this.TopBar.Controls.Add(this.Minimize);
            this.TopBar.Controls.Add(this.Exit);
            this.TopBar.CustomizableEdges.BottomLeft = false;
            this.TopBar.CustomizableEdges.BottomRight = false;
            this.Startup_Transition.SetDecoration(this.TopBar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TopBar.FillColor = System.Drawing.Color.MidnightBlue;
            this.TopBar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(199)))));
            this.TopBar.FillColor3 = System.Drawing.Color.MidnightBlue;
            this.TopBar.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(199)))));
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(386, 50);
            this.TopBar.TabIndex = 0;
            this.TopBar.Visible = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Startup_Transition.SetDecoration(this.Title, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Title.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(7, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(202, 25);
            this.Title.TabIndex = 10;
            this.Title.Text = "Growtopia Unbanner";
            // 
            // Minimize
            // 
            this.Minimize.AutoSize = true;
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Startup_Transition.SetDecoration(this.Minimize, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(276, 9);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(31, 21);
            this.Minimize.TabIndex = 9;
            this.Minimize.Text = "___";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Startup_Transition.SetDecoration(this.Exit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(342, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(35, 37);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // FormElipse
            // 
            this.FormElipse.BorderRadius = 12;
            this.FormElipse.TargetControl = this;
            // 
            // TextBox_Elipse
            // 
            this.TextBox_Elipse.BorderRadius = 12;
            this.TextBox_Elipse.TargetControl = this.UnbanLog;
            // 
            // TitleDrag
            // 
            this.TitleDrag.DockIndicatorTransparencyValue = 0.6D;
            this.TitleDrag.DragEndTransparencyValue = 0.9D;
            this.TitleDrag.DragStartTransparencyValue = 0.8D;
            this.TitleDrag.TargetControl = this.Title;
            this.TitleDrag.UseTransparentDrag = true;
            // 
            // TopBarDrag
            // 
            this.TopBarDrag.DockIndicatorTransparencyValue = 0.6D;
            this.TopBarDrag.DragEndTransparencyValue = 0.9D;
            this.TopBarDrag.DragStartTransparencyValue = 0.8D;
            this.TopBarDrag.TargetControl = this.TopBar;
            this.TopBarDrag.UseTransparentDrag = true;
            // 
            // Startup_Transition
            // 
            this.Startup_Transition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.Startup_Transition.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 1F;
            this.Startup_Transition.DefaultAnimation = animation5;
            this.Startup_Transition.Interval = 2;
            // 
            // Unbanner_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(386, 398);
            this.Controls.Add(this.BackgroundPanel);
            this.Startup_Transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Unbanner_Form";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Unbanner_Form_Load);
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel BackgroundPanel;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel TopBar;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label Exit;
        private Guna.UI2.WinForms.Guna2Elipse FormElipse;
        private Guna.UI2.WinForms.Guna2Elipse TextBox_Elipse;
        private Guna.UI2.WinForms.Guna2TextBox UnbanLog;
        private Guna.UI2.WinForms.Guna2GradientButton Unban;
        private Guna.UI2.WinForms.Guna2ComboBox AdaptersComboBox;
        private Guna.UI2.WinForms.Guna2DragControl TitleDrag;
        private Guna.UI2.WinForms.Guna2DragControl TopBarDrag;
        private System.Windows.Forms.Label longkey;
        private System.Windows.Forms.Label shortkey;
        private System.Windows.Forms.Label ActualMacLabel;
        private System.Windows.Forms.Label CurrentMacTextBox;
        private System.Windows.Forms.Label label146;
        private System.Windows.Forms.Label label3437;
        private System.Windows.Forms.Label label143;
        private System.Windows.Forms.Label label142;
        private Guna.UI2.WinForms.Guna2Transition Startup_Transition;
    }
}

