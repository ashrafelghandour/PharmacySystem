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
using PharmacyManagement.Properties;

namespace PharmacyManagement.Screen.User
{
    public partial class UC_AddNewUse : UserControl
    {

        public UC_AddNewUse()
        {
            InitializeComponent();




        }



        private void tbUserName_Validating_Click_1(object sender, CancelEventArgs e)
        {
            if (!(bool)guna2CirclePictureBox1.Tag)
            {

                e.Cancel = true;


            }
        }



        private void _resetAllTextBox()
        {
            tbEmail.Clear();
            tbName.Clear();
            tbpassword.Clear();
            tbUserName.Clear();
            tbPhone.Clear();

            pbImage.Image = Resources.admin3;
            guna2CirclePictureBox1.Tag = 2;

            llRemoveImage.Visible = false;

            cbUserRolee.Text = null;
        }





        private void tbEmail_Validating_Click_1(object sender, CancelEventArgs e)
        {
            if (!clsValidatoin.ValidateEmail(tbEmail.Text))
            {
                e.Cancel = true;
                return;
            }
        }







        private void tbPhone_Validating_Click_1(object sender, CancelEventArgs e)
        {
            if (!clsValidatoin.IsNumber(tbPhone.Text))
            {
                e.Cancel = true;
                return;

            }


            else if (string.IsNullOrEmpty(tbPhone.Text.Trim()))
            {
                e.Cancel = true;
                return;
            }
            else
            {
                e.Cancel = false;
                return;

            }
        }


        private void btSave_Click_1(object sender, EventArgs e)
        {
            if (tbPhone.Text.Length < 1 || tbEmail.Text.Length < 1 || cbUserRolee.Text.Length < 1 || tbName.Text.Length < 1 || tbpassword.Text.Length < 1 || tbUserName.Text.Length < 1)
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                using (AppDbContext db = new AppDbContext())
                {

                    DateTime date = Convert.ToDateTime(DTBBirthDate.Text);

                    var Image = pbImage.Image == Resources.addUser ? null : clsGlobal.GetPhoto(pbImage);

                    Pepole newperson = new Pepole
                    {
                        Email = tbEmail.Text.Trim(),
                        BirthDate = date,
                        //  Image = (Convert.ToInt32(pbImage.Tag) == 2) ? null : clsGlobal.GetPhoto(pbImage),
                        Image = Image,
                        Name = tbName.Text.Trim(),
                        Phone = tbPhone.Text.Trim()
                    };






                    Entites.User newuser = new Entites.User
                    {

                        Password = clsGlobal.ComputeHash(tbpassword.Text.Trim()),
                        UserName = tbUserName.Text.Trim(),
                        Role = cbUserRolee.Text.Trim(),
                        Person = newperson


                    };

                    db.Users.Add(newuser);
                    db.SaveChanges();
                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _resetAllTextBox();
                }
            }
            catch
            {

                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btreset_Click_1(object sender, EventArgs e)
        {
            _resetAllTextBox();

        }

        private void llsetImage_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                pbImage.Image = Image.FromFile(openFileDialog1.FileName);
                llRemoveImage.Visible = true;
                guna2CirclePictureBox1.Tag = 0;


                // ...
            }


        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImage.Image = Resources.admin3;
            guna2CirclePictureBox1.Tag = 2;

            llRemoveImage.Visible = false;
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            using (AppDbContext dbContext = new AppDbContext())
            {


                if (dbContext.Users.Any(u => u.UserName == tbUserName.Text.Trim()))
                {

                    guna2CirclePictureBox1.Image = Resources.no;
                    guna2CirclePictureBox1.Tag = false;


                }
                else
                {
                    guna2CirclePictureBox1.Image = Resources.yes;

                    guna2CirclePictureBox1.Tag = true;

                }
            }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_AddNewUse_Load(object sender, EventArgs e)
        {

        }
    }
}
