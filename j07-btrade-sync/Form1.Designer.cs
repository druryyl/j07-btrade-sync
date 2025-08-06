namespace j07_btrade_sync
{
    partial class Form1
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
            this.SyncBrgButton = new System.Windows.Forms.Button();
            this.SyncCustomerButton = new System.Windows.Forms.Button();
            this.SyncSalesPersonBotton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SyncBrgButton
            // 
            this.SyncBrgButton.Location = new System.Drawing.Point(23, 25);
            this.SyncBrgButton.Name = "SyncBrgButton";
            this.SyncBrgButton.Size = new System.Drawing.Size(113, 25);
            this.SyncBrgButton.TabIndex = 0;
            this.SyncBrgButton.Text = "Sync Barang";
            this.SyncBrgButton.UseVisualStyleBackColor = true;
            // 
            // SyncCustomerButton
            // 
            this.SyncCustomerButton.Location = new System.Drawing.Point(23, 56);
            this.SyncCustomerButton.Name = "SyncCustomerButton";
            this.SyncCustomerButton.Size = new System.Drawing.Size(113, 25);
            this.SyncCustomerButton.TabIndex = 1;
            this.SyncCustomerButton.Text = "Sync Customer";
            this.SyncCustomerButton.UseVisualStyleBackColor = true;
            // 
            // SyncSalesPersonBotton
            // 
            this.SyncSalesPersonBotton.Location = new System.Drawing.Point(23, 87);
            this.SyncSalesPersonBotton.Name = "SyncSalesPersonBotton";
            this.SyncSalesPersonBotton.Size = new System.Drawing.Size(113, 25);
            this.SyncSalesPersonBotton.TabIndex = 2;
            this.SyncSalesPersonBotton.Text = "Sync Sales Person";
            this.SyncSalesPersonBotton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 378);
            this.Controls.Add(this.SyncSalesPersonBotton);
            this.Controls.Add(this.SyncCustomerButton);
            this.Controls.Add(this.SyncBrgButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SyncBrgButton;
        private System.Windows.Forms.Button SyncCustomerButton;
        private System.Windows.Forms.Button SyncSalesPersonBotton;
    }
}

