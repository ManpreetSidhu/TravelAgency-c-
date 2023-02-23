// Created by Micah, Aaron, Meet Grewal and Manpreet 
using Microsoft.EntityFrameworkCore;
using PackagesData;
using System.Windows.Forms;

namespace TravelExpertsGUI
{
    public partial class FrmTravelAgency : Form
    {
        // declare the variables
        private Package? selectedpackage = null;
        public Supplier? supplier; //selected supplier
        //private Product? selectedproduct = null;
        private List<Product> products = new List<Product>();
        private Product? selectedProduct = null;
        private int indexRow;
        public DataGridViewRow row;
        private ProductsSupplier? selectedProdsup = null;
        private PackagesProductsSupplier? selectedPkgProductSupplier = null;

        public bool suppliersTabSelected = false;
        public bool productsTabSelected = false;
        public bool productsupplierTabSelected = false;
        public bool packagesTabSelected = false;

        // constructor 
        public FrmTravelAgency()
        {
            InitializeComponent();
        }

        // when click add button 
        private void btnadd_Click(object sender, EventArgs e)
        {
            //when supplier tab is selected
            // code created by Micah Brown
            if (suppliersTabSelected == true)
            {
                TravelExpertsContext db = new TravelExpertsContext();
                // create an object of AddModifySupplier Form 
                AddModifySupplier form = new AddModifySupplier();
                // if adding the data
                form.isAdd = true;
                form.Text = "Add Supplier";
                // create a autogenrateid
                int newSupplierId = db.Suppliers.Max(p => p.SupplierId) + 1;
                // make new object of supplier
                supplier = new Supplier();
                //assign the new Supplierid to the Supplier object in the second(AddModifySupplier form)
                form.newSuppId = newSupplierId;
                //open the another  form 
                DialogResult result2 = form.ShowDialog();

                if (result2 == DialogResult.OK)
                {
                    // assign the values from second form object to the supplier object
                    supplier = form.selectedSupplier;
                    try
                    {
                        // if data in the supllier object
                        if (supplier != null) //if supplier exists and is not null
                        {
                            // add to the databse
                            db.Suppliers.Add(supplier);
                            // save the changes
                            db.SaveChanges();
                            DisplaySuppliers(); //Suppliers are displayed once again in datagridview with updated Suppliers
                        }
                    }
                    // if error occur catch and show the error
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while adding supplier: " + ex.Message,
                        ex.GetType().ToString());
                    }
                }

            }
            // Code created by Manpreet Sidhu
            // if Package tab is selected
    if (packagesTabSelected == true)
         {
                    // create a object of addtravelpackageform
                    AddTravelPackages addTravelPackages = new AddTravelPackages();
                    // if isadd true
                    addTravelPackages.isAdd = true;
                    addTravelPackages.package = null;
                    // show another form 
                    DialogResult result = addTravelPackages.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // create an object of selected package 
                    selectedpackage = addTravelPackages.package;
                    try
                    {
                        using (TravelExpertsContext context = new TravelExpertsContext())
                        {
                         //add to the database
                            context.Add(selectedpackage);
                            // save the changes
                            context.SaveChanges();
                            // get product_id of selectedpackage
                            int? product_id = addTravelPackages.productsSupplier.ProductId;
                            // call method to add data in Package_productSupplier and pass productid to find productsupplierid
                            addTravelPackages.AddPackage_Product_Supplier(product_id);
                        }
                       // call method to display the packages
                        DisplayPackages();
                    }
                    // if add to a database failed shows error
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while adding data:" + ex.Message, ex.GetType().ToString());
                    }
                }  
            }
