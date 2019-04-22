using RentCar.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar
{
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();            
        }

        public void OpeForm<T>() where T : Form
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is T)
                {
                    form.WindowState = FormWindowState.Normal;
                    form.Focus();
                    return;
                }
            }

            var newForm = Activator.CreateInstance<T>();
            newForm.MdiParent = this;
            newForm.TopMost = true;
            newForm.Show();
        }

        private void Car(object sender, EventArgs e)
        {
            OpeForm<CarForm>();            
        }
        
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?","Exit", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }            
        }

        private void carForRentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpeForm<CarForRentForm>();
        }

        private void General_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpeForm<CustomerForm>();
        }
    }
}
