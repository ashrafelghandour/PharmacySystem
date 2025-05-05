namespace PharmacyManagement.Screen.Pharmacist
{
    partial class UC_MedicineValidityCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_MedicineValidityCheck));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            btdelete = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            CBCheck = new ComboBox();
            DGVlist = new Guna.UI2.WinForms.Guna2DataGridView();
            lbSet = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVlist).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 16);
            label1.Name = "label1";
            label1.Size = new Size(217, 26);
            label1.TabIndex = 96;
            label1.Text = "Medicine Validity Check";
            // 
            // btdelete
            // 
            btdelete.BorderRadius = 15;
            btdelete.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            btdelete.BorderThickness = 2;
            btdelete.CustomizableEdges = customizableEdges1;
            btdelete.DisabledState.BorderColor = Color.DarkGray;
            btdelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btdelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btdelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btdelete.FillColor = Color.Silver;
            btdelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btdelete.ForeColor = Color.Black;
            btdelete.Image = (Image)resources.GetObject("btdelete.Image");
            btdelete.ImageSize = new Size(25, 25);
            btdelete.Location = new Point(752, 956);
            btdelete.Name = "btdelete";
            btdelete.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btdelete.Size = new Size(112, 51);
            btdelete.TabIndex = 102;
            btdelete.Text = "Delete";
            btdelete.Click += btdelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(237, 198);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 99;
            label2.Text = " Check";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // CBCheck
            // 
            CBCheck.BackColor = Color.DimGray;
            CBCheck.FormattingEnabled = true;
            CBCheck.Items.AddRange(new object[] { "Valid Medicine", "Expired Medicine", "View All Medicine" });
            CBCheck.Location = new Point(247, 229);
            CBCheck.Name = "CBCheck";
            CBCheck.Size = new Size(155, 23);
            CBCheck.TabIndex = 105;
            CBCheck.SelectedIndexChanged += CBCheck_SelectedIndexChanged;
            // 
            // DGVlist
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DGVlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGVlist.BackgroundColor = Color.LightGray;
            DGVlist.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGVlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGVlist.DefaultCellStyle = dataGridViewCellStyle3;
            DGVlist.GridColor = Color.FromArgb(231, 229, 255);
            DGVlist.Location = new Point(19, 307);
            DGVlist.Name = "DGVlist";
            DGVlist.RowHeadersVisible = false;
            DGVlist.Size = new Size(845, 592);
            DGVlist.TabIndex = 98;
            DGVlist.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DGVlist.ThemeStyle.AlternatingRowsStyle.Font = null;
            DGVlist.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DGVlist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DGVlist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DGVlist.ThemeStyle.BackColor = Color.LightGray;
            DGVlist.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DGVlist.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DGVlist.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DGVlist.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            DGVlist.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DGVlist.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DGVlist.ThemeStyle.HeaderStyle.Height = 23;
            DGVlist.ThemeStyle.ReadOnly = false;
            DGVlist.ThemeStyle.RowsStyle.BackColor = Color.White;
            DGVlist.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGVlist.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            DGVlist.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DGVlist.ThemeStyle.RowsStyle.Height = 25;
            DGVlist.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DGVlist.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // lbSet
            // 
            lbSet.AutoSize = true;
            lbSet.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbSet.Location = new Point(19, 248);
            lbSet.Name = "lbSet";
            lbSet.Size = new Size(52, 19);
            lbSet.TabIndex = 106;
            lbSet.Text = " Check";
            // 
            // UC_MedicineValidityCheck
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(lbSet);
            Controls.Add(CBCheck);
            Controls.Add(DGVlist);
            Controls.Add(label1);
            Controls.Add(btdelete);
            Controls.Add(label2);
            Name = "UC_MedicineValidityCheck";
            Size = new Size(878, 1051);
            Load += UC_MedicineValidityCheck_Load;
            ((System.ComponentModel.ISupportInitialize)DGVlist).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btdelete;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private ComboBox CBCheck;
        private Guna.UI2.WinForms.Guna2DataGridView DGVlist;
        private Label lbSet;
    }
}
