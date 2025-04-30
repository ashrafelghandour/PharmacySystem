using PharmacyManagement.Classes;
using PharmacyManagement.Data;
using PharmacyManagement.Entites;
using PharmacyManagement.Screen.MainScreen;
using PharmacyManagement.Screen.Parmacit;

namespace PharmacyManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (chbShowPasswored.Checked)
            {

                pbOpenEye.Visible = true;
                pbClose_Eye.Visible = false;
                tbPass.UseSystemPasswordChar = false;



            }
            else
            {
                pbOpenEye.Visible = false;
                pbClose_Eye.Visible = true;
                tbPass.UseSystemPasswordChar = true;
            }
            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                tbUserName.Text = UserName;
                tbPass.Text = Password;
                chbRememberMe.Checked = true;
            }
            else
                chbRememberMe.Checked = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            tbPass.Clear();
            tbUserName.Clear();

        }

        private void btlogin_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(tbUserName.Text) || string.IsNullOrEmpty(tbPass.Text))
            {
                MessageBox.Show("Please enter your username and passwored !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

             _Login();
            

        }

        private bool _Login()
        {


            var HashPass = clsGlobal.ComputeHash(tbPass.Text.Trim());
            try
            {
                using (AppDbContext dbContext = new AppDbContext())
                {






                    User? cruntuser = dbContext.Users.FirstOrDefault(u => u.UserName == tbUserName.Text.Trim() && u.Password == HashPass);


                    if (cruntuser != null)
                    {
                        clsGlobal.CurrentUser = cruntuser;


                        if (chbRememberMe.Checked)
                        {
                            //store username and password
                            clsGlobal.RememberUsernameAndPassword(tbUserName.Text.Trim(), tbPass.Text.Trim());

                        }
                        else
                        {
                            //store empty username and password
                            clsGlobal.RememberUsernameAndPassword("", "");

                        }

                        if (cruntuser.Role == "Pharmacist")
                        {
                            this.Hide();
                            frmPharmacist frmPharmacist = new frmPharmacist();
                            frmPharmacist.ShowDialog();
                            this.Close();

                        }
                        else if(cruntuser.Role == "Administrator")
                        {

                            this.Hide();
                            MainForm mainForm = new MainForm();
                            mainForm.ShowDialog();
                            this.Close();

                        }
                        else
                        {
                            tbUserName.Focus();
                            MessageBox.Show("Invalid this roles", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }




                    }
                    else
                    {
                        tbUserName.Focus();
                        MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                }

            }
            catch
            {
                return false;
            }

            return false;

        }
        private void chbShowPasswored_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPasswored.Checked)
            {

                pbOpenEye.Visible = true;
                pbClose_Eye.Visible = false;
                tbPass.UseSystemPasswordChar = false;



            }
            else
            {
                pbOpenEye.Visible = false;
                pbClose_Eye.Visible = true;
                tbPass.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
