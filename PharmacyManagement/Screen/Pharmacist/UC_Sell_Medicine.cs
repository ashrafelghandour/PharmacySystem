using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
using Microsoft.IdentityModel.Tokens;
using PharmacyManagement.Classes;
using PharmacyManagement.Data;
using PharmacyManagement.Entites;

namespace PharmacyManagement.Screen.Pharmacist
{
    public partial class UC_Sell_Medicine : UserControl
    {
        public UC_Sell_Medicine()
        {
            InitializeComponent();
        }

        int units = 0, n, noofunit;
        decimal TotalAmount, valuaAmount;
        string valueId;
        private void btReset_Click(object sender, EventArgs e)
        {
            ListBoxMedcine.Items.Clear();

            LodMedicine(m => m.Edate >= DateOnly.FromDateTime(DateTime.Now) & m.Quantity > 0);
        }
        private void LodMedicine(Func<Entites.Medicine, bool> condution)
        {
            using (AppDbContext dbContext = new AppDbContext())
            {

                var result = dbContext.Medicines.Where(condution).Select(m => m.Name);
                if (result.Any())
                {
                    foreach (var m in result)
                    {
                        ListBoxMedcine.Items.Add(m);
                    }
                }
            }

        }

        private void UC_Sell_Medicine_Load(object sender, EventArgs e)
        {
            ListBoxMedcine.Items.Clear();


            LodMedicine(m => m.Edate >= DateOnly.FromDateTime(DateTime.Now) & m.Quantity > 0);
        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {
            ListBoxMedcine.Items.Clear();
            LodMedicine(m => m.Edate >= DateOnly.FromDateTime(DateTime.Now) & m.Quantity > 0 && m.Name.Contains(tbsearch.Text));

        }

        private void ListBoxMedcine_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbnoofUnits.Clear();

            try
            {



                string NMedcine = ListBoxMedcine.GetItemText(ListBoxMedcine.SelectedItem);

                Entites.Medicine Medcine;
                using (var db = new AppDbContext())
                {

                    Medcine = db.Medicines.First(m => m.Name == NMedcine);
                }
                units = Medcine.Quantity;

                tbMedicineName.Text = NMedcine;
                tbMedicineID.Text = Medcine.Id.ToString();
                DTBExpierDate.Text = Medcine.Edate.ToShortDateString();
                tbPricePerunit.Text = Medcine.PricePerUnit.ToString();


                if (Medcine.Image != null)
                {
                    pbImage.Image = Image.FromStream(new MemoryStream(Medcine.Image));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ClearAll()
        {
            tbMedicineID.Clear();
            tbMedicineName.Clear();
            DTBExpierDate.ResetText();
            tbPricePerunit.Clear();
            tbnoofUnits.Clear();
            tbtotalprice.Clear();
        }

        private void tbnoofUnits_TextChanged(object sender, EventArgs e)
        {
            if (!clsValidatoin.IsNumber(tbnoofUnits.Text))
            {
                tbtotalprice.Clear();
                return;

            }

            else if (string.IsNullOrEmpty(tbnoofUnits.Text.Trim()))
            {
                tbtotalprice.Clear();

                return;
            }



            if (int.Parse(tbnoofUnits.Text) > units)
            {
                MessageBox.Show("The available quantity is not enough", "Warning", MessageBoxButtons.OK);
                tbtotalprice.Clear();

                return;
            }
            else
            {
                tbtotalprice.Text = (int.Parse(tbnoofUnits.Text) * Convert.ToDecimal(tbPricePerunit.Text)).ToString();

            }
        }

        private void tbnoofUnits_Validating(object sender, CancelEventArgs e)
        {

        }

        private void btaddcart_Click(object sender, EventArgs e)
        {

            if (tbMedicineID.Text != "")
            {
                try
                {
                    using (var db = new AppDbContext())
                    {

                        var result = db.Medicines.First(m => m.Id == int.Parse(tbMedicineID.Text));



                        if (result.Quantity > 0)
                        {

                            result.Quantity -= int.Parse(tbnoofUnits.Text);

                            db.SaveChanges();


                            n = guna2DataGridView1.Rows.Add();
                            guna2DataGridView1.Rows[n].Cells[0].Value = tbMedicineID.Text;
                            guna2DataGridView1.Rows[n].Cells[1].Value = tbMedicineName.Text;
                            guna2DataGridView1.Rows[n].Cells[2].Value = DTBExpierDate.Text;
                            guna2DataGridView1.Rows[n].Cells[3].Value = tbPricePerunit.Text;
                            guna2DataGridView1.Rows[n].Cells[4].Value = tbnoofUnits.Text;
                            guna2DataGridView1.Rows[n].Cells[5].Value = tbtotalprice.Text;

                            TotalAmount += Convert.ToDecimal(tbtotalprice.Text);
                            lltotal.Text = $"Rs {TotalAmount}$";
                        }
                        else
                        {
                            MessageBox.Show("medicne is out of stock. \n Only " + units + "Left", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        UC_Sell_Medicine_Load(this, null);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("select medicne first. ", "INformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btremove_Click(object sender, EventArgs e)
        {
            if (valueId != null)
            {


                try
                {

                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);

                }
                catch
                {

                }
                finally
                {
                    using (var db = new AppDbContext())
                    {
                        var result = db.Medicines.First(m => m.Id == int.Parse(valueId));

                        result.Quantity += noofunit;

                        TotalAmount -= valuaAmount;
                        lltotal.Text = $"Rs {TotalAmount}$";

                        db.SaveChanges();
                    }
                }
                UC_Sell_Medicine_Load(this, null);

            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                valuaAmount = Convert.ToDecimal(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueId = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                noofunit = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());


            }
            catch (Exception ex)
            {

            }
        }

        private void btprintpurchase_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Medicine Bill";
            print.SubTitle = String.Format("Date:- {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Total Payvale Amount : " + lltotal.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(guna2DataGridView1);


            TotalAmount = 0;
            lltotal.Text = "Rs. 00";
            guna2DataGridView1.DataSource = 0;
        }
    }
}
