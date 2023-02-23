// Created by Manpreet Sidhu
// this form add or edit the data in  a travel packages.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PackagesData;

namespace TravelExpertsGUI
{
    public partial class AddTravelPackages : Form
    {
        // declare the variables
        public bool isAdd;
        public Package? package;
        public ProductsSupplier? productsSupplier;
        public Product? product;
        public   PackagesProductsSupplier? pkgprodsupp;
        public  int product_id;
        public int supplier_id;

        // constructor 
        public AddTravelPackages()
        {
            InitializeComponent();
        }

        // add the starts when form load
        private void AddTravelPackages_Load(object sender, EventArgs e)
        {
           try
            {
                using(TravelExpertsContext context = new TravelExpertsContext())
                {
                    // add data in combox(cboproducts)
                    List<Product> products = context.Products.ToList();
                    cboProducts.DataSource = products;
                    cboProducts.DisplayMember = "ProdName";
                    cboProducts.ValueMember = "ProductId";
                    cboProducts.SelectedIndex = -1;
                    // add data to the cbosuppliercombobox
                    List<Supplier> suppliers = context.Suppliers.ToList();
                    cboSuppliers.DataSource = suppliers;
                    // data displayed by suppliername
                    cboSuppliers.DisplayMember = "SupName";
                    cboSuppliers.ValueMember = "SupplierId";
                    cboSuppliers.SelectedIndex = -1;    


                    // if is add true
                    if (isAdd)
                    {
                        this.Text = "Add Packages";
                        txtid.ReadOnly = true;
                        

                    }
                    // if id add = false, then modify the data
                    else
                    {
                        this.Text = "Modify Packages";
                        // call function to display values
                        DisplayPackage();
                    }
                }
            }
                // if error occur
            catch (Exception ex)
            {
                MessageBox.Show("Error when retrieving data: " + ex.Message,
                                ex.GetType().ToString());
            }

        }
        // user accept new data
        private void btnAccept_Click(object sender, EventArgs e)
        {
            // validating the textbox, combobox, datetimepicker
            if(Validator.IsProvided(txtname)&& Validator.IsProvided(txtdescription)&&Validator.IsProvided(txtcommission)
                && Validator.IsProvided(txtbaseprice)&&Validator.IsNonNegativeDecimal(txtbaseprice)
                && Validator.IsNonNegativeDecimal(txtcommission) 
                && Validator.IsCompareDate(StartDatePicker,EndDatePicker)
                && Validator.CompareCommissiontoBase(txtbaseprice,txtcommission)&& Validator.IsSelected(cboProducts))

            {
                if(isAdd) // add make a new object
                {
                    // create an object of package and product supplier
                    package = new Package();
                    productsSupplier = new ProductsSupplier(); 
                }
                //when Package and Product Supplier Not Null
                if (package != null && productsSupplier != null)
                {
                    // assign values to the package object 
                    package.PkgName = txtname.Text;
                    package.PkgDesc = txtdescription.Text;
                    package.PkgStartDate = Convert.ToDateTime(StartDatePicker.Text);
                    package.PkgEndDate = Convert.ToDateTime(EndDatePicker.Text);
                    package.PkgBasePrice = Convert.ToDecimal(txtbaseprice.Text);
                    package.PkgAgencyCommission = Convert.ToDecimal(txtcommission.Text);
                    productsSupplier.ProductId = Convert.ToInt32( cboProducts.SelectedValue);
                    productsSupplier.SupplierId = (int?)cboSuppliers.SelectedValue;
  
                }
                this.DialogResult = DialogResult.OK;
            }
        }

// function to display the data 
        public void DisplayPackage()
        {
            if (package != null)
            {
                // assign values to the textboxes
                txtid.Text = package.PackageId.ToString();
                txtdescription.Text = package.PkgDesc;
                txtname.Text = package.PkgName;
                txtbaseprice.Text = package.PkgBasePrice.ToString();
                txtcommission.Text = package.PkgAgencyCommission.ToString();
                StartDatePicker.Value = Convert.ToDateTime(package.PkgStartDate);
                EndDatePicker.Value = Convert.ToDateTime(package.PkgEndDate);
                cboProducts.SelectedText = product.ProdName;
                using (TravelExpertsContext context = new TravelExpertsContext())
                {
                    // from supplierid find supplier name and assign to combobox.
                    int? id = productsSupplier.SupplierId;
                   Supplier supplier =  context.Suppliers.Find(id);
                    cboSuppliers.SelectedText = supplier.SupName;
                    // find the productid from product name
                    product.ProductId = context.Products.Where(p=>p.ProdName == product.ProdName).
                        Select(x=>x.ProductId).SingleOrDefault();
                }
                // call function to findpackageproductsuppluerid for edit method
              int packageproductsupplierid= FindPackageProductSupplierID(product.ProductId, productsSupplier.SupplierId, package.PackageId);   
               pkgprodsupp.PackageProductSupplierId = packageproductsupplierid;

                // primary key in modify readonly
                txtid.ReadOnly = true;

            }

        }
        // to add data in a PackageProductSupplier
        public  void AddPackage_Product_Supplier(int? product_id)
        {
            try
            {
                int? supplier_id = productsSupplier.SupplierId;
                using (TravelExpertsContext context = new TravelExpertsContext())
                {
                    // find the productsuplierid
                    var productsupplierid = context.ProductsSuppliers.
                          Where(ps => ps.ProductId == product_id && ps.SupplierId == supplier_id).
                          Select(x => x.ProductSupplierId).SingleOrDefault();
                    // find the packageid
                    var package_id = context.Packages.Max(p => p.PackageId).ToString();
                    pkgprodsupp = new PackagesProductsSupplier();

                    pkgprodsupp.ProductSupplierId = productsupplierid;
                    pkgprodsupp.PackageId = package.PackageId;
                    // add to the packageproductsupplier 
                    context.PackagesProductsSuppliers.Add(pkgprodsupp);
                    // save the changes
                    context.SaveChanges();

                }
            }
            // if error occur 
            catch(Exception e)
            {
                 MessageBox.Show("Unable to find productsupplierid related to productid and supplieris"+e.Message + e.GetType());
            }
        }
        // method to find PackageProductSupplierID
        public int FindPackageProductSupplierID(int product_id,int? supplier_id,int package_id)
        {
            using (TravelExpertsContext context = new TravelExpertsContext())
            {
                // find productsupplierid first
                var productsupplierid = context.ProductsSuppliers.
                    Where(ps => ps.ProductId == product_id && ps.SupplierId == supplier_id).
                    Select(x => x.ProductSupplierId).SingleOrDefault();
                pkgprodsupp = new PackagesProductsSupplier();
                // use the productsupplierid and find packageproduct supplierid 
               var packageproductsupplierid = context.PackagesProductsSuppliers.
                    Where(ps=> ps.ProductSupplierId == productsupplierid && ps.PackageId == package_id).
                    Select(x=> x.PackageProductSupplierId).SingleOrDefault();

                // return the packageproductsupplier
                return packageproductsupplierid;

            }
        }

      
        // When click cancel button close the  form
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
