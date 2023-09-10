﻿namespace ShreeWellnessCenter
{
    partial class frmMain
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
            Guna.UI2.AnimatorNS.Animation animation3 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMin = new Guna.UI2.WinForms.Guna2Button();
            this.btnMax = new Guna.UI2.WinForms.Guna2Button();
            this.lblAppName = new System.Windows.Forms.Label();
            this.imgLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.pnlBtnHolder = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnHome = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUser = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlBtnSide = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnInvoice = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlBottam = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.pnlUsrCtrlHolder = new Guna.UI2.WinForms.Guna2Panel();
            this.usr_frmHome2 = new ShreeWellnessCenter.usrFrm.usr_frmHome();
            this.usr_frmControlAdm1 = new ShreeWellnessCenter.usrFrm.usr_frmControlAdm();
            this.usr_frmCustomer1 = new ShreeWellnessCenter.usrFrm.usr_frmCustomer();
            this.usr_frmInvoice1 = new ShreeWellnessCenter.usrFrm.usr_frmInvoice();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnlBtnHolder.SuspendLayout();
            this.pnlUsrCtrlHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlHeader.Controls.Add(this.btnMin);
            this.pnlHeader.Controls.Add(this.btnMax);
            this.pnlHeader.Controls.Add(this.lblAppName);
            this.pnlHeader.Controls.Add(this.imgLogo);
            this.pnlHeader.Controls.Add(this.btnExit);
            this.guna2Transition1.SetDecoration(this.pnlHeader, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1500, 54);
            this.pnlHeader.TabIndex = 12;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            this.pnlHeader.DoubleClick += new System.EventHandler(this.pnlHeader_DoubleClick);
            // 
            // btnMin
            // 
            this.btnMin.Animated = true;
            this.btnMin.AutoRoundedCorners = true;
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.BorderRadius = 26;
            this.guna2Transition1.SetDecoration(this.btnMin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnMin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FillColor = System.Drawing.Color.SandyBrown;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Image = global::KalashBanquetHall.Properties.Resources.minimize;
            this.btnMin.Location = new System.Drawing.Point(1260, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(80, 54);
            this.btnMin.TabIndex = 12;
            this.btnMin.UseTransparentBackground = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Animated = true;
            this.btnMax.AutoRoundedCorners = true;
            this.btnMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMax.BorderRadius = 26;
            this.guna2Transition1.SetDecoration(this.btnMax, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnMax.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMax.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMax.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMax.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FillColor = System.Drawing.Color.SandyBrown;
            this.btnMax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.Image = global::KalashBanquetHall.Properties.Resources.restore;
            this.btnMax.Location = new System.Drawing.Point(1340, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(80, 54);
            this.btnMax.TabIndex = 11;
            this.btnMax.UseTransparentBackground = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lblAppName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblAppName.Font = new System.Drawing.Font("Duffish", 19.8F);
            this.lblAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblAppName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAppName.Location = new System.Drawing.Point(73, 9);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(238, 39);
            this.lblAppName.TabIndex = 10;
            this.lblAppName.Text = "Kalash Banquet Hall";
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.BorderRadius = 10;
            this.guna2Transition1.SetDecoration(this.imgLogo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.imgLogo.Image = global::KalashBanquetHall.Properties.Resources.TitleIco;
            this.imgLogo.ImageRotate = 0F;
            this.imgLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgLogo.Location = new System.Drawing.Point(9, 2);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(57, 50);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 9;
            this.imgLogo.TabStop = false;
            this.imgLogo.UseTransparentBackground = true;
            // 
            // btnExit
            // 
            this.btnExit.Animated = true;
            this.btnExit.AutoRoundedCorners = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderRadius = 26;
            this.guna2Transition1.SetDecoration(this.btnExit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FillColor = System.Drawing.Color.SandyBrown;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::KalashBanquetHall.Properties.Resources.close;
            this.btnExit.Location = new System.Drawing.Point(1420, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 54);
            this.btnExit.TabIndex = 8;
            this.btnExit.UseTransparentBackground = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlBtnHolder
            // 
            this.pnlBtnHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.pnlBtnHolder.Controls.Add(this.btnLogOut);
            this.pnlBtnHolder.Controls.Add(this.btnHome);
            this.pnlBtnHolder.Controls.Add(this.btnUser);
            this.pnlBtnHolder.Controls.Add(this.btnCustomer);
            this.pnlBtnHolder.Controls.Add(this.pnlBtnSide);
            this.pnlBtnHolder.Controls.Add(this.guna2ImageButton1);
            this.pnlBtnHolder.Controls.Add(this.btnInvoice);
            this.guna2Transition1.SetDecoration(this.pnlBtnHolder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlBtnHolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBtnHolder.Location = new System.Drawing.Point(0, 54);
            this.pnlBtnHolder.Name = "pnlBtnHolder";
            this.pnlBtnHolder.Size = new System.Drawing.Size(310, 846);
            this.pnlBtnHolder.TabIndex = 13;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2Transition1.SetDecoration(this.btnLogOut, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnLogOut.HoverState.Image = global::KalashBanquetHall.Properties.Resources.loff_wh__1_;
            this.btnLogOut.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnLogOut.ImageRotate = 0F;
            this.btnLogOut.ImageSize = new System.Drawing.Size(34, 34);
            this.btnLogOut.IndicateFocus = true;
            this.btnLogOut.Location = new System.Drawing.Point(20, 755);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnLogOut.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnLogOut.Size = new System.Drawing.Size(46, 46);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.UseTransparentBackground = true;
            this.btnLogOut.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // btnHome
            // 
            this.guna2Transition1.SetDecoration(this.btnHome, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.SandyBrown;
            this.btnHome.FillColor2 = System.Drawing.Color.Wheat;
            this.btnHome.FocusedColor = System.Drawing.Color.White;
            this.btnHome.Font = new System.Drawing.Font("DokChampa", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnHome.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHome.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnHome.HoverState.ForeColor = System.Drawing.Color.Brown;
            this.btnHome.HoverState.Image = global::KalashBanquetHall.Properties.Resources.hm_wh1;
            this.btnHome.Image = global::KalashBanquetHall.Properties.Resources.hm_gr1;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.ImageSize = new System.Drawing.Size(28, 28);
            this.btnHome.Location = new System.Drawing.Point(20, 105);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHome.Size = new System.Drawing.Size(290, 55);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            this.btnHome.MouseHover += new System.EventHandler(this.btnHome_MouseHover);
            // 
            // btnUser
            // 
            this.guna2Transition1.SetDecoration(this.btnUser, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUser.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUser.FillColor = System.Drawing.Color.SandyBrown;
            this.btnUser.FillColor2 = System.Drawing.Color.Wheat;
            this.btnUser.FocusedColor = System.Drawing.Color.White;
            this.btnUser.Font = new System.Drawing.Font("DokChampa", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnUser.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnUser.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnUser.HoverState.ForeColor = System.Drawing.Color.Brown;
            this.btnUser.HoverState.Image = global::KalashBanquetHall.Properties.Resources.adm_wh1;
            this.btnUser.Image = global::KalashBanquetHall.Properties.Resources.adm_gr__1_1;
            this.btnUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUser.ImageSize = new System.Drawing.Size(28, 28);
            this.btnUser.Location = new System.Drawing.Point(20, 526);
            this.btnUser.Name = "btnUser";
            this.btnUser.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUser.Size = new System.Drawing.Size(290, 55);
            this.btnUser.TabIndex = 6;
            this.btnUser.Text = "Control";
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            this.btnUser.MouseLeave += new System.EventHandler(this.btnUser_MouseLeave);
            this.btnUser.MouseHover += new System.EventHandler(this.btnUser_MouseHover);
            // 
            // btnCustomer
            // 
            this.guna2Transition1.SetDecoration(this.btnCustomer, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomer.FillColor = System.Drawing.Color.SandyBrown;
            this.btnCustomer.FillColor2 = System.Drawing.Color.Wheat;
            this.btnCustomer.FocusedColor = System.Drawing.Color.White;
            this.btnCustomer.Font = new System.Drawing.Font("DokChampa", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnCustomer.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCustomer.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCustomer.HoverState.ForeColor = System.Drawing.Color.Brown;
            this.btnCustomer.HoverState.Image = global::KalashBanquetHall.Properties.Resources.cus_wh1;
            this.btnCustomer.Image = global::KalashBanquetHall.Properties.Resources.cus_gr1;
            this.btnCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomer.ImageSize = new System.Drawing.Size(28, 28);
            this.btnCustomer.Location = new System.Drawing.Point(20, 256);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCustomer.Size = new System.Drawing.Size(290, 55);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            this.btnCustomer.MouseLeave += new System.EventHandler(this.btnCustomer_MouseLeave);
            this.btnCustomer.MouseHover += new System.EventHandler(this.btnCustomer_MouseHover);
            // 
            // pnlBtnSide
            // 
            this.pnlBtnSide.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.pnlBtnSide, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlBtnSide.FillColor = System.Drawing.Color.Red;
            this.pnlBtnSide.Location = new System.Drawing.Point(16, 105);
            this.pnlBtnSide.Name = "pnlBtnSide";
            this.pnlBtnSide.Size = new System.Drawing.Size(5, 55);
            this.pnlBtnSide.TabIndex = 2;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2Transition1.SetDecoration(this.guna2ImageButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ImageButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(34, 34);
            this.guna2ImageButton1.IndicateFocus = true;
            this.guna2ImageButton1.Location = new System.Drawing.Point(20, 6);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.guna2ImageButton1.Size = new System.Drawing.Size(46, 46);
            this.guna2ImageButton1.TabIndex = 1;
            this.guna2ImageButton1.UseTransparentBackground = true;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // btnInvoice
            // 
            this.guna2Transition1.SetDecoration(this.btnInvoice, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnInvoice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInvoice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInvoice.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInvoice.FillColor = System.Drawing.Color.SandyBrown;
            this.btnInvoice.FillColor2 = System.Drawing.Color.Wheat;
            this.btnInvoice.FocusedColor = System.Drawing.Color.White;
            this.btnInvoice.Font = new System.Drawing.Font("DokChampa", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.ForeColor = System.Drawing.Color.White;
            this.btnInvoice.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnInvoice.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnInvoice.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnInvoice.HoverState.ForeColor = System.Drawing.Color.Brown;
            this.btnInvoice.HoverState.Image = global::KalashBanquetHall.Properties.Resources.inv_wh1;
            this.btnInvoice.Image = global::KalashBanquetHall.Properties.Resources.inv_gr1;
            this.btnInvoice.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInvoice.ImageSize = new System.Drawing.Size(28, 28);
            this.btnInvoice.Location = new System.Drawing.Point(20, 178);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInvoice.Size = new System.Drawing.Size(290, 55);
            this.btnInvoice.TabIndex = 0;
            this.btnInvoice.Text = "Booking";
            this.btnInvoice.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            this.btnInvoice.MouseLeave += new System.EventHandler(this.guna2GradientButton1_MouseLeave);
            this.btnInvoice.MouseHover += new System.EventHandler(this.guna2GradientButton1_MouseHover);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.lblAppName;
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
            this.guna2DragControl3.TargetControl = this.pnlHeader;
            this.guna2DragControl3.UseTransparentDrag = true;
            // 
            // pnlBottam
            // 
            this.pnlBottam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.guna2Transition1.SetDecoration(this.pnlBottam, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlBottam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottam.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlBottam.Location = new System.Drawing.Point(310, 894);
            this.pnlBottam.Name = "pnlBottam";
            this.pnlBottam.Size = new System.Drawing.Size(1190, 6);
            this.pnlBottam.TabIndex = 14;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2Transition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation3;
            this.guna2Transition1.MaxAnimationTime = 2000;
            this.guna2Transition1.TimeStep = 0.04F;
            // 
            // pnlUsrCtrlHolder
            // 
            this.pnlUsrCtrlHolder.AutoScroll = true;
            this.pnlUsrCtrlHolder.Controls.Add(this.usr_frmInvoice1);
            this.pnlUsrCtrlHolder.Controls.Add(this.usr_frmCustomer1);
            this.pnlUsrCtrlHolder.Controls.Add(this.usr_frmControlAdm1);
            this.pnlUsrCtrlHolder.Controls.Add(this.usr_frmHome2);
            this.guna2Transition1.SetDecoration(this.pnlUsrCtrlHolder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlUsrCtrlHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUsrCtrlHolder.Location = new System.Drawing.Point(310, 54);
            this.pnlUsrCtrlHolder.Name = "pnlUsrCtrlHolder";
            this.pnlUsrCtrlHolder.Size = new System.Drawing.Size(1190, 840);
            this.pnlUsrCtrlHolder.TabIndex = 15;
            // 
            // usr_frmHome2
            // 
            this.usr_frmHome2.AutoScroll = true;
            this.usr_frmHome2.BackColor = System.Drawing.SystemColors.Info;
            this.usr_frmHome2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usr_frmHome2.BackgroundImage")));
            this.usr_frmHome2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Transition1.SetDecoration(this.usr_frmHome2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.usr_frmHome2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usr_frmHome2.Location = new System.Drawing.Point(0, 0);
            this.usr_frmHome2.Name = "usr_frmHome2";
            this.usr_frmHome2.Size = new System.Drawing.Size(1190, 840);
            this.usr_frmHome2.TabIndex = 0;
            // 
            // usr_frmControlAdm1
            // 
            this.usr_frmControlAdm1.AutoScroll = true;
            this.guna2Transition1.SetDecoration(this.usr_frmControlAdm1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.usr_frmControlAdm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usr_frmControlAdm1.Location = new System.Drawing.Point(0, 0);
            this.usr_frmControlAdm1.Name = "usr_frmControlAdm1";
            this.usr_frmControlAdm1.Size = new System.Drawing.Size(1190, 840);
            this.usr_frmControlAdm1.TabIndex = 1;
            // 
            // usr_frmCustomer1
            // 
            this.usr_frmCustomer1.AutoScroll = true;
            this.guna2Transition1.SetDecoration(this.usr_frmCustomer1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.usr_frmCustomer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usr_frmCustomer1.Location = new System.Drawing.Point(0, 0);
            this.usr_frmCustomer1.Name = "usr_frmCustomer1";
            this.usr_frmCustomer1.Size = new System.Drawing.Size(1190, 840);
            this.usr_frmCustomer1.TabIndex = 2;
            // 
            // usr_frmInvoice1
            // 
            this.guna2Transition1.SetDecoration(this.usr_frmInvoice1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.usr_frmInvoice1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usr_frmInvoice1.Location = new System.Drawing.Point(0, 0);
            this.usr_frmInvoice1.Name = "usr_frmInvoice1";
            this.usr_frmInvoice1.Size = new System.Drawing.Size(1190, 840);
            this.usr_frmInvoice1.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.pnlUsrCtrlHolder);
            this.Controls.Add(this.pnlBottam);
            this.Controls.Add(this.pnlBtnHolder);
            this.Controls.Add(this.pnlHeader);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalash Banquet Hall";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnlBtnHolder.ResumeLayout(false);
            this.pnlUsrCtrlHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblAppName;
        private Guna.UI2.WinForms.Guna2PictureBox imgLogo;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnMin;
        private Guna.UI2.WinForms.Guna2Button btnMax;
        private Guna.UI2.WinForms.Guna2Panel pnlBtnHolder;
        private Guna.UI2.WinForms.Guna2GradientButton btnInvoice;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Panel pnlBtnSide;
        private Guna.UI2.WinForms.Guna2ImageButton btnLogOut;
        private Guna.UI2.WinForms.Guna2GradientButton btnHome;
        private Guna.UI2.WinForms.Guna2GradientButton btnUser;
        private Guna.UI2.WinForms.Guna2GradientButton btnCustomer;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private Guna.UI2.WinForms.Guna2Panel pnlBottam;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private usrFrm.usr_frmHome usr_frmHome1;
        private Guna.UI2.WinForms.Guna2Panel pnlUsrCtrlHolder;
        private usrFrm.usr_frmHome usr_frmHome2;
        private usrFrm.usr_frmControlAdm usr_frmControlAdm1;
        private usrFrm.usr_frmCustomer usr_frmCustomer1;
        private usrFrm.usr_frmInvoice usr_frmInvoice1;
    }
}