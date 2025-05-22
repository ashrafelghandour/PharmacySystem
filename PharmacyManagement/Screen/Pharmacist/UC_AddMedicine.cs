using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyManagement.Properties;
using System.Xml.Linq;
using PharmacyManagement.Classes;
using PharmacyManagement.Data;
using PharmacyManagement.Entites;
using Microsoft.VisualBasic.ApplicationServices;

namespace PharmacyManagement.Screen.Pharmacist
{
    public partial class UC_AddMedicine : UserControl
    {
        public UC_AddMedicine()
        {
            InitializeComponent();
            lbAddQuantity.Visible = false;
            tbaddquantity.Visible = false;
            _mode = enMode.Add;
        }


        public UC_AddMedicine(Entites.Medicine? medicine)
        {
            InitializeComponent();



            _mode = enMode.Update;
            _medicine = medicine;
            _LodDatatolabl();

        }

        public void _LodDatatolabl()
        {
            _resetAllTextBox();
            _medicine = clsGlobal.Medicine;
            lbMode.Text = "Update Medicine";

            if (_medicine is null)
            {

                return;
            }

            lbMedicinenumber.Visible = true;
            lbAddQuantity.Visible = true;
            tbaddquantity.Visible = true;

            pbImage.Image = _medicine.Image == null ? null : Image.FromStream(new MemoryStream(_medicine.Image));

            dtbManufactuningDate.Text = _medicine.MDate.ToString();
            DTBExpierDate.Text = _medicine.Edate.ToString();
            tbMedicineID.Text = _medicine.Id.ToString();
            tbMedicineName.Text = _medicine.Name.
                ToString();
            tbMedicineNumber.Text = _medicine.Number.ToString();
            tbPricePerunit.Text = _medicine.PricePerUnit.ToString();
            tbquntity.Text = _medicine.Quantity.ToString();


        }

        enum enMode { Add, Update };
        public Entites.Medicine? _medicine = null;
        enMode _mode = enMode.Add;
        private void UC_AddMedicine_Load(object sender, EventArgs e)
        {
            if (_mode == enMode.Update)
            {
                _LodDatatolabl();
            }
        }


        private void _resetAllTextBox()
        {
            tbquntity.Clear();
            tbMedicineNumber.Clear();
            tbPricePerunit.Clear();
            tbMedicineName.Clear();
            tbMedicineID.Clear();

            pbImage.Image = Resources._2968946;

            llRemoveImage.Visible = false;

        }

        private void btreset_Click(object sender, EventArgs e)
        {
            _resetAllTextBox();
        }

        private void tbMedicineID_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidatoin.IsNumber(tbMedicineID.Text))
            {
                e.Cancel = true;
                return;

            }


            else if (string.IsNullOrEmpty(tbMedicineID.Text.Trim()))
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

        private void tbquntity_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbquntity_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidatoin.IsNumber(tbquntity.Text))
            {
                e.Cancel = true;
                return;

            }


            else if (string.IsNullOrEmpty(tbquntity.Text.Trim()))
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

        private void tbPricePerunit_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidatoin.IsNumber(tbPricePerunit.Text))
            {
                e.Cancel = true;
                return;

            }


            else if (string.IsNullOrEmpty(tbPricePerunit.Text.Trim()))
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

        private void tbMedicineNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidatoin.IsNumber(tbMedicineNumber.Text))
            {
                e.Cancel = true;
                return;

            }


            else if (string.IsNullOrEmpty(tbMedicineNumber.Text.Trim()))
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

        private void btSave_Click(object sender, EventArgs e)
        {


            try
            {


                using (AppDbContext db = new AppDbContext())
                {



                    if (_mode == enMode.Update)
                    {

                        if (tbquntity.Text == "" || tbMedicineNumber.Text == "" || tbPricePerunit.Text == "" || tbMedicineName.Text == "")
                        {
                            MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }


                        var medicine = db.Medicines.ToList().FirstOrDefault(clsGlobal.Medicine);
                        if (medicine == null)
                        {

                            return;
                        }

                        DateOnly Mdate = DateOnly.FromDateTime(Convert.ToDateTime(dtbManufactuningDate.Text));
                        DateOnly Edate = DateOnly.FromDateTime(Convert.ToDateTime(DTBExpierDate.Text));

                        var Image = pbImage.Image == Resources.addUser ? null : clsGlobal.GetPhoto(pbImage);


                        medicine.Edate = Edate;
                        medicine.MDate = Mdate;
                        medicine.PricePerUnit = decimal.Parse(tbPricePerunit.Text.Trim());
                        medicine.Quantity = int.Parse(tbquntity.Text.Trim()) + int.Parse(tbaddquantity.Text.Trim());
                        medicine.Number = int.Parse(tbMedicineNumber.Text.Trim());
                        medicine.Name = tbMedicineName.Text.Trim();
                        medicine.Image = Image;


                        db.SaveChanges();
                        MessageBox.Show("Data Updated Successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                       
                    }
                    else
                    {

                        if (tbquntity.Text == "" || tbMedicineNumber.Text == "" || tbPricePerunit.Text == "" || tbMedicineName.Text == "" )
                        {
                            MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }



                        var Image = Convert.ToInt32(pbImage.Tag) == 2 ? null : clsGlobal.GetPhoto(pbImage);



                        Medicine newmedicine = new Medicine
                        {
                            Edate = DateOnly.FromDateTime(Convert.ToDateTime(DTBExpierDate.Text)),
                            MDate = DateOnly.FromDateTime(Convert.ToDateTime(dtbManufactuningDate.Text))
                             ,
                            Name = tbMedicineName.Text,
                            Number = int.Parse(tbMedicineNumber.Text),
                            PricePerUnit = decimal.Parse(tbPricePerunit.Text),
                            Quantity = int.Parse(tbquntity.Text),

                            Image = Image,

                        };






                        db.Medicines.Add(newmedicine);
                        db.SaveChanges();
                        MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clsGlobal.Medicine = newmedicine;
                        _LodDatatolabl();
                    }






                }


            }
            catch
            {

                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void llsetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {


                openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Process the selected file
                    pbImage.Image = Image.FromFile(openFileDialog1.FileName);
                    llRemoveImage.Visible = true;
                    pbImage.Tag = 0;


                    // ...
                }
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImage.Image = Resources._647237;
            pbImage.Tag = 2;

            llRemoveImage.Visible = false;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {


                using (AppDbContext db = new AppDbContext())
                {

                   clsGlobal.Medicine = db.Medicines.FirstOrDefault(m => m.Number == int.Parse(tbsearch.Text.Trim()));
                   
                    if(clsGlobal.Medicine is  null)
                    {
                        MessageBox.Show($"No Medicine With ID {tbsearch.Text}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    _LodDatatolabl();



                }


            }
            catch
            {

                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tbsearch_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidatoin.IsNumber(tbsearch.Text))
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
    }
}
