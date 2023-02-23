// created by Aaron Reid
using TravelExpertsGUI;
using PackagesData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsGUI
{
    
    public partial class AddProduct : Form
    {
        // define the variables
        public Product product;
        public bool isAdd;
        
        // constructor
        public AddProduct()
        {
            InitializeComponent();
        }

        // when form loads
        private void AddProduct_Load(object sender, EventArgs e)
        {
            try
            { // is add true
                if (isAdd)
                {
                    this.Text = "Add Product";
                }
                // if modify 
                else
                {
                    this.Text = "Edit";
                    txtProdID.Text = product.ProductId.ToString();
                    txtProdName.Text = product.ProdName;
                }
            }
            // catched and show error 
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, GetType().ToString());
            }
            
        }
        // when add button click 
        private void btnadd_Click(object sender, EventArgs e)
        {
            // validate thr textbox for Product name - has a valid input 
            if (Validator.IsProvided(txtProdName))
            {
                if(isAdd)
                {
                    // object of product 
                    this.product = new Product();
                }
                // pass the values to the object of Product Class
                product.ProdName = txtProdName.Text;
                this.DialogResult = DialogResult.OK;
                
            }
        }

        // when click the cancel button - close the form 
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
