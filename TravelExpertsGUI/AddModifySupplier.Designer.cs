namespace TravelExpertsGUI
{
    partial class AddModifySupplier
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
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSupplierId = new System.Windows.Forms.Label();
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSupplier.Location = new System.Drawing.Point(94, 143);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(104, 31);
            this.lblSupplier.TabIndex = 0;
            this.lblSupplier.Text = "Supplier:";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSupplier.Location = new System.Drawing.Point(226, 143);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(294, 34);
            this.txtSupplier.TabIndex = 1;
            this.txtSupplier.Tag = "Supplier";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(127, 236);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(136, 48);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(321, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 48);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSupplierId
            // 
            this.lblSupplierId.AutoSize = true;
            this.lblSupplierId.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSupplierId.Location = new System.Drawing.Point(66, 66);
            this.lblSupplierId.Name = "lblSupplierId";
            this.lblSupplierId.Size = new System.Drawing.Size(132, 31);
            this.lblSupplierId.TabIndex = 4;
            this.lblSupplierId.Text = "Supplier ID:";
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSupplierId.Location = new System.Drawing.Point(226, 65);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.ReadOnly = true;
            this.txtSupplierId.Size = new System.Drawing.Size(125, 34);
            this.txtSupplierId.TabIndex = 5;
            // 
            // AddModifySupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 327);
            this.Controls.Add(this.txtSupplierId);
            this.Controls.Add(this.lblSupplierId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.lblSupplier);
            this.Name = "AddModifySupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddModifySupplier";
            this.Load += new System.EventHandler(this.AddModifySupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSupplier;
        private TextBox txtSupplier;
        private Button btnSubmit;
        private Button btnCancel;
        private Label lblSupplierId;
        private TextBox txtSupplierId;
    }
}