// if productsupplier tab is selcted
// Code created by Meet Kamal Grewal 
        if(productsupplierTabSelected == true)
            {
                // create an object of Modify Product Supplier
                ModifyProductSuppliers secondForm = new ModifyProductSuppliers();
                // when adding a data
                secondForm.isAdd = true;
                secondForm.Text = "Add Product Supplier";
                // display the form
                DialogResult result = secondForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TravelExpertsContext db = new TravelExpertsContext();
                    //Find the product and supplier with product id and supplier id
                    var product = db.Products.Find(secondForm.prodsup.ProductId);
                    var supplier = db.Suppliers.Find(secondForm.prodsup.SupplierId);
                    // check if there is a productid and supplier in the database
                    if (product == null && supplier == null)
                    {
                        MessageBox.Show("Product ID and Supplier ID are not registered in the database, please try again");
                    }
                    // check if product id in the database exist
                    else if (product == null)
                    {
                        MessageBox.Show("Product ID is not registered in the database, please try again");
                    }
                    //check if supplier id in the database exist
                    else if (supplier == null)
                    {
                        MessageBox.Show("Supplier ID is not registered in the database, please try again");
                    }
                    else
                    {// if data already exist in the database
                        var existingProductSupplier = db.ProductsSuppliers
                            .SingleOrDefault(ps => ps.ProductId == secondForm.prodsup.ProductId
                                && ps.SupplierId == secondForm.prodsup.SupplierId);
                        if (existingProductSupplier != null)
                        {
                            MessageBox.Show("Product Supplier already exists in the database");
                        }
                        // if not exist then add to the database
                        else
                        {
                            ProductsSupplier newProductSupplier = new ProductsSupplier
                            {
                                // get the values
                                ProductId = secondForm.prodsup.ProductId,
                                SupplierId = secondForm.prodsup.SupplierId
                            };
                            // add to the database
                            db.ProductsSuppliers.Add(newProductSupplier);
                            // save the changes
                            db.SaveChanges();
                            // shows validation message
                            MessageBox.Show("New Product Supplier was Added Successfully");
                            DisplayProductSupplierData();   // refreshes with new data  
                        }
                    }
                }
            }
        // if Product Tab is selected 
        // code created by  Aaron Reid
        if(productsTabSelected == true)
            {
                // create a object of second Form (Addform)
                AddProduct secondform = new AddProduct();
                // if data added
                secondform.isAdd = true;

                DialogResult result = secondform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // create  new object of product
                    Product newprod = new Product();
                    //assign to the object
                    newprod.ProductId = secondform.product.ProductId;
                    newprod.ProdName = secondform.product.ProdName;

                    try
                    {
                        using (TravelExpertsContext db = new TravelExpertsContext())
                        {
                            // save data to the database
                            db.Products.Add(newprod);
                            // save the changes
                            db.SaveChanges();
                            
                        }
                        // call method to display the refreshed data
                        LoadProducts();
                    }
                    // if concurrency exception Occur
                    catch (DbUpdateConcurrencyException ex)
                    {
                        Console.WriteLine("Error while saving the entity changes: " + ex.Message);
                        Console.WriteLine("Inner exception: " + ex.InnerException);

                    }
                    // if any other exception occur 
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while adding product" + ex.Message,
                            ex.GetType().ToString());
                    }
                }
            }
        }


