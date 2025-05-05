namespace PharmacyManagement.Screen.Pharmacist
{
    partial class UC_Dashbord
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
            DA = new Label();
            panel1 = new Panel();
            btReload = new Guna.UI2.WinForms.Guna2Button();
            chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            pictureBox1 = new PictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DA
            // 
            DA.AutoSize = true;
            DA.Font = new Font("Segoe UI", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            DA.ForeColor = Color.Black;
            DA.Location = new Point(12, 11);
            DA.Name = "DA";
            DA.Size = new Size(153, 45);
            DA.TabIndex = 13;
            DA.Text = "Dashbord";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(btReload);
            panel1.Controls.Add(chartControl1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 900);
            panel1.TabIndex = 14;
            // 
            // btReload
            // 
            btReload.BackColor = Color.Transparent;
            btReload.BorderRadius = 15;
            btReload.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            btReload.CustomizableEdges = customizableEdges1;
            btReload.DisabledState.BorderColor = Color.DarkGray;
            btReload.DisabledState.CustomBorderColor = Color.DarkGray;
            btReload.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btReload.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btReload.FillColor = Color.DarkSlateGray;
            btReload.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btReload.ForeColor = Color.White;
            btReload.Image = Properties.Resources._8563460;
            btReload.ImageSize = new Size(25, 25);
            btReload.Location = new Point(722, 833);
            btReload.Name = "btReload";
            btReload.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btReload.Size = new Size(112, 45);
            btReload.TabIndex = 139;
            btReload.Text = "Reload";
            btReload.Click += btReload_Click;
            // 
            // chartControl1
            // 
            chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(255, 192, 192));
            chartControl1.ChartArea.CursorLocation = new Point(0, 0);
            chartControl1.ChartArea.CursorReDraw = false;
            // 
            // 
            // 
            chartControl1.Legend.Location = new Point(208, 31);
            chartControl1.Location = new Point(533, 167);
            chartControl1.Name = "chartControl1";
            chartControl1.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            chartControl1.PrimaryXAxis.Margin = true;
            chartControl1.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            chartControl1.PrimaryYAxis.Margin = true;
            chartControl1.Size = new Size(317, 660);
            chartControl1.TabIndex = 2;
            // 
            // 
            // 
            chartControl1.Title.Name = "Default";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dashboard;
            pictureBox1.Location = new Point(53, 167);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(471, 689);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // UC_Dashbord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(DA);
            Name = "UC_Dashbord";
            Size = new Size(882, 1049);
            Load += UC_Dashbord_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DA;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private Guna.UI2.WinForms.Guna2Button btReload;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
