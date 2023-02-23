namespace TravelExpertsGUI
{
    partial class FrmTravelAgency
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.travelPackagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productSupplierDatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvdisplaydata = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisplaydata)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.travelPackagesToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.suppliersToolStripMenuItem,
            this.productSupplierDatsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // travelPackagesToolStripMenuItem
            // 
            this.travelPackagesToolStripMenuItem.Name = "travelPackagesToolStripMenuItem";
            this.travelPackagesToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.travelPackagesToolStripMenuItem.Text = "Travel Packages";
            this.travelPackagesToolStripMenuItem.Click += new System.EventHandler(this.travelPackagesToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            this.suppliersToolStripMenuItem.Click += new System.EventHandler(this.suppliersToolStripMenuItem_Click);
            // 
            // productSupplierDatsToolStripMenuItem
            // 
            this.productSupplierDatsToolStripMenuItem.Name = "productSupplierDatsToolStripMenuItem";
            this.productSupplierDatsToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.productSupplierDatsToolStripMenuItem.Text = "Product Supplier Data";
            this.productSupplierDatsToolStripMenuItem.Click += new System.EventHandler(this.productSupplierDatsToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvdisplaydata
            // 
            this.dgvdisplaydata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdisplaydata.Location = new System.Drawing.Point(12, 60);
            this.dgvdisplaydata.Name = "dgvdisplaydata";
            this.dgvdisplaydata.RowHeadersWidth = 51;
            this.dgvdisplaydata.RowTemplate.Height = 29;
            this.dgvdisplaydata.Size = new System.Drawing.Size(1159, 260);
            this.dgvdisplaydata.TabIndex = 1;
            this.dgvdisplaydata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdisplaydata_CellClick);

            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnadd.Location = new System.Drawing.Point(323, 372);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(179, 54);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "&ADD New";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Visible = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnedit.Location = new System.Drawing.Point(566, 372);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(179, 54);
            this.btnedit.TabIndex = 3;
            this.btnedit.Text = "&EDIT Existing";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Visible = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(215, 369);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(739, 50);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Please select a tab to view, edit, or add data";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(1051, 392);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 48);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmTravelAgency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 477);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgvdisplaydata);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblWelcome);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmTravelAgency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Experts Data";
            this.Load += new System.EventHandler(this.FrmTravelAgency_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisplaydata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem travelPackagesToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem suppliersToolStripMenuItem;
        private ToolStripMenuItem productSupplierDatsToolStripMenuItem;
        private DataGridView dgvdisplaydata;
        private Button btnadd;
        private Button btnedit;
        private Label lblWelcome;
        private Button btnClose;
    }
}