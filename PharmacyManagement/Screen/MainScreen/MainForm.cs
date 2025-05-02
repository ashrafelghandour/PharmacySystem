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
using PharmacyManagement.Screen.Administrator;
using PharmacyManagement.Screen.User;

namespace PharmacyManagement.Screen.MainScreen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btsginout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();

        }

        private void btDashbord_Click(object sender, EventArgs e)
        {
           ucDashbord1.Visible = true;
           uC_AddUser1.Visible = false;

            ucDashbord1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void btAddUser_Click(object sender, EventArgs e)
        {
            ucDashbord1.Visible = false;
            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            lblusername.Text = clsGlobal.CurrentUser.UserName.ToString();
            ucDashbord1.Visible = false;
            uC_AddUser1.Visible = false;
            uC_ViewUser1.Visible = false;
            btDashbord.PerformClick();
        }

        private void ucDashbord1_Load(object sender, EventArgs e)
        {

        }

        private void btProfile_Click(object sender, EventArgs e)
        {
            llUserProfil frm = new llUserProfil();
            frm.DataBack += DataBackEvent;

            frm.ShowDialog();

        }

        private void DataBackEvent(object sender, Entites.User user)
        {
              ucDashbord1.Visible = false;
              uC_AddNewUse1.Visible = true;
            uC_AddNewUse1.BringToFront();
 
        }

        

        private void uC_AddUser1_Load(object sender, EventArgs e)
        {

        }

        private void uC_AddUser1_Load_1(object sender, EventArgs e)
        {

        }

        private void btViewUser_Click(object sender, EventArgs e)
        {
            uC_ViewUser1.Visible = true;
            uC_ViewUser1.BringToFront();
        }
    }
}
