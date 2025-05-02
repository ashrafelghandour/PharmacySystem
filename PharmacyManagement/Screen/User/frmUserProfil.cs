using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using PharmacyManagement.Classes;
using PharmacyManagement.Data;

namespace PharmacyManagement.Screen.User
{
    public partial class llUserProfil : Form
    {
        public llUserProfil()
        {
            InitializeComponent();
            btsave.Visible = false;
            label1.Visible = false;
            label10.Visible = false;
            label9.Visible = false;
            tbConfirmPass.Visible = false;
            tbcurrentpass.Visible = false;
            tbNewpass.Visible = false;

        }


        // Declare a delegate
        public Action<object, Entites.User> DataBack;

        // Declare an event using the delegate





       
        private void lbUserRole_Click(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserProfil_Load(object sender, EventArgs e)
        {
            try
            {

                using (AppDbContext dbContext = new AppDbContext())
                {


                    var user = dbContext.Users.Include(u => u.Person).ToList().Find(u => u.Id == clsGlobal.CurrentUser.Id);

                    if (user != null)
                    {
                        lbage.Text = (DateTime.Now.Year - user.Person.BirthDate.Year).ToString();
                        lbEnail.Text = user.Person.Email;
                        lbName.Text = user.Person.Name;
                        phone.Text = user.Person.Phone;
                        lbusername.Text = user.UserName;
                        lbUserRole.Text = user.Role;
                        var image = user.Person.Image;
                        if (image is not null)
                        {
                            pbImage.Image = Image.FromStream(new MemoryStream(image));

                        }

                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            this.Close();
            DataBack?.Invoke(this, clsGlobal.CurrentUser);

        }

        private void tbcurrentpass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbcurrentpass.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbcurrentpass, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(tbcurrentpass, null);
            };

            if (clsGlobal.CurrentUser.Password != clsGlobal.ComputeHash(tbcurrentpass.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbcurrentpass, "Current password is wrong!");
                return;
            }
            else
            {
                errorProvider1.SetError(tbcurrentpass, null);
            };
        }

        private void tbNewpass_Validated(object sender, EventArgs e)
        {

        }

        private void tbNewpass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNewpass.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNewpass, "New Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(tbNewpass, null);
            };
        }

        private void tbConfirmPass_Validating(object sender, CancelEventArgs e)
        {
            if (tbConfirmPass.Text.Trim() != tbNewpass.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(tbConfirmPass, "Password Confirmation does not match New Password!");
            }
            else
            {
                errorProvider1.SetError(tbConfirmPass, null);
            };
        }

        private void llChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btsave.Visible = true;
            label1.Visible = true;
            label10.Visible = true;
            label9.Visible = true;
            tbConfirmPass.Visible = true;
            tbcurrentpass.Visible = true;
            tbNewpass.Visible = true;
        }

        private void btsave_Click_1(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {

                using (AppDbContext dbContext = new AppDbContext())
                {
                    var user = dbContext.Users.SingleOrDefault(u => u.Id == clsGlobal.CurrentUser.Id);

                    var newpass = clsGlobal.ComputeHash(tbNewpass.Text.Trim());
                    user!.Password = newpass;


                    dbContext.SaveChanges();

                    MessageBox.Show("Password Changed Successfully.",
                       "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
            catch
            {
                MessageBox.Show("An Erro Occured, Password did not change.",
                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