// When Edit Button Clicked
        private void btnedit_Click(object sender, EventArgs e)
        {
            // when Product Tab is selected
            // code created by  Aaron Reid
            if (productsTabSelected == true)
            {

                TravelExpertsContext context = new TravelExpertsContext();
                // Select first row if not any other row selected
                var selectedRow = (from p in context.Products
                                   where p.ProductId == Convert.ToInt32(dgvdisplaydata.CurrentRow.Cells[0].Value)
                                   select new { p.ProductId, p.ProdName }).SingleOrDefault();
                // if row selected.
                if (selectedRow != null)
                {
                    // craete a new object of product 
                    selectedProduct = new Product
                    {
                        // assign the values to the object of the product
                        ProductId = selectedRow.ProductId,
                        ProdName = selectedRow.ProdName,
                    };
                }
                // make an object of another form AddProduct()
                AddProduct secondform = new AddProduct();
                secondform.isAdd = false;
                secondform.Text = "Edit Products";
                // pass the data to the next form
                secondform.product = selectedProduct;

                DialogResult result = secondform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    try
                    {
                        using (TravelExpertsContext db = new TravelExpertsContext())
                        {
                            // Get the data from AddProductForm 
                            int prodid = secondform.product.ProductId;
                            // find product by Id
                            selectedProduct = db.Products.FirstOrDefault(p => p.ProductId == prodid);
                            // if SelectedProduct is not empty
                            if (selectedProduct != null)
                            {
                                // assign the modified values
                                secondform.product.ProductId = selectedProduct.ProductId;
                                selectedProduct.ProdName = secondform.product.ProdName;
                                // update the database
                                db.Update(selectedProduct);
                                // save the changes
                                db.SaveChanges();
                                // callmethod to show modified data
                                LoadProducts();
                            }
                        }
                    }
                    // if error occur while update
                    catch (DbUpdateConcurrencyException ex)
                    {
                        Console.WriteLine("Error while saving the entity changes: " + ex.Message);
                        Console.WriteLine("Inner exception: " + ex.InnerException);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while adding product " + ex.Message,
                            ex.GetType().ToString());
                    }
                }
            }
     // when supplier tab is selected
     //Created By MIcah 
            if (suppliersTabSelected == true)
            {
                // create new context 
                TravelExpertsContext context = new TravelExpertsContext();
                // if not selected any other row - by  default first row selected
                var selectedRow = (from p in context.Suppliers
                                   where p.SupplierId == Convert.ToInt32(dgvdisplaydata.CurrentRow.Cells[0].Value)
                                   select new { p.SupplierId, p.SupName }).SingleOrDefault();
                // if data in a selected roe
                if (selectedRow != null)
                {
                    // new object of supplier is created and assign the data from selected roe
                    supplier = new Supplier
                    {
                        SupplierId = selectedRow.SupplierId,
                        SupName = selectedRow.SupName,
                    };
                }
                // create a new form
                AddModifySupplier form = new AddModifySupplier();
                // if Edit 
                form.isAdd = false;
                // text changed to Edit 
                form.Text = "Edit Supplier";
                // Assign supplier object to secondform(AddModifySuppler)
                form.selectedSupplier = supplier;
                // show the AddModify Form 
                DialogResult result2 = form.ShowDialog();

                if (result2 == DialogResult.OK)
                {
                    try
                    {
                        using (TravelExpertsContext db = new TravelExpertsContext()) //create new instance of DB
                        {
                            int supId = form.selectedSupplier.SupplierId; //assigning supplierid  text box string to new variable
                            supplier = db.Suppliers.Find(supId); //using supplierid variable to find that Supplier in DB

                            if (supplier != null) //if supplier exists and is not null
                            {
                                //new user-input data overwrites SelectedSupplier and changes are saved to DB
                                supplier.SupplierId = form.selectedSupplier.SupplierId;
                                supplier.SupName = form.selectedSupplier.SupName;

                                db.SaveChanges();
                                DisplaySuppliers(); //products are displayed once again in DatagridView with updated product
                            }
                        }
                    }
                    // if exception occur throws error
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while adding supplier: " + ex.Message,
                        ex.GetType().ToString());
                    }
                }
            }
