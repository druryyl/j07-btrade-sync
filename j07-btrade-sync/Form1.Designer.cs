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
            this.IncrementalDownloadOrderButton = new System.Windows.Forms.Button();
            this.LogTextBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // SyncBrgButton
            // 
            this.SyncBrgButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SyncBrgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SyncBrgButton.Location = new System.Drawing.Point(131, 12);
            this.SyncBrgButton.Name = "SyncBrgButton";
            this.SyncBrgButton.Size = new System.Drawing.Size(113, 25);
            this.SyncBrgButton.TabIndex = 0;
            this.SyncBrgButton.Text = "Sync Barang";
            this.SyncBrgButton.UseVisualStyleBackColor = false;
            // 
            // SyncCustomerButton
            // 
            this.SyncCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SyncCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SyncCustomerButton.Location = new System.Drawing.Point(250, 12);
            this.SyncCustomerButton.Name = "SyncCustomerButton";
            this.SyncCustomerButton.Size = new System.Drawing.Size(102, 25);
            this.SyncCustomerButton.TabIndex = 1;
            this.SyncCustomerButton.Text = "Sync Customer";
            this.SyncCustomerButton.UseVisualStyleBackColor = false;
            // 
            // SyncSalesPersonBotton
            // 
            this.SyncSalesPersonBotton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SyncSalesPersonBotton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SyncSalesPersonBotton.Location = new System.Drawing.Point(358, 12);
            this.SyncSalesPersonBotton.Name = "SyncSalesPersonBotton";
            this.SyncSalesPersonBotton.Size = new System.Drawing.Size(116, 25);
            this.SyncSalesPersonBotton.TabIndex = 2;
            this.SyncSalesPersonBotton.Text = "Sync Sales Person";
            this.SyncSalesPersonBotton.UseVisualStyleBackColor = false;
            // 
            // IncrementalDownloadOrderButton
            // 
            this.IncrementalDownloadOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IncrementalDownloadOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncrementalDownloadOrderButton.Location = new System.Drawing.Point(12, 12);
            this.IncrementalDownloadOrderButton.Name = "IncrementalDownloadOrderButton";
            this.IncrementalDownloadOrderButton.Size = new System.Drawing.Size(113, 25);
            this.IncrementalDownloadOrderButton.TabIndex = 3;
            this.IncrementalDownloadOrderButton.Text = "Download Now";
            this.IncrementalDownloadOrderButton.UseVisualStyleBackColor = false;
            // 
            // LogTextBox
            // 
            this.LogTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LogTextBox.Location = new System.Drawing.Point(12, 43);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(462, 294);
            this.LogTextBox.TabIndex = 4;
            this.LogTextBox.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 349);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(486, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(133)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(486, 371);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.IncrementalDownloadOrderButton);
            this.Controls.Add(this.SyncSalesPersonBotton);
            this.Controls.Add(this.SyncCustomerButton);
            this.Controls.Add(this.SyncBrgButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "BTrade Sync";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SyncBrgButton;
        private System.Windows.Forms.Button SyncCustomerButton;
        private System.Windows.Forms.Button SyncSalesPersonBotton;
        private System.Windows.Forms.Button IncrementalDownloadOrderButton;
        private System.Windows.Forms.RichTextBox LogTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

