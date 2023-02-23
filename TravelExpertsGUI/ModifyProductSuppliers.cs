// Created by Meet Kamal Grewal
using PackagesData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;


namespace TravelExpertsGUI
{
    public partial class ModifyProductSuppliers : Form
    {
        public bool isAdd;          // main form will set it: true - Add, false - Modify
        public ProductsSupplier? prodsup;
        // constructor
        public ModifyProductSuppliers()
        {
            InitializeComponent();
        }

        // when form loads
        private void ModifyProductSuppliers_Load(object sender, EventArgs e)
        {
            // call function to display data
            DisplayProdSup();
        }

        // displays selected product that is to be modified
        private void DisplayProdSup()
        {
            if (prodsup != null) //Edit
            {
                // assign value to the textboxes
                txtProdSuppId.Text = Convert.ToString(prodsup.ProductSupplierId);
                txtProductId.Text = Convert.ToString(prodsup.ProductId);
                txtSupplierId.Text = Convert.ToString(prodsup.SupplierId);
                btnAdd.Visible = false;
            }
            else //Add
            {
                // productsupplier id is not visible while adding the data
                txtProdSuppId.Visible= false;
                lblProdSuppId.Visible= false;
                // edit button is also not visible.
                btnEdit.Visible= false;
        
            }

        }

        // Edit button to save changes to existing Product Supplier
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // check the user put valid input data
            if (Validator.IsValid(txtProductId) &&
                Validator.IsNonNegativeInt(txtProductId) &&
                Validator.IsValid(txtSupplierId) &&
                Validator.IsNonNegativeInt(txtSupplierId)
                )
            {
                // put data into ProductsSupplier object
                if (prodsup != null)
                {
                    prodsup.ProductId = Convert.ToInt32(txtProductId.Text);
                    prodsup.SupplierId = Convert.ToInt32(txtSupplierId.Text);
                    this.DialogResult = DialogResult.OK; // closes the form
                }
                
            }
        }

        // Add button to add new product supplier
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // check if user input valid data
            if (Validator.IsValid(txtProductId) &&
                Validator.IsNonNegativeInt(txtProductId) &&
                Validator.IsValid(txtSupplierId) &&
                Validator.IsNonNegativeInt(txtSupplierId)
                )
            {
                if (isAdd) // Add - make a new product supplier object
                {
                    prodsup = new ProductsSupplier();
                }
                // put data into ProductsSupplier object
                if (prodsup != null)
                {
                    prodsup.ProductId = Convert.ToInt32(txtProductId.Text);
                    prodsup.SupplierId = Convert.ToInt32(txtSupplierId.Text);
                }
                this.DialogResult = DialogResult.OK; // closes the form
            }

        }
        // when click cancel button it close the current form 
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