// when Package Tab is selected
// Code by Manpreet Sidhu 
            if (packagesTabSelected == true)
            {
                //Craete an object of AddTravelPackage form 
                AddTravelPackages addTravelPackages = new AddTravelPackages();
                TravelExpertsContext db = new TravelExpertsContext();
                // first row is selcted by default
                var selectedRow = (from p in db.Packages
                                   where p.PackageId == Convert.ToInt32(dgvdisplaydata.CurrentRow.Cells[0].Value)
                                   select new { p.PackageId, p.PkgName, p.PkgDesc, p.PkgStartDate, p.PkgEndDate, p.PkgBasePrice, p.PkgAgencyCommission }).SingleOrDefault();
                // when select a row
                if (selectedRow != null)
                {   // assign values to a selected package
                    selectedpackage = new Package
                    {
                        PackageId = selectedRow.PackageId,
                        PkgName = selectedRow.PkgName,
                        PkgDesc = selectedRow.PkgDesc,
                        PkgStartDate = selectedRow.PkgStartDate,
                        PkgEndDate = selectedRow.PkgEndDate,
                        PkgBasePrice = selectedRow.PkgBasePrice,
                        PkgAgencyCommission = selectedRow.PkgAgencyCommission,
                    };
                    //  create a new productsupplier and assign the value of Supplierid of selected row
                    selectedProdsup = new ProductsSupplier()
                    {
                        // convert the value to Int and assign to SuplierID
                        SupplierId = Convert.ToInt32(dgvdisplaydata.CurrentRow.Cells[8].Value)
                    };
                    // create a new product and assign the value of ProductName of selected row
                    selectedProduct = new Product()
                    {
                        // assign the value of selected cell to the prodname
                        ProdName = dgvdisplaydata.CurrentRow.Cells[7].Value.ToString(),
                    };
                }

                // if is add is false, means modify or edit 
                addTravelPackages.isAdd = false;
                //assign values of selected package to package object to addtravel form
                addTravelPackages.package = selectedpackage;
                //assign values of selected Product to product object to addtravel form
                addTravelPackages.product = selectedProduct;
                addTravelPackages.productsSupplier = selectedProdsup;
                // open AddTravel form
                DialogResult result = addTravelPackages.ShowDialog();

                if (result == DialogResult.OK)
                {
                    try
                    {
                        // create database context
                        using (TravelExpertsContext context = new TravelExpertsContext())

                        {
                            // if selected package have some value
                            if (selectedpackage != null)
                            {
                                if (addTravelPackages.package != null)
                                {
                                    // assign packageid value
                                    int Pkg_ID = addTravelPackages.package.PackageId;
                                    if (selectedpackage != null)
                                    {
                                        // find the data associated with package_Id
                                        selectedpackage = context.Packages.Find(Pkg_ID);
                                        // assign modified values
                                        selectedpackage.PkgName = addTravelPackages.package.PkgName;
                                        selectedpackage.PkgDesc = addTravelPackages.package.PkgDesc;
                                        selectedpackage.PkgStartDate = addTravelPackages.package.PkgStartDate;
                                        selectedpackage.PkgEndDate = addTravelPackages.package.PkgEndDate;
                                        selectedpackage.PkgBasePrice = addTravelPackages.package.PkgBasePrice;
                                        selectedpackage.PkgAgencyCommission = addTravelPackages.package.PkgAgencyCommission;
                                        // get supplier id and product id 
                                        int supplier_id = (int)addTravelPackages.productsSupplier.SupplierId;
                                        int product_id = (int)addTravelPackages.productsSupplier.ProductId;
                                        // get packageproductsupplierid 
                                        int package_product_Supplierid = (int)addTravelPackages.pkgprodsupp.PackageProductSupplierId;
                                        selectedPkgProductSupplier = db.PackagesProductsSuppliers.Find(package_product_Supplierid);
                                        try
                                        {
                                            if (selectedPkgProductSupplier != null)
                                            {
                                                // find productsupplierid of modified data
                                                var productsupplierid = context.ProductsSuppliers.
                                                Where(ps => ps.ProductId == product_id && ps.SupplierId == supplier_id).
                                                Select(x => x.ProductSupplierId).SingleOrDefault();
                                                // assign modified values
                                                selectedPkgProductSupplier.PackageId = addTravelPackages.package.PackageId;
                                                selectedPkgProductSupplier.ProductSupplierId = productsupplierid;
                                                // update the database and save changes.
                                                context.PackagesProductsSuppliers.Update(selectedPkgProductSupplier);
                                                context.SaveChanges();
                                            }
                                        }
                                       catch (Exception ex)
                                        {
                                            MessageBox.Show("Please check Product Supplier Combination - not found in the database");
                                        }
                                        // save changes 
                                        context.SaveChanges();
                                    }
                                }
                            }
                            // call displaylist to see a modified list 
                            DisplayPackages();
                        }
                    }
                    // if exception occurs
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while Editing data" );
                    }
                }
            }
            // if product supplier tab is selected
            // code created by  Meet Kamal Grewal
            if (productsupplierTabSelected == true)
            {
                ModifyProductSuppliers secondForm = new ModifyProductSuppliers();
                // create an context of database
                TravelExpertsContext db = new TravelExpertsContext();
                // if no row selected- by default first row selected
                var selectedRow = (from p in db.ProductsSuppliers
                                   where p.ProductSupplierId == Convert.ToInt32(dgvdisplaydata.CurrentRow.Cells[0].Value)
                                   select new { p.ProductSupplierId, p.ProductId, p.SupplierId }).SingleOrDefault();

                // if data in a selected row
                if (selectedRow != null)
                {
                    // create an oject of product Supplier
                    selectedProdsup = new ProductsSupplier
                    {
                        // assign values to the object 
                        ProductSupplierId = selectedRow.ProductSupplierId,
                        ProductId = selectedRow.ProductId,
                        SupplierId = selectedRow.SupplierId
                    };
                    // pass the values to the another form(ModifyProduct Supplier)
                    secondForm.prodsup = selectedProdsup;

                    secondForm.isAdd = false; // modifying existing product
                    // text on a form 
                    secondForm.Text = "Modify Product Supplier";
                    DialogResult result = secondForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        // find the product and supplier by product id and supplier id 
                        var product = db.Products.Find(secondForm.prodsup.ProductId);
                        var supplier = db.Suppliers.Find(secondForm.prodsup.SupplierId);
                        // if product andsupplier id not exist in the database
                        if (product == null && supplier == null)
                        {
                            MessageBox.Show("Product ID and Supplier ID are not registered in the database, please try again");
                        }
                        // if product not exist in the database regarding productid
                        else if (product == null)
                        {
                            MessageBox.Show("Product ID is not registered in the database, please try again");
                        }
                        // if supplierid not exist in database 
                        else if (supplier == null)
                        {
                            MessageBox.Show("Supplier ID is not registered in the database, please try again");
                        }
                        else
                        {
                            // find if combintion of product  supplier id exist in the database
                            var existingProductSupplier = db.ProductsSuppliers
                                .SingleOrDefault(ps => ps.ProductId == secondForm.prodsup.ProductId
                                    && ps.SupplierId == secondForm.prodsup.SupplierId);
                            // if exist (true)
                            if (existingProductSupplier != null)
                            {
                                MessageBox.Show("Product Supplier already exists in the database");
                            }
                            // if existingproductsupplier is empty 
                            else
                            {
                                // assign modified values 
                                ProductsSupplier newProductSupplier = new ProductsSupplier
                                {
                                    ProductId = secondForm.prodsup.ProductId,
                                    SupplierId = secondForm.prodsup.SupplierId
                                };
                                // add to the database
                                db.ProductsSuppliers.Add(newProductSupplier);
                                // save the changes
                                db.SaveChanges();
                                // Show Sucessfull added message
                                MessageBox.Show("New Product Supplier was Added Successfully");
                                DisplayProductSupplierData();   // refreshes with new data  
                            }
                        }
                    }
                }
            }
        }


