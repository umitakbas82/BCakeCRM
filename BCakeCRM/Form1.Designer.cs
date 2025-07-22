namespace BCakeCRM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            lstCustomers = new ListBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPhone = new TextBox();
            dgvSales = new DataGridView();
            dtSaleDate = new DateTimePicker();
            cmbProductType = new ComboBox();
            txtCost = new TextBox();
            txtSalePrice = new TextBox();
            txtProfit = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(2, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(905, 554);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtProfit);
            tabPage1.Controls.Add(txtSalePrice);
            tabPage1.Controls.Add(txtCost);
            tabPage1.Controls.Add(cmbProductType);
            tabPage1.Controls.Add(dtSaleDate);
            tabPage1.Controls.Add(dgvSales);
            tabPage1.Controls.Add(txtPhone);
            tabPage1.Controls.Add(txtLastName);
            tabPage1.Controls.Add(txtFirstName);
            tabPage1.Controls.Add(lstCustomers);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(897, 526);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(778, 420);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstCustomers
            // 
            lstCustomers.Dock = DockStyle.Left;
            lstCustomers.FormattingEnabled = true;
            lstCustomers.ItemHeight = 15;
            lstCustomers.Location = new Point(3, 3);
            lstCustomers.Name = "lstCustomers";
            lstCustomers.Size = new Size(164, 520);
            lstCustomers.TabIndex = 0;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(183, 11);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "Ad";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(289, 11);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Soyad";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(395, 11);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Telefon";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 3;
            // 
            // dgvSales
            // 
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Dock = DockStyle.Bottom;
            dgvSales.Location = new Point(167, 200);
            dgvSales.Name = "dgvSales";
            dgvSales.ReadOnly = true;
            dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSales.Size = new Size(727, 323);
            dgvSales.TabIndex = 4;
            // 
            // dtSaleDate
            // 
            dtSaleDate.Location = new Point(183, 51);
            dtSaleDate.Name = "dtSaleDate";
            dtSaleDate.Size = new Size(148, 23);
            dtSaleDate.TabIndex = 5;
            // 
            // cmbProductType
            // 
            cmbProductType.FormattingEnabled = true;
            cmbProductType.Items.AddRange(new object[] { "Pasta", "Cupcake", "Kurabiye" });
            cmbProductType.Location = new Point(337, 51);
            cmbProductType.Name = "cmbProductType";
            cmbProductType.Size = new Size(85, 23);
            cmbProductType.TabIndex = 6;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(428, 51);
            txtCost.Name = "txtCost";
            txtCost.PlaceholderText = "Yaklaşık Maliyet";
            txtCost.Size = new Size(100, 23);
            txtCost.TabIndex = 7;
            // 
            // txtSalePrice
            // 
            txtSalePrice.Location = new Point(534, 51);
            txtSalePrice.Name = "txtSalePrice";
            txtSalePrice.PlaceholderText = "Satış Fiyatı";
            txtSalePrice.Size = new Size(100, 23);
            txtSalePrice.TabIndex = 8;
            // 
            // txtProfit
            // 
            txtProfit.Location = new Point(640, 51);
            txtProfit.Name = "txtProfit";
            txtProfit.PlaceholderText = "Kâr";
            txtProfit.Size = new Size(100, 23);
            txtProfit.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 578);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox lstCustomers;
        private DataGridView dgvSales;
        private TextBox txtPhone;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private ComboBox cmbProductType;
        private DateTimePicker dtSaleDate;
        private TextBox txtProfit;
        private TextBox txtSalePrice;
        private TextBox txtCost;
    }
}
