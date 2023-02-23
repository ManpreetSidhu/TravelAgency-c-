namespace TravelExpertsGUI
{
    partial class AddTravelPackages
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblpkgID = new System.Windows.Forms.Label();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lblstartdate = new System.Windows.Forms.Label();
            this.lblenddate = new System.Windows.Forms.Label();
            this.lblbaseprice = new System.Windows.Forms.Label();
            this.lblcommission = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txtbaseprice = new System.Windows.Forms.TextBox();
            this.txtcommission = new System.Windows.Forms.TextBox();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.cboProducts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.supplier = new System.Windows.Forms.Label();
            this.cboSuppliers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(58, 70);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(49, 20);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name";
            // 
            // lblpkgID
            // 
            this.lblpkgID.AutoSize = true;
            this.lblpkgID.Location = new System.Drawing.Point(58, 26);
            this.lblpkgID.Name = "lblpkgID";
            this.lblpkgID.Size = new System.Drawing.Size(82, 20);
            this.lblpkgID.TabIndex = 1;
            this.lblpkgID.Text = "Package ID";
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Location = new System.Drawing.Point(58, 119);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(143, 20);
            this.lbldescription.TabIndex = 2;
            this.lbldescription.Text = "Package Description";
            // 
            // lblstartdate
            // 
            this.lblstartdate.AutoSize = true;
            this.lblstartdate.Location = new System.Drawing.Point(58, 169);
            this.lblstartdate.Name = "lblstartdate";
            this.lblstartdate.Size = new System.Drawing.Size(72, 20);
            this.lblstartdate.TabIndex = 3;
            this.lblstartdate.Text = "StartDate";
            // 
            // lblenddate
            // 
            this.lblenddate.AutoSize = true;
            this.lblenddate.Location = new System.Drawing.Point(58, 220);
            this.lblenddate.Name = "lblenddate";
            this.lblenddate.Size = new System.Drawing.Size(70, 20);
            this.lblenddate.TabIndex = 4;
            this.lblenddate.Text = "End Date";
            // 
            // lblbaseprice
            // 
            this.lblbaseprice.AutoSize = true;
            this.lblbaseprice.Location = new System.Drawing.Point(58, 266);
            this.lblbaseprice.Name = "lblbaseprice";
            this.lblbaseprice.Size = new System.Drawing.Size(76, 20);
            this.lblbaseprice.TabIndex = 5;
            this.lblbaseprice.Text = "Base Price";
            // 
            // lblcommission
            // 
            this.lblcommission.AutoSize = true;
            this.lblcommission.Location = new System.Drawing.Point(58, 314);
            this.lblcommission.Name = "lblcommission";
            this.lblcommission.Size = new System.Drawing.Size(143, 20);
            this.lblcommission.TabIndex = 6;
            this.lblcommission.Text = "Agency Commission";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(299, 23);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(125, 27);
            this.txtid.TabIndex = 8;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(299, 70);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(250, 27);
            this.txtname.TabIndex = 9;
            this.txtname.Tag = "Package Name";
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(299, 119);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(250, 27);
            this.txtdescription.TabIndex = 10;
            this.txtdescription.Tag = "Description";
            // 
            // txtbaseprice
            // 
            this.txtbaseprice.Location = new System.Drawing.Point(299, 263);
            this.txtbaseprice.Name = "txtbaseprice";
            this.txtbaseprice.Size = new System.Drawing.Size(254, 27);
            this.txtbaseprice.TabIndex = 11;
            this.txtbaseprice.Tag = "Base Price";
            // 
            // txtcommission
            // 
            this.txtcommission.Location = new System.Drawing.Point(299, 307);
            this.txtcommission.Name = "txtcommission";
            this.txtcommission.Size = new System.Drawing.Size(254, 27);
            this.txtcommission.TabIndex = 12;
            this.txtcommission.Tag = "Agency Commission";
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.CustomFormat = "MMMMdd, yyyy  HH:mm";
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDatePicker.Location = new System.Drawing.Point(299, 169);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(250, 27);
            this.StartDatePicker.TabIndex = 13;
            this.StartDatePicker.Tag = "StartDate";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.CustomFormat = "MMMMdd, yyyy  HH:mm";
            this.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDatePicker.Location = new System.Drawing.Point(299, 215);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(250, 27);
            this.EndDatePicker.TabIndex = 14;
            this.EndDatePicker.Tag = "EndDate";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(624, 156);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(111, 46);
            this.btnAccept.TabIndex = 15;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(624, 253);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(111, 46);
            this.btncancel.TabIndex = 16;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // cboProducts
            // 
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(299, 356);
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(254, 28);
            this.cboProducts.TabIndex = 17;
            this.cboProducts.Tag = "Products";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Products";
            // 
            // supplier
            // 
            this.supplier.AutoSize = true;
            this.supplier.Location = new System.Drawing.Point(70, 414);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(70, 20);
            this.supplier.TabIndex = 19;
            this.supplier.Text = "Suppliers";
            // 
            // cboSuppliers
            // 
            this.cboSuppliers.FormattingEnabled = true;
            this.cboSuppliers.Location = new System.Drawing.Point(299, 408);
            this.cboSuppliers.Name = "cboSuppliers";
            this.cboSuppliers.Size = new System.Drawing.Size(254, 28);
            this.cboSuppliers.TabIndex = 20;
            this.cboSuppliers.Tag = "Suppliers";
            // 
            // AddTravelPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboSuppliers);
            this.Controls.Add(this.supplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboProducts);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.txtcommission);
            this.Controls.Add(this.txtbaseprice);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblcommission);
            this.Controls.Add(this.lblbaseprice);
            this.Controls.Add(this.lblenddate);
            this.Controls.Add(this.lblstartdate);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.lblpkgID);
            this.Controls.Add(this.lblname);
            this.Name = "AddTravelPackages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTravelPackages";
            this.Load += new System.EventHandler(this.AddTravelPackages_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblname;
        private Label lblpkgID;
        private Label lbldescription;
        private Label lblstartdate;
        private Label lblenddate;
        private Label lblbaseprice;
        private Label lblcommission;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtid;
        private TextBox txtname;
        private TextBox txtdescription;
        private TextBox txtbaseprice;
        private TextBox txtcommission;
        private DateTimePicker StartDatePicker;
        private DateTimePicker EndDatePicker;
        private Button btnAccept;
        private Button btncancel;
        private ComboBox cboProducts;
        private Label label1;
        private Label supplier;
        private ComboBox cboSuppliers;
    }
}