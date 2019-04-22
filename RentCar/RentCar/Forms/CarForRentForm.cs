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
    public partial class CarForRentForm : Form
    {
        public CarForRentForm()
        {
            InitializeComponent();
        }

        private void CarForRentForm_Load(object sender, EventArgs e)
        {
            var cars = PersistenceCarForRent.getInstance().GetAll().OrderBy(x => x.name).ThenBy(x => x.isAutomatic).ThenBy(x => x.Price);
            foreach(var car in cars)
            {
                InsertGrid(car);
            }
        }

        private void cboCar_DropDown(object sender, EventArgs e)
        {
            var partialName = cboCar.Text;
            cboCar.Items.Clear();
            var cars = PersistenceCar.getInstance().GetByName(cboCar.Text);
            foreach(var car in cars)
            {
                Functions.AddCombobox(ref cboCar, car.Id, car);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var car = Functions.getSelectValue<ICar>(ref cboCar);
                if (isValid(car))
                {
                    var carRental = new CarForRent(car);
                    carRental.number = (int)nupNumberOfCar.Value;
                    carRental.isAutomatic = rbtAutomatic.Checked;
                    carRental.Price = nupPrice.Value;
                    PersistenceCarForRent.getInstance().Insert(carRental);
                    InsertGrid(carRental);
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
            Functions.clearCombobox(ref cboCar);
            nupNumberOfCar.Value = 0;
            rbtAutomatic.Checked = false;
            rbtManual.Checked = false;
            nupPrice.Value = 0;
            cboCar.Focus();
        }

        private bool isValid(ICar car)
        {
            if (car == null)
            {
                MessageBox.Show("Select a car");
                cboCar.Focus();
                return false;
            }

            if (nupNumberOfCar.Value == 0)
            {
                MessageBox.Show("Enter the number of car");
                nupNumberOfCar.Focus();
                return false;
            }

            if (!(rbtAutomatic.Checked || rbtManual.Checked))
            {
                MessageBox.Show("Select transmission type");
                return false;
            }

            if (nupPrice.Value == 0)
            {
                MessageBox.Show("Enter the price of car for rental");
                nupPrice.Focus();
                return false;
            }

            return true;
        }

        private void InsertGrid(ICarForRent carForRent)
        {
            var index = dgvCars.Rows.Add(carForRent.ToString(), carForRent.number, carForRent.isAutomatic ? "Automatc" : "Manual", carForRent.Price.ToString());
            dgvCars.Rows[index].Tag = carForRent;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCars.SelectedRows.Count == 0) return;

            var car = (ICarForRent)dgvCars.SelectedRows[0].Tag;

            if (car == null) return;

            if (MessageBox.Show(string.Format("Do you want to delete the car of rent {0}?", car.name), "Remove", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    PersistenceCarForRent.getInstance().Delete(car);
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
