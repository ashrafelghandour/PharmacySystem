
using System.Data;

using Microsoft.EntityFrameworkCore;
using PharmacyManagement.Data;

namespace PharmacyManagement.Screen.User
{
    public partial class UC_ViewUser : UserControl
    {
        public UC_ViewUser()
        {
            InitializeComponent();

        }

        private void UC_ViewUser_Load(object sender, EventArgs e)
        {
            LodDataToDataGridView();
        }


        private void LodDataToDataGridView()
        {
            using (AppDbContext dbContext = new AppDbContext())
            {




                var Users = dbContext.Users.Include(u => u.Person).Select
                    (u => new { id = u.Id, Name = u.Person.Name, UserName = u.UserName, u.Person.Email, u.Person.Image }).ToList();
                guna2DataGridView1.Rows.Clear();

                foreach (var row in Users)
                {

                    if (row.Image != null)
                    {
                        MemoryStream memoryStream = new MemoryStream(row.Image);
                        guna2DataGridView1.Rows.Add(row.id, row.Name, row.UserName, row.Email, Image.FromStream(memoryStream));


                    }
                    else
                    {
                        Bitmap bitmap = new Bitmap(20, 200);
                        guna2DataGridView1.Rows.Add(row.id, row.Name, row.UserName, row.Email, bitmap);

                    }
                }
            }
        }

        private void btresetdata_Click(object sender, EventArgs e)
        {
            LodDataToDataGridView();
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

                        if (guna2DataGridView1.CurrentRow != null)
                        {
                            int userid = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value);

                            dbContext.Users.Remove(new Entites.User { Id = userid });

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

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (AppDbContext dbContext = new AppDbContext())
                {

                        var Users = dbContext.Users.Where(u => u.UserName.StartsWith(tbsearch.Text)).Include(u => u.Person).Select
                            (u => new { id = u.Id, Name = u.Person.Name, UserName = u.UserName, u.Person.Email, u.Person.Image }).ToList();
                        guna2DataGridView1.Rows.Clear();

                        foreach (var row in Users)
                        {

                            if (row.Image != null)
                            {
                                MemoryStream memoryStream = new MemoryStream(row.Image);
                                guna2DataGridView1.Rows.Add(row.id, row.Name, row.UserName, row.Email, Image.FromStream(memoryStream));


                            }
                            else
                            {
                                Bitmap bitmap = new Bitmap(20, 200);
                                guna2DataGridView1.Rows.Add(row.id, row.Name, row.UserName, row.Email, bitmap);

                            }
                        }
                    
                }

            }


            catch (Exception ex)
            {


            }
        }
    }
}
