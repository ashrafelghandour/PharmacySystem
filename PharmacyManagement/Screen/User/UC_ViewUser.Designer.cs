namespace PharmacyManagement.Screen.User
{
    partial class UC_ViewUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ViewUser));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            tbsearch = new Guna.UI2.WinForms.Guna2TextBox();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            iamge = new DataGridViewImageColumn();
            label2 = new Label();
            btresetdata = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            btdelete = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 42);
            label1.Name = "label1";
            label1.Size = new Size(99, 26);
            label1.TabIndex = 79;
            label1.Text = "View User";
            // 
            // tbsearch
            // 
            tbsearch.CustomizableEdges = customizableEdges1;
            tbsearch.DefaultText = "";
            tbsearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbsearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbsearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbsearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbsearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbsearch.Font = new Font("Segoe UI", 9F);
            tbsearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbsearch.Location = new Point(233, 209);
            tbsearch.Name = "tbsearch";
            tbsearch.PlaceholderText = "Search-----------------------------------";
            tbsearch.SelectedText = "";
            tbsearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tbsearch.Size = new Size(220, 31);
            tbsearch.TabIndex = 80;
            tbsearch.TextChanged += tbEmail_TextChanged;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Name, UserName, Email, iamge });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(15, 287);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.Size = new Size(845, 592);
            guna2DataGridView1.TabIndex = 81;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 23;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ID.FillWeight = 76.1421356F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.SortMode = DataGridViewColumnSortMode.NotSortable;
            ID.Width = 158;
            // 
            // Name
            // 
            Name.FillWeight = 107.578148F;
            Name.HeaderText = "Name";
            Name.Name = "Name";
            // 
            // UserName
            // 
            UserName.FillWeight = 106.047562F;
            UserName.HeaderText = "UserName";
            UserName.Name = "UserName";
            // 
            // Email
            // 
            Email.FillWeight = 107.007813F;
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // iamge
            // 
            iamge.FillWeight = 103.224388F;
            iamge.HeaderText = "image";
            iamge.Name = "iamge";
            iamge.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(233, 178);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 82;
            label2.Text = "User Name";
            // 
            // btresetdata
            // 
            btresetdata.BackColor = Color.Transparent;
            btresetdata.BorderColor = Color.Transparent;
            btresetdata.Cursor = Cursors.Hand;
            btresetdata.CustomizableEdges = customizableEdges3;
            btresetdata.DisabledState.BorderColor = Color.DarkGray;
            btresetdata.DisabledState.CustomBorderColor = Color.DarkGray;
            btresetdata.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btresetdata.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btresetdata.FillColor = Color.Transparent;
            btresetdata.Font = new Font("Segoe UI", 9F);
            btresetdata.ForeColor = Color.Transparent;
            btresetdata.HoverState.ForeColor = Color.White;
            btresetdata.Image = Properties.Resources.sync_64px;
            btresetdata.ImageSize = new Size(30, 30);
            btresetdata.Location = new Point(148, 42);
            btresetdata.Name = "btresetdata";
            btresetdata.PressedColor = Color.White;
            btresetdata.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btresetdata.Size = new Size(30, 28);
            btresetdata.TabIndex = 86;
            btresetdata.Click += btresetdata_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sync;
            pictureBox1.Location = new Point(125, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 85;
            pictureBox1.TabStop = false;
            // 
            // btdelete
            // 
            btdelete.BorderRadius = 15;
            btdelete.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            btdelete.BorderThickness = 2;
            btdelete.CustomizableEdges = customizableEdges5;
            btdelete.DisabledState.BorderColor = Color.DarkGray;
            btdelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btdelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btdelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btdelete.FillColor = Color.Silver;
            btdelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btdelete.ForeColor = Color.Black;
            btdelete.Image = (Image)resources.GetObject("btdelete.Image");
            btdelete.ImageSize = new Size(25, 25);
            btdelete.Location = new Point(748, 936);
            btdelete.Name = "btdelete";
            btdelete.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btdelete.Size = new Size(112, 51);
            btdelete.TabIndex = 87;
            btdelete.Text = "Delete";
            btdelete.Click += btdelete_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // UC_ViewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(btdelete);
            Controls.Add(btresetdata);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(guna2DataGridView1);
            Controls.Add(tbsearch);
            Controls.Add(label1);
            Size = new Size(882, 1055);
            Load += UC_ViewUser_Load;
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbsearch;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button btresetdata;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btdelete;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewImageColumn iamge;
    }
}
