namespace TravelExpertsGUI
{
    partial class AddProduct
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
            this.btnadd = new System.Windows.Forms.Button();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(90, 133);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(94, 29);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(204, 69);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(125, 27);
            this.txtProdName.TabIndex = 2;
            this.txtProdName.Tag = "product name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Name";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(235, 133);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(94, 29);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product ID:";
            // 
            // txtProdID
            // 
            this.txtProdID.Location = new System.Drawing.Point(204, 26);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.ReadOnly = true;
            this.txtProdID.Size = new System.Drawing.Size(125, 27);
            this.txtProdID.TabIndex = 7;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 224);
            this.Controls.Add(this.txtProdID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.btnadd);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnadd;
        private TextBox txtProdName;
        private Label label2;
        private Button btncancel;
        private Label label1;
        private TextBox txtProdID;
    }
}