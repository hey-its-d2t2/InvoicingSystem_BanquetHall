﻿namespace ShreeWellnessCenter
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtUsrName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.imgLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.loadingBar = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.txtUsrPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblInvalidUsrPassword = new System.Windows.Forms.Label();
            this.lblInvalidUsrName = new System.Windows.Forms.Label();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 16;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::KalashBanquetHall.Properties.Resources.hand;
            this.guna2PictureBox1.ImageRotate = 0F;
            resources.ApplyResources(this.guna2PictureBox1, "guna2PictureBox1");
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.TabStop = false;
            // 
            // txtUsrName
            // 
            this.txtUsrName.Animated = true;
            this.txtUsrName.AutoRoundedCorners = true;
            resources.ApplyResources(this.txtUsrName, "txtUsrName");
            this.txtUsrName.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtUsrName.BorderColor = System.Drawing.Color.SandyBrown;
            this.txtUsrName.BorderRadius = 23;
            this.txtUsrName.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtUsrName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsrName.DefaultText = "";
            this.txtUsrName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsrName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsrName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsrName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsrName.FillColor = System.Drawing.SystemColors.Info;
            this.txtUsrName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtUsrName.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtUsrName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtUsrName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtUsrName.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtUsrName.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtUsrName.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtUsrName.IconLeft")));
            this.txtUsrName.MaxLength = 16;
            this.txtUsrName.Name = "txtUsrName";
            this.txtUsrName.PasswordChar = '\0';
            this.txtUsrName.PlaceholderForeColor = System.Drawing.Color.SandyBrown;
            this.txtUsrName.PlaceholderText = "उपयोगकर्ता का नाम";
            this.txtUsrName.SelectedText = "";
            this.txtUsrName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUsrName.WordWrap = false;
            this.txtUsrName.Click += new System.EventHandler(this.txtUsrName_Click);
            this.txtUsrName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsrName_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderColor = System.Drawing.Color.SandyBrown;
            this.btnLogin.BorderRadius = 26;
            this.btnLogin.BorderThickness = 1;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.Transparent;
            this.btnLogin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.Wheat;
            this.btnLogin.HoverState.Font = new System.Drawing.Font("DokChampa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PressedColor = System.Drawing.Color.Wheat;
            this.btnLogin.ShadowDecoration.BorderRadius = 2;
            this.btnLogin.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.guna2Panel1.Controls.Add(this.lblAppName);
            this.guna2Panel1.Controls.Add(this.imgLogo);
            this.guna2Panel1.Controls.Add(this.btnExit);
            resources.ApplyResources(this.guna2Panel1, "guna2Panel1");
            this.guna2Panel1.Name = "guna2Panel1";
            // 
            // lblAppName
            // 
            resources.ApplyResources(this.lblAppName, "lblAppName");
            this.lblAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblAppName.Name = "lblAppName";
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.BorderRadius = 10;
            this.imgLogo.Image = global::KalashBanquetHall.Properties.Resources.TitleIco;
            this.imgLogo.ImageRotate = 0F;
            resources.ApplyResources(this.imgLogo, "imgLogo");
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.TabStop = false;
            this.imgLogo.UseTransparentBackground = true;
            // 
            // btnExit
            // 
            this.btnExit.Animated = true;
            this.btnExit.AutoRoundedCorners = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderRadius = 26;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.FillColor = System.Drawing.Color.SandyBrown;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::KalashBanquetHall.Properties.Resources.close;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseTransparentBackground = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.SystemColors.Info;
            this.guna2ShadowPanel1.Controls.Add(this.loadingBar);
            this.guna2ShadowPanel1.Controls.Add(this.txtUsrPass);
            this.guna2ShadowPanel1.Controls.Add(this.lblInvalidUsrPassword);
            this.guna2ShadowPanel1.Controls.Add(this.lblInvalidUsrName);
            this.guna2ShadowPanel1.Controls.Add(this.lblForgotPassword);
            this.guna2ShadowPanel1.Controls.Add(this.lblMessage);
            this.guna2ShadowPanel1.Controls.Add(this.btnLogin);
            this.guna2ShadowPanel1.Controls.Add(this.txtUsrName);
            this.guna2ShadowPanel1.FillColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.guna2ShadowPanel1, "guna2ShadowPanel1");
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Brown;
            this.guna2ShadowPanel1.ShadowShift = 16;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            // 
            // loadingBar
            // 
            this.loadingBar.AnimationSpeed = 65;
            this.loadingBar.AutoStart = true;
            this.loadingBar.BackColor = System.Drawing.Color.Transparent;
            this.loadingBar.CircleSize = 1F;
            resources.ApplyResources(this.loadingBar, "loadingBar");
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.NumberOfCircles = 7;
            this.loadingBar.ProgressColor = System.Drawing.Color.SandyBrown;
            this.loadingBar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(180)))), ((int)(((byte)(95)))));
            this.loadingBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.loadingBar.UseTransparentBackground = true;
            // 
            // txtUsrPass
            // 
            this.txtUsrPass.Animated = true;
            this.txtUsrPass.AutoRoundedCorners = true;
            resources.ApplyResources(this.txtUsrPass, "txtUsrPass");
            this.txtUsrPass.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtUsrPass.BorderColor = System.Drawing.Color.SandyBrown;
            this.txtUsrPass.BorderRadius = 23;
            this.txtUsrPass.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtUsrPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsrPass.DefaultText = "";
            this.txtUsrPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsrPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsrPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsrPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsrPass.FillColor = System.Drawing.SystemColors.Info;
            this.txtUsrPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtUsrPass.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtUsrPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtUsrPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtUsrPass.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtUsrPass.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtUsrPass.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtUsrPass.IconLeft")));
            this.txtUsrPass.MaxLength = 16;
            this.txtUsrPass.Name = "txtUsrPass";
            this.txtUsrPass.PasswordChar = '●';
            this.txtUsrPass.PlaceholderForeColor = System.Drawing.Color.SandyBrown;
            this.txtUsrPass.PlaceholderText = "पासवर्ड";
            this.txtUsrPass.SelectedText = "";
            this.txtUsrPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUsrPass.UseSystemPasswordChar = true;
            this.txtUsrPass.WordWrap = false;
            this.txtUsrPass.Click += new System.EventHandler(this.txtUsrPass_Click);
            this.txtUsrPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsrPass_KeyDown);
            // 
            // lblInvalidUsrPassword
            // 
            resources.ApplyResources(this.lblInvalidUsrPassword, "lblInvalidUsrPassword");
            this.lblInvalidUsrPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalidUsrPassword.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblInvalidUsrPassword.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidUsrPassword.Name = "lblInvalidUsrPassword";
            // 
            // lblInvalidUsrName
            // 
            resources.ApplyResources(this.lblInvalidUsrName, "lblInvalidUsrName");
            this.lblInvalidUsrName.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalidUsrName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblInvalidUsrName.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidUsrName.Name = "lblInvalidUsrName";
            // 
            // lblForgotPassword
            // 
            resources.ApplyResources(this.lblForgotPassword, "lblForgotPassword");
            this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPassword.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Click += new System.EventHandler(this.lblForgotPassword_Click);
            this.lblForgotPassword.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.lblForgotPassword.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // lblMessage
            // 
            resources.ApplyResources(this.lblMessage, "lblMessage");
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblMessage.Name = "lblMessage";
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 25;
            this.guna2Elipse2.TargetControl = this.guna2ShadowPanel1;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.imgLogo;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl3.TargetControl = this.lblAppName;
            this.guna2DragControl3.UseTransparentDrag = true;
            // 
            // guna2Panel2
            // 
            resources.ApplyResources(this.guna2Panel2, "guna2Panel2");
            this.guna2Panel2.FillColor = System.Drawing.Color.Brown;
            this.guna2Panel2.Name = "guna2Panel2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.circularProgressBar1, "circularProgressBar1");
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Maximum = 100000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(180)))), ((int)(((byte)(150)))));
            this.circularProgressBar1.ProgressWidth = 4;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Tahoma", 36F);
            this.circularProgressBar1.StartAngle = 250;
            this.circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 2;
            // 
            // frm_login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_login";
            this.Load += new System.EventHandler(this.frm_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TileButton btnLogin;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblAppName;
        private Guna.UI2.WinForms.Guna2PictureBox imgLogo;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2TextBox txtUsrName;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblInvalidUsrPassword;
        private System.Windows.Forms.Label lblInvalidUsrName;
        private Guna.UI2.WinForms.Guna2TextBox txtUsrPass;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator loadingBar;
        private System.Windows.Forms.Timer timer1;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
    }
}