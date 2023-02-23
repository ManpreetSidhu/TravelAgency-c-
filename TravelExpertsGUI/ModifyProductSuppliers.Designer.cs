namespace TravelExpertsGUI
{
    partial class ModifyProductSuppliers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.lblProdSuppId = new System.Windows.Forms.Label();
            this.txtProdSuppId = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(135, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(137, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier Id :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(163, 319);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 31);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(285, 319);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 31);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(269, 115);
            this.txtProductId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(114, 27);
            this.txtProductId.TabIndex = 6;
            this.txtProductId.Tag = "Product ID";
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Location = new System.Drawing.Point(269, 197);
            this.txtSupplierId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.Size = new System.Drawing.Size(114, 27);
            this.txtSupplierId.TabIndex = 7;
            this.txtSupplierId.Tag = "Supplier ID";
            // 
            // lblProdSuppId
            // 
            this.lblProdSuppId.AutoSize = true;
            this.lblProdSuppId.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProdSuppId.Location = new System.Drawing.Point(49, 41);
            this.lblProdSuppId.Name = "lblProdSuppId";
            this.lblProdSuppId.Size = new System.Drawing.Size(227, 30);
            this.lblProdSuppId.TabIndex = 8;
            this.lblProdSuppId.Text = "Product Supplier Id :";
            // 
            // txtProdSuppId
            // 
            this.txtProdSuppId.BackColor = System.Drawing.SystemColors.Window;
            this.txtProdSuppId.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProdSuppId.Location = new System.Drawing.Point(269, 41);
            this.txtProdSuppId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProdSuppId.Name = "txtProdSuppId";
            this.txtProdSuppId.ReadOnly = true;
            this.txtProdSuppId.Size = new System.Drawing.Size(114, 27);
            this.txtProdSuppId.TabIndex = 9;
            this.txtProdSuppId.Tag = "Product Supplier ID";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(163, 319);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 31);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Confirm Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // ModifyProductSuppliers
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 423);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtProdSuppId);
            this.Controls.Add(this.lblProdSuppId);
            this.Controls.Add(this.txtSupplierId);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ModifyProductSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Product Supplier";
            this.Load += new System.EventHandler(this.ModifyProductSuppliers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnAdd;
        private Button btnCancel;
        private TextBox txtProductId;
        private TextBox txtSupplierId;
        private Label lblProdSuppId;
        private TextBox txtProdSuppId;
        private Button btnEdit;
    }
}