using RentCar.Core;
using RentCar.Core.Model.Implementations;
using RentCar.Core.Model.Interfaces;
using RentCar.Core.Persistence.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.Forms
{
    public partial class CarForm : Form
    {
        public CarForm()
        {
            InitializeComponent();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            var cars = PersistenceCar.getInstance().GetAll().OrderBy(x => x.name);
            foreach(var car in cars)
            {
                InsertGrid(car);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValid())
                {
                    var car = new Car(txtName.Text);
                    PersistenceCar.getInstance().Insert(car);
                    InsertGrid(car);
                    ClearForm();
                }
            }
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message);
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ClearForm()
        {
            txtName.Text = string.Empty;
            txtName.Focus();
        }

        private bool isValid()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Enter the name");
                txtName.Focus();
                return false;
            }

            return true;
        }

        private void InsertGrid(ICar car)
        {
            var index = dgvCars.Rows.Add(car);
            dgvCars.Rows[index].Tag = car;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCars.SelectedRows.Count == 0) return;

            var car = (ICar)dgvCars.SelectedRows[0].Tag;

            if (car == null) return;

            if (MessageBox.Show(string.Format("Do you want to delete the car {0}?", car.name), "Remove", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    PersistenceCar.getInstance().Delete(car);
                    dgvCars.Rows.Remove(dgvCars.SelectedRows[0]);
                }
                catch (MyException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }                
            }             
        }        
    }
}