/// <summary>
/// Methods to Display the data in a datagrid view
/// </summary>
     
        // function to display ProductSupplierData
        // Created by Meet Grewal 
        private void DisplayProductSupplierData()
        {
            dgvdisplaydata.Columns.Clear();
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                dgvdisplaydata.DataSource = db.ProductsSuppliers.Select(p => new
                {
                    p.ProductSupplierId,
                    p.ProductId,
                    p.SupplierId,
                }).ToList();
                //formating grid
                dgvdisplaydata.Columns[0].HeaderText = "Product Supplier ID";
                dgvdisplaydata.Columns[1].HeaderText = "Product ID";
                dgvdisplaydata.Columns[2].HeaderText = "Supplier ID";
                dgvdisplaydata.ColumnHeadersDefaultCellStyle.BackColor = Color.RosyBrown;
                dgvdisplaydata.Columns[0].Width = 200;
                dgvdisplaydata.Columns[1].Width = 200;
                dgvdisplaydata.Columns[2].Width = 195;
            } // end of scope for created object
        }

        // function to display Packages
        // created by Manpreet Sidhu
        public void DisplayPackages()
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                // linq query for left join of Product, Package, ProductSupplier and PackagesProductsSuppliers
                // created by Manpreet and Meet Grewal 
                dgvdisplaydata.DataSource = (from Package in db.Packages 
                                             join PackagesProductsSupplier in db.PackagesProductsSuppliers 
                                             on Package.PackageId equals PackagesProductsSupplier.PackageId 
                                             into ps from PackagesProductsSupplier in ps.DefaultIfEmpty() 
                                             join ProductSupplier in db.ProductsSuppliers 
                                             on PackagesProductsSupplier.ProductSupplierId equals ProductSupplier.ProductSupplierId 
                                             into pss from ProductSupplier in pss.DefaultIfEmpty() 
                                             join Product in db.Products 
                                             on ProductSupplier.ProductId equals Product.ProductId 
                                             into prods from Product in prods.DefaultIfEmpty() 
                                             select new 
                                             { Package.PackageId, Package.PkgName, Package.PkgDesc, Package.PkgStartDate,
                                                 Package.PkgEndDate, Package.PkgBasePrice, Package.PkgAgencyCommission,
                                                 Product.ProdName, ProductSupplier.SupplierId ,
                                            }).ToList();
         
                // format the data grid view
                // apply the display names 
                dgvdisplaydata.Columns[0].HeaderText = "ID";
                dgvdisplaydata.Columns[1].HeaderText = "Name";
                dgvdisplaydata.Columns[2].HeaderText = "Description";
                dgvdisplaydata.Columns[3].HeaderText = "Start Date";
                dgvdisplaydata.Columns[4].HeaderText = "End Date";
                dgvdisplaydata.Columns[5].HeaderText = "Base Price";
                dgvdisplaydata.Columns[6].HeaderText = "Commission";
                dgvdisplaydata.Columns[7].HeaderText = "Product Name";
                // width of columns
                dgvdisplaydata.Columns[1].Width = 200;
                dgvdisplaydata.Columns[2].Width = 340;
                dgvdisplaydata.Columns[3].Width = 200;
                dgvdisplaydata.Columns[4].Width = 200;
                // format in currency 
                dgvdisplaydata.Columns[5].DefaultCellStyle.Format = "c2";
                dgvdisplaydata.Columns[6].DefaultCellStyle.Format = "c2";
                // format start date and end date
                dgvdisplaydata.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm";
                dgvdisplaydata.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm";
                dgvdisplaydata.ColumnHeadersDefaultCellStyle.BackColor = Color.RosyBrown;
                dgvdisplaydata.EnableHeadersVisualStyles = false;
                btnadd.Visible = true;

            }
        }

