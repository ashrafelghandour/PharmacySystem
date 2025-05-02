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
using PharmacyManagement.Screen.Parmacit;

namespace PharmacyManagement.Screen.Administrator
{
    public partial class UCDashbord : UserControl
    {
        public UCDashbord()
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
            }
        }



        private void _RelodedData()
        {
            using (AppDbContext db = new AppDbContext())
            {
                var users = db.Users.ToList();

                lbsumuser.Text = users.FindAll(u => u.Role == "Administrator").Count().ToString();
                lllSumPhrama.Text = users.FindAll(u => u.Role == "Pharmacist").Count().ToString();
                //   lbsumcustomer.Text = db.Users.ToList().TakeWhile(u => u.Role == "Customer").Count().ToString();

            }
        }

        private void UC_AddNewUser_Load(object sender, EventArgs e)
        {
            _RelodedData();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            _RelodedData();
        }
    }
}
