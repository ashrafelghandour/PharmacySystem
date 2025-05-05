using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyManagement.Data;
using PharmacyManagement.Entites;
using Syncfusion.Windows.Forms.Chart;

namespace PharmacyManagement.Screen.Pharmacist
{
    public partial class UC_Dashbord : UserControl
    {
        public UC_Dashbord()
        {
            InitializeComponent();
            this.chartControl1.Series.Clear();

            var series1 = new ChartSeries { Name = "Expired Medicines", Text = "Expired Medicines" };

            var series2 = new ChartSeries { Name = "Valid Medicines", Text = "Valid Medicines" };





            this.chartControl1.Series.Add(series1);
            this.chartControl1.Series.Add(series2);
        }

        private void UC_Dashbord_Load(object sender, EventArgs e)
        {
            LoadChart();
        }


        public void LoadChart()
        {
            using (AppDbContext dbContext = new AppDbContext())
            {


                var countEdate = dbContext.Medicines.Where(m => m.Edate >= DateOnly.FromDateTime(DateTime.Now)).ToList().Count();
                var MDate = dbContext.Medicines.Where(m => m.MDate <= DateOnly.FromDateTime(DateTime.Now)).ToList().Count();

                this.chartControl1.Series["Valid Medicines"].Points.Add("Medicine Validity Chary", countEdate);

                this.chartControl1.Series["Expired Medicines"].Points.Add("Expired  Validity Chary", MDate);


            }
        }

        private void btReload_Click(object sender, EventArgs e)
        {
            this.chartControl1.Series["Valid Medicines"].Points.Clear();


            this.chartControl1.Series["Expired Medicines"].Points.Clear();
            LoadChart();

        }
    }
}