// function to  display suppliers.
// created by Micah Brown 
        public void DisplaySuppliers()
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                dgvdisplaydata.DataSource = db.Suppliers.
                Select(s => new
                {
                    s.SupplierId,
                    s.SupName
                }).OrderBy(s => s.SupplierId).ToList();
                // format the datagridview
                dgvdisplaydata.Columns[1].HeaderText = "Supplier Name";
                dgvdisplaydata.Columns[1].Width = 400;
                dgvdisplaydata.ColumnHeadersDefaultCellStyle.BackColor = Color.RosyBrown;
                btnadd.Visible = true;
                row = dgvdisplaydata.Rows[1];

            }
        }

// function to display the product data
// created by Aaron
        private void LoadProducts()
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                dgvdisplaydata.DataSource = db.Products.
                Select(p => new
                {
                    p.ProductId,
                    p.ProdName
                }).ToList();
                //fitting the cells to the data grid
                dgvdisplaydata.Columns[0].HeaderText = "Product ID";
                dgvdisplaydata.Columns[0].Width = 150;
                dgvdisplaydata.Columns[1].HeaderText = "Product Name";
                dgvdisplaydata.Columns[1].Width = 400;
                dgvdisplaydata.ColumnHeadersDefaultCellStyle.BackColor = Color.RosyBrown;
            }
            btnadd.Text = "Add";
        }

        // when form load
        private void FrmTravelAgency_Load(object sender, EventArgs e)
        {

        }

   // when click on any cell assign that row
   //  created by Aaron Reid
        private void dgvdisplaydata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvdisplaydata.Rows[e.RowIndex];
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    selectedProduct = db.Products.Find(row.Cells[0].Value);
                }
            }
        }

// when product from menu is clicked
// created by Micah Brown 
        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //all others tabs false
            suppliersTabSelected = false;
            productsTabSelected = true;
            productsupplierTabSelected = false;
            packagesTabSelected = false;
            // call function to load products
            LoadProducts();
            // add and edit button visible
            btnadd.Visible = true;
            btnedit.Visible = true;
            lblWelcome.Visible = false;
            

        }
// when travel Package tab is clicked
// created by Micah Brown 
        private void travelPackagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // call displaypackage to display all the package data
            DisplayPackages();
            suppliersTabSelected = false;
            productsTabSelected = false;
            productsupplierTabSelected = false;
            packagesTabSelected = true;
            //add and edit buttons visible
            btnadd.Visible = true;
            btnedit.Visible = true;
            lblWelcome.Visible = false;
            

        }
// when Supplier Tab is selected
// created by Micah Brown 
        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // call method Display Supplier to display the data for supplier
            DisplaySuppliers();
            suppliersTabSelected = true;
            productsTabSelected = false;
            productsupplierTabSelected = false;
            packagesTabSelected = false;
            // add and edit buttons visible
            btnadd.Visible = true;
            btnedit.Visible = true;
            lblWelcome.Visible = false;
        }
// when ProductSupplierData Tab is selected
// created by Micah Brown 
        private void productSupplierDatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // call method to Display Data of ProductSupplier Data
            DisplayProductSupplierData();
            suppliersTabSelected = false;
            productsTabSelected = false;
            productsupplierTabSelected = true;
            packagesTabSelected = false;
            // Button Add or Edit Visible 
            btnadd.Visible = true;
            btnedit.Visible = true;
            lblWelcome.Visible = false;
        }

//When Click Close Button 
        private void btnClose_Click(object sender, EventArgs e)
        {
            // Exit the Application
            Application.Exit();
        }

        
    }
}
