using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyManagement.Classes;
using PharmacyManagement.Data;
using PharmacyManagement.Entites;
using PharmacyManagement.Screen.User;

namespace PharmacyManagement.Screen.Parmacit
{
    //uC_AddMedicine3 = new Pharmacist.UC_AddMedicine(clsGlobal.Medicine);
    //       uC_AddMedicine2 = new Pharmacist.UC_AddMedicine(clsGlobal.Medicine);
    //       uC_AddNewUse1 = new User.UC_AddNewUse(clsGlobal.CurrentUser);
    public partial class frmPharmacist : Form
    {
        public frmPharmacist()
        {
            InitializeComponent();
            lblusername.Text = clsGlobal.CurrentUser.UserName;
        }




        private void btDashbord_Click(object sender, EventArgs e)
        {
            uC_Dashbord1.Visible
                = true;
            uC_Dashbord1.BringToFront();
        }

        private void frmPharmacist_Load(object sender, EventArgs e)
        {
            uC_Dashbord1.Visible = false;
            btDashbord.PerformClick();
            uC_AddMedicine1.Visible = false;
            uC_ViewMedicine1.Visible = false;
            uC_AddNewUse1.Visible = false;
            uC_Sell_Medicine1.Visible = false;
            uC_AddMedicine2.Visible = false;
            uC_AddMedicine3.Visible = false;
            uC_MedicineValidityCheck1.Visible = false;


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAddUser_Click(object sender, EventArgs e)
        {
            uC_AddMedicine1.Visible = true;
            uC_AddMedicine1.BringToFront();
        }

        private void btViewUser_Click(object sender, EventArgs e)
        {
            uC_ViewMedicine1.DataBack += DataBackEvent;
            uC_ViewMedicine1.Visible = true;
            uC_ViewMedicine1.BringToFront();
        }
        private void DataBackEvent(object arg1, int medicineID)
        {
            try
            {


                using (AppDbContext db = new AppDbContext())
                {

                    clsGlobal.Medicine = db.Medicines.FirstOrDefault(m => m.Id == medicineID);

                    if (clsGlobal.Medicine == null)
                    {


                        MessageBox.Show("This Medicine is not found", "not find", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    uC_AddMedicine2._medicine = clsGlobal.Medicine;
                    uC_AddMedicine2._LodDatatolabl();
                    uC_AddMedicine2.Visible = true;
                    uC_AddMedicine2.BringToFront();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btsginout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }

        private void btProfile_Click(object sender, EventArgs e)
        {
            llUserProfil frm = new llUserProfil();
            frm.DataBack += DataBackEvent;

            frm.ShowDialog();
        }

        private void DataBackEvent(object arg1, Entites.User user)
        {

            uC_AddNewUse1.Visible = true;
            uC_AddNewUse1.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            uC_AddMedicine3.Visible = true;
            uC_AddMedicine3.lbMedicinenumber.Visible = true;
            uC_AddMedicine3.tbsearch.Visible = true;
            uC_AddMedicine3.btSearch.Visible = true;

            uC_AddMedicine3._medicine = clsGlobal.Medicine;
            uC_AddMedicine3._LodDatatolabl();

            uC_AddMedicine3.BringToFront();
        }


        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            uC_MedicineValidityCheck1.Visible = true;
            uC_MedicineValidityCheck1.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //    
            //
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            uC_Sell_Medicine1.Visible = true;
            uC_Sell_Medicine1.BringToFront();
        }

        private void uC_Sell_Medicine1_Load(object sender, EventArgs e)
        {

        }
    }
}
