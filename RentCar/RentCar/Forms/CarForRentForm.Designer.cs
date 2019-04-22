namespace RentCar.Forms
{
    partial class CarForRentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCar = new System.Windows.Forms.Label();
            this.grbName = new System.Windows.Forms.GroupBox();
            this.nupPrice = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.rbtManual = new System.Windows.Forms.RadioButton();
            this.rbtAutomatic = new System.Windows.Forms.RadioButton();
            this.lblTransmissionType = new System.Windows.Forms.Label();
            this.nupNumberOfCar = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfCar = new System.Windows.Forms.Label();
            this.cboCar = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.grbCars = new System.Windows.Forms.GroupBox();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransmission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumberOfCar)).BeginInit();
            this.grbCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(594, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Location = new System.Drawing.Point(4, 19);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(73, 13);
            this.lblCar.TabIndex = 2;
            this.lblCar.Text = "Select the car";
            // 
            // grbName
            // 
            this.grbName.Controls.Add(this.nupPrice);
            this.grbName.Controls.Add(this.lblPrice);
            this.grbName.Controls.Add(this.rbtManual);
            this.grbName.Controls.Add(this.rbtAutomatic);
            this.grbName.Controls.Add(this.lblTransmissionType);
            this.grbName.Controls.Add(this.nupNumberOfCar);
            this.grbName.Controls.Add(this.lblNumberOfCar);
            this.grbName.Controls.Add(this.cboCar);
            this.grbName.Controls.Add(this.lblCar);
            this.grbName.Location = new System.Drawing.Point(1, 12);
            this.grbName.Name = "grbName";
            this.grbName.Size = new System.Drawing.Size(587, 142);
            this.grbName.TabIndex = 4;
            this.grbName.TabStop = false;
            // 
            // nupPrice
            // 
            this.nupPrice.DecimalPlaces = 2;
            this.nupPrice.Location = new System.Drawing.Point(102, 104);
            this.nupPrice.Name = "nupPrice";
            this.nupPrice.Size = new System.Drawing.Size(72, 20);
            this.nupPrice.TabIndex = 10;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(4, 111);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            // 
            // rbtManual
            // 
            this.rbtManual.AutoSize = true;
            this.rbtManual.Location = new System.Drawing.Point(181, 76);
            this.rbtManual.Name = "rbtManual";
            this.rbtManual.Size = new System.Drawing.Size(60, 17);
            this.rbtManual.TabIndex = 8;
            this.rbtManual.TabStop = true;
            this.rbtManual.Text = "Manual";
            this.rbtManual.UseVisualStyleBackColor = true;
            // 
            // rbtAutomatic
            // 
            this.rbtAutomatic.AutoSize = true;
            this.rbtAutomatic.Location = new System.Drawing.Point(102, 76);
            this.rbtAutomatic.Name = "rbtAutomatic";
            this.rbtAutomatic.Size = new System.Drawing.Size(72, 17);
            this.rbtAutomatic.TabIndex = 7;
            this.rbtAutomatic.TabStop = true;
            this.rbtAutomatic.Text = "Automatic";
            this.rbtAutomatic.UseVisualStyleBackColor = true;
            // 
            // lblTransmissionType
            // 
            this.lblTransmissionType.AutoSize = true;
            this.lblTransmissionType.Location = new System.Drawing.Point(4, 81);
            this.lblTransmissionType.Name = "lblTransmissionType";
            this.lblTransmissionType.Size = new System.Drawing.Size(95, 13);
            this.lblTransmissionType.TabIndex = 6;
            this.lblTransmissionType.Text = "Transmission Type";
            // 
            // nupNumberOfCar
            // 
            this.nupNumberOfCar.Location = new System.Drawing.Point(102, 45);
            this.nupNumberOfCar.Name = "nupNumberOfCar";
            this.nupNumberOfCar.Size = new System.Drawing.Size(72, 20);
            this.nupNumberOfCar.TabIndex = 5;
            // 
            // lblNumberOfCar
            // 
            this.lblNumberOfCar.AutoSize = true;
            this.lblNumberOfCar.Location = new System.Drawing.Point(4, 47);
            this.lblNumberOfCar.Name = "lblNumberOfCar";
            this.lblNumberOfCar.Size = new System.Drawing.Size(74, 13);
            this.lblNumberOfCar.TabIndex = 4;
            this.lblNumberOfCar.Text = "Number of car";
            // 
            // cboCar
            // 
            this.cboCar.FormattingEnabled = true;
            this.cboCar.Location = new System.Drawing.Point(102, 11);
            this.cboCar.Name = "cboCar";
            this.cboCar.Size = new System.Drawing.Size(476, 21);
            this.cboCar.TabIndex = 3;
            this.cboCar.DropDown += new System.EventHandler(this.cboCar_DropDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(430, 160);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add to list";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(511, 160);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // grbCars
            // 
            this.grbCars.Controls.Add(this.dgvCars);
            this.grbCars.Location = new System.Drawing.Point(6, 187);
            this.grbCars.Name = "grbCars";
            this.grbCars.Size = new System.Drawing.Size(582, 256);
            this.grbCars.TabIndex = 8;
            this.grbCars.TabStop = false;
            this.grbCars.Text = "Cars for rent";
            // 
            // dgvCars
            // 
            this.dgvCars.AllowUserToAddRows = false;
            this.dgvCars.AllowUserToDeleteRows = false;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.colNumber,
            this.colTransmission,
            this.colPrice});
            this.dgvCars.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCars.Location = new System.Drawing.Point(6, 19);
            this.dgvCars.MultiSelect = false;
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.ReadOnly = true;
            this.dgvCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCars.Size = new System.Drawing.Size(567, 231);
            this.dgvCars.TabIndex = 8;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.Width = 250;
            // 
            // colNumber
            // 
            this.colNumber.HeaderText = "Number";
            this.colNumber.Name = "colNumber";
            this.colNumber.ReadOnly = true;
            this.colNumber.Width = 60;
            // 
            // colTransmission
            // 
            this.colTransmission.HeaderText = "Transmission";
            this.colTransmission.Name = "colTransmission";
            this.colTransmission.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 80;
            // 
            // CarForRentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(681, 445);
            this.Controls.Add(this.grbCars);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grbName);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CarForRentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car for rent";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CarForRentForm_Load);
            this.grbName.ResumeLayout(false);
            this.grbName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumberOfCar)).EndInit();
            this.grbCars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.GroupBox grbName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox grbCars;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.Label lblNumberOfCar;
        private System.Windows.Forms.NumericUpDown nupNumberOfCar;
        private System.Windows.Forms.Label lblTransmissionType;
        private System.Windows.Forms.RadioButton rbtAutomatic;
        private System.Windows.Forms.RadioButton rbtManual;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cboCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransmission;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.NumericUpDown nupPrice;
    }
}