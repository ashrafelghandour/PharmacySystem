using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using PharmacyManagement.Data;

namespace PharmacyManagement.Screen.Pharmacist
{
    public partial class UC_MedicineValidityCheck : UserControl
    {
        public UC_MedicineValidityCheck()
        {
            InitializeComponent();
        }

        private void UC_MedicineValidityCheck_Load(object sender, EventArgs e)
        {
            lbSet.Text = "";
        }

        private void CBCheck_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {


                using (AppDbContext db = new AppDbContext())
                {



                    switch (CBCheck.SelectedIndex)
                    {
                        


                        case 0:

                            DGVlist.DataSource = db.Medicines.Where(m => m.Edate >= DateOnly.FromDateTime(DateTime.Now)).ToList();
                        lbSet.Text = "Valid Medicine";
                           lbSet.ForeColor = Color.Black;
                            break;
                        case 1:

                            DGVlist.DataSource = db.Medicines.Where(m => m.Edate < DateOnly.FromDateTime(DateTime.Now)).ToList();
                             lbSet.Text = "Expired Medicine";
                            lbSet.ForeColor = Color.Red;

                            break;
                        case 2:

                            DGVlist.DataSource = db.Medicines.ToList();
                            lbSet.Text = "View All Medicine";
                            lbSet.ForeColor = Color.Black;
                            break;
                        default:
                            break;


                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("you need delete Product", "Delete", MessageBoxButtons.YesNoCancel);


                if (result == DialogResult.Yes)
                {



                    using (AppDbContext dbContext = new AppDbContext())
                    {

                        if (DGVlist.CurrentRow != null)
                        {
                            int medicineId = Convert.ToInt32(DGVlist.CurrentRow.Cells[0].Value);

                            dbContext.Medicines.Remove(new Entites.Medicine { Id = medicineId });

                            dbContext.SaveChanges();
                            MessageBox.Show("Data Deleted Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }


                    }


                }
            }


            catch (Exception ex)
            {

                MessageBox.Show("Error: Data Is not Deleted Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
