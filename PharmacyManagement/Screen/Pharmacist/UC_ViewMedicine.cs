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
using PharmacyManagement.Entites;

namespace PharmacyManagement.Screen.Pharmacist
{
    public partial class UC_ViewMedicine : UserControl
    {
        public UC_ViewMedicine()
        {
            InitializeComponent();
        }

        public  Action<object, int> DataBack ;

        private void UC_ViewMedicine_Load(object sender, EventArgs e)
        {
            LodDataToDataGridView();
        }

        private void LodDataToDataGridView()
        {
            using (AppDbContext dbContext = new AppDbContext())
            {


                guna2DataGridView1.DataSource = dbContext.Medicines.ToList();

                //var Users = dbContext.Medicines.Select
                //    (u => new { id = u.Id, Name = u.Person.Name, UserName = u.UserName, u.Person.Email, u.Person.Image }).ToList();
                //guna2DataGridView1.Rows.Clear();

                //foreach (var row in Users)
                //{

                //    if (row.Image != null)
                //    {
                //        MemoryStream memoryStream = new MemoryStream(row.Image);
                //        guna2DataGridView1.Rows.Add(row.id, row.Name, row.UserName, row.Email, Image.FromStream(memoryStream));


                //    }
                //    else
                //    {
                //        Bitmap bitmap = new Bitmap(20, 200);
                //        guna2DataGridView1.Rows.Add(row.id, row.Name, row.UserName, row.Email, bitmap);

                //    }
                //}
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

                        if (guna2DataGridView1.CurrentRow != null)
                        {
                            int medicineId = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value);

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

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {

            try
            {
                using (AppDbContext dbContext = new AppDbContext())
                {

                    guna2DataGridView1.DataSource = dbContext.Medicines.Where(m => m.Name.StartsWith(tbsearch.Text.Trim())).ToList();


                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btresetdata_Click(object sender, EventArgs e)
        {
            LodDataToDataGridView();
        }

        private void btEditedMedi_Click(object sender, EventArgs e)
        {

            try
            {
                var Currrow = guna2DataGridView1.CurrentRow;
                if (Currrow is not null)
                {
                    this.Hide();
                    DataBack?.Invoke(sender, int.Parse(Currrow.Cells["id"].Value!.ToString()!));
                    return;
                    
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
