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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            var customers = PersistenceCustomer.getInstance().GetAll().OrderBy(x => x.name);
            foreach(var customer in customers)
            {
                InsertGrid(customer);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValid())
                {
                    var customer = new Customer(txtFirstname.Text);
                    customer.lastName = txtLastName.Text;
                    customer.phoneNumber = mskTelephoneNumber.Text;
                    customer.eMail = txtEmail.Text;
                    customer.age = (int)nupAge.Value;
                    customer.genderIsMale = rbtMale.Checked;
                    PersistenceCustomer.getInstance().Insert(customer);
                    InsertGrid(customer);
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
            txtFirstname.Text = string.Empty;
            txtLastName.Text = string.Empty;
            mskTelephoneNumber.Clear();
            txtEmail.Text = string.Empty;
            nupAge.Value = 0;
            rbtFemale.Checked = false;
            rbtMale.Checked = false;     
            txtFirstname.Focus();
        }

        private bool isValid()
        {
            if (string.IsNullOrWhiteSpace(txtFirstname.Text))
            {
                MessageBox.Show("Enter the first name");
                txtFirstname.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Enter the last name");
                txtLastName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(mskTelephoneNumber.Text) || Functions.getOnlyNumbers(mskTelephoneNumber.Text) == 0)
            {
                MessageBox.Show("Enter the number phone");
                mskTelephoneNumber.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Enter the email");
                txtEmail.Focus();
                return false;
            } else if (!Functions.IsValidEmail(txtEmail.Text)) {
                MessageBox.Show("Email is not valid");
                txtEmail.Focus();
                return false;
            }

            if (nupAge.Value == 0)
            {
                MessageBox.Show("Enter the age");
                nupAge.Focus();
                return false;
            }

            if (!(rbtFemale.Checked || rbtMale.Checked))
            {
                MessageBox.Show("Select gender");
                return false;
            }

            return true;
        }

        private void InsertGrid(ICustomer customer)
        {
            var index = dgvCustomer.Rows.Add(customer.name, customer.lastName, customer.phoneNumber, customer.eMail, customer.age, customer.genderIsMale ? "Male" : "Female");
            dgvCustomer.Rows[index].Tag = customer;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count == 0) return;

            var customer = (ICustomer)dgvCustomer.SelectedRows[0].Tag;

            if (customer == null) return;

            if (MessageBox.Show(string.Format("Do you want to delete the customer {0}?", customer.name), "Remove", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    PersistenceCustomer.getInstance().Delete(customer);
                    dgvCustomer.Rows.Remove(dgvCustomer.SelectedRows[0]);
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
