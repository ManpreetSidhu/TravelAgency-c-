// Created by Micah Brown 
using PackagesData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TravelExpertsGUI
{
    // code created by Micah Brown 
    public partial class AddModifySupplier : Form
    {
        // define variables
        public bool isAdd;
        public int newSuppId;
        public Supplier? selectedSupplier; //selected supplier

        public AddModifySupplier()
        {
            InitializeComponent();
        }

        // when form loads
        private void AddModifySupplier_Load(object sender, EventArgs e)
        {
            // call function 
            LoadSupplier();
        }
        
        // popultae datagridview - list of suppliers
        private void LoadSupplier()
        {
            // if modify /edit 
            if(isAdd == false)
            {
                // pass the values to the textboxex
                txtSupplierId.Text = selectedSupplier.SupplierId.ToString();
                txtSupplier.Text = selectedSupplier.SupName;
            }
            // if is add u=is true
            else 
            { 
                txtSupplierId.Text = newSuppId.ToString();
                txtSupplierId.ReadOnly = true;
                txtSupplier.Focus();
            }
        }
        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (isAdd) // Add - make  a new supplier object
                {
                    selectedSupplier = new Supplier(); //if add button was clicked, a new supplier object is created
                    
                }
                // put data into product object
                if (selectedSupplier != null) //assign text box inputs to Product product
                {
                    selectedSupplier.SupName = txtSupplier.Text;
                    selectedSupplier.SupplierId = Convert.ToInt32(txtSupplierId.Text);
                }
               
                this.DialogResult = DialogResult.OK;    //.OK means closes form with data, .CANCEL closes the form without data
            }
          
        }

        // Call the function to make sure textbox has a valid input
        private bool IsValidData()
        {
            return Validator.IsProvided(txtSupplier);
        }


        // ccancel button close the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}

