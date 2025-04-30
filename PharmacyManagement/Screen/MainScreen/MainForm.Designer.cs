namespace PharmacyManagement.Screen.MainScreen
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            lblusername = new Label();
            btsginout = new Guna.UI2.WinForms.Guna2Button();
            btProfile = new Guna.UI2.WinForms.Guna2Button();
            pictureBox3 = new PictureBox();
            btViewUser = new Guna.UI2.WinForms.Guna2Button();
            btAddUser = new Guna.UI2.WinForms.Guna2Button();
            btDashbord = new Guna.UI2.WinForms.Guna2Button();
            lbUsername = new Label();
            pictureBox1 = new PictureBox();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            uC_AddUser1 = new User.UC_AddNewUse();
            ucDashbord1 = new Administrator.UCDashbord();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            uC_ViewUser1 = new User.UC_ViewUser();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2CustomGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(lblusername);
            panel1.Controls.Add(btsginout);
            panel1.Controls.Add(btProfile);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btViewUser);
            panel1.Controls.Add(btAddUser);
            panel1.Controls.Add(btDashbord);
            panel1.Controls.Add(lbUsername);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 1046);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // lblusername
            // 
            lblusername.Font = new Font("Segoe UI", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblusername.ForeColor = Color.White;
            lblusername.Location = new Point(0, 943);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(365, 45);
            lblusername.TabIndex = 56;
            lblusername.Text = "User :";
            lblusername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btsginout
            // 
            btsginout.BorderRadius = 15;
            btsginout.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            btsginout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btsginout.CustomizableEdges = customizableEdges1;
            btsginout.DisabledState.BorderColor = Color.DarkGray;
            btsginout.DisabledState.CustomBorderColor = Color.DarkGray;
            btsginout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btsginout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btsginout.FillColor = Color.FromArgb(64, 64, 64);
            btsginout.Font = new Font("Segoe UI", 9F);
            btsginout.ForeColor = Color.Black;
            btsginout.Image = (Image)resources.GetObject("btsginout.Image");
            btsginout.ImageSize = new Size(25, 25);
            btsginout.Location = new Point(49, 805);
            btsginout.Name = "btsginout";
            btsginout.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btsginout.Size = new Size(188, 45);
            btsginout.TabIndex = 55;
            btsginout.Text = "Sing out";
            btsginout.Click += btsginout_Click;
            // 
            // btProfile
            // 
            btProfile.BorderRadius = 15;
            btProfile.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            btProfile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btProfile.CustomizableEdges = customizableEdges3;
            btProfile.DisabledState.BorderColor = Color.DarkGray;
            btProfile.DisabledState.CustomBorderColor = Color.DarkGray;
            btProfile.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btProfile.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btProfile.FillColor = Color.FromArgb(64, 64, 64);
            btProfile.Font = new Font("Segoe UI", 9F);
            btProfile.ForeColor = Color.Black;
            btProfile.Image = (Image)resources.GetObject("btProfile.Image");
            btProfile.ImageSize = new Size(25, 25);
            btProfile.Location = new Point(49, 726);
            btProfile.Name = "btProfile";
            btProfile.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btProfile.Size = new Size(188, 45);
            btProfile.TabIndex = 54;
            btProfile.Text = "Profile";
            btProfile.Click += btProfile_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(302, 28);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 48;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // btViewUser
            // 
            btViewUser.BorderRadius = 15;
            btViewUser.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            btViewUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btViewUser.CustomizableEdges = customizableEdges5;
            btViewUser.DisabledState.BorderColor = Color.DarkGray;
            btViewUser.DisabledState.CustomBorderColor = Color.DarkGray;
            btViewUser.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btViewUser.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btViewUser.FillColor = Color.FromArgb(64, 64, 64);
            btViewUser.Font = new Font("Segoe UI", 9F);
            btViewUser.ForeColor = Color.Black;
            btViewUser.Image = (Image)resources.GetObject("btViewUser.Image");
            btViewUser.ImageSize = new Size(25, 25);
            btViewUser.Location = new Point(49, 637);
            btViewUser.Name = "btViewUser";
            btViewUser.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btViewUser.Size = new Size(188, 45);
            btViewUser.TabIndex = 53;
            btViewUser.Text = "View User";
            btViewUser.Click += btViewUser_Click;
            // 
            // btAddUser
            // 
            btAddUser.BorderRadius = 15;
            btAddUser.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            btAddUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btAddUser.CustomizableEdges = customizableEdges7;
            btAddUser.DisabledState.BorderColor = Color.DarkGray;
            btAddUser.DisabledState.CustomBorderColor = Color.DarkGray;
            btAddUser.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btAddUser.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btAddUser.FillColor = Color.FromArgb(64, 64, 64);
            btAddUser.Font = new Font("Segoe UI", 9F);
            btAddUser.ForeColor = Color.Black;
            btAddUser.Image = (Image)resources.GetObject("btAddUser.Image");
            btAddUser.ImageSize = new Size(25, 25);
            btAddUser.Location = new Point(49, 557);
            btAddUser.Name = "btAddUser";
            btAddUser.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btAddUser.Size = new Size(188, 45);
            btAddUser.TabIndex = 52;
            btAddUser.Text = "Add User";
            btAddUser.Click += btAddUser_Click;
            // 
            // btDashbord
            // 
            btDashbord.BorderColor = Color.FromArgb(0, 64, 0);
            btDashbord.BorderRadius = 15;
            btDashbord.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            btDashbord.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btDashbord.CustomizableEdges = customizableEdges9;
            btDashbord.DisabledState.BorderColor = Color.DarkGray;
            btDashbord.DisabledState.CustomBorderColor = Color.DarkGray;
            btDashbord.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btDashbord.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btDashbord.FillColor = Color.FromArgb(64, 64, 64);
            btDashbord.Font = new Font("Segoe UI", 9F);
            btDashbord.ForeColor = Color.Black;
            btDashbord.Image = (Image)resources.GetObject("btDashbord.Image");
            btDashbord.ImageSize = new Size(25, 25);
            btDashbord.Location = new Point(49, 506);
            btDashbord.Name = "btDashbord";
            btDashbord.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btDashbord.Size = new Size(188, 45);
            btDashbord.TabIndex = 51;
            btDashbord.Text = "Dashbord";
            btDashbord.Click += btDashbord_Click;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbUsername.ForeColor = Color.White;
            lbUsername.Location = new Point(43, 361);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(207, 45);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Administrator";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.istockphoto_1296122583_612x612;
            pictureBox1.Location = new Point(49, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 277);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.Controls.Add(uC_ViewUser1);
            guna2CustomGradientPanel1.Controls.Add(uC_AddUser1);
            guna2CustomGradientPanel1.Controls.Add(ucDashbord1);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges11;
            guna2CustomGradientPanel1.Location = new Point(375, 0);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2CustomGradientPanel1.Size = new Size(932, 1046);
            guna2CustomGradientPanel1.TabIndex = 2;
            // 
            // uC_AddUser1
            // 
            uC_AddUser1.BackColor = Color.DimGray;
            uC_AddUser1.Location = new Point(0, 0);
            uC_AddUser1.Name = "uC_AddUser1";
            uC_AddUser1.Size = new Size(882, 1133);
            uC_AddUser1.TabIndex = 1;
            uC_AddUser1.Load += uC_AddUser1_Load_1;
            // 
            // ucDashbord1
            // 
            ucDashbord1.BackColor = Color.White;
            ucDashbord1.Location = new Point(0, -33);
            ucDashbord1.Name = "ucDashbord1";
            ucDashbord1.Size = new Size(882, 1049);
            ucDashbord1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = guna2CustomGradientPanel1;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.TargetControl = guna2CustomGradientPanel1;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.TargetControl = guna2CustomGradientPanel1;
            // 
            // uC_ViewUser1
            // 
            uC_ViewUser1.BackColor = SystemColors.ControlDarkDark;
            uC_ViewUser1.Location = new Point(3, 0);
            uC_ViewUser1.Name = "uC_ViewUser1";
            uC_ViewUser1.Size = new Size(882, 1133);
            uC_ViewUser1.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1295, 1044);
            Controls.Add(guna2CustomGradientPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2CustomGradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lbUsername;
        private Guna.UI2.WinForms.Guna2Button btDashbord;
        private Guna.UI2.WinForms.Guna2Button btsginout;
        private Guna.UI2.WinForms.Guna2Button btProfile;
        private Guna.UI2.WinForms.Guna2Button btViewUser;
        private Guna.UI2.WinForms.Guna2Button btAddUser;
        private PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Administrator.UCDashbord ucDashbord1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private User.UC_AddNewUse uC_AddUser1;
        private Label lblusername;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private User.UC_ViewUser uC_ViewUser1;
    }
}