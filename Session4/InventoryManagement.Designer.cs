namespace Session4
{
    partial class InventoryManagement
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.purchase_manage_button = new System.Windows.Forms.Button();
            this.warehouse_manage_button = new System.Windows.Forms.Button();
            this.inventory_report_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 422);
            this.dataGridView1.TabIndex = 0;
            // 
            // purchase_manage_button
            // 
            this.purchase_manage_button.Location = new System.Drawing.Point(-1, 0);
            this.purchase_manage_button.Name = "purchase_manage_button";
            this.purchase_manage_button.Size = new System.Drawing.Size(200, 30);
            this.purchase_manage_button.TabIndex = 1;
            this.purchase_manage_button.Text = "Purchase Order Management";
            this.purchase_manage_button.UseVisualStyleBackColor = true;
            this.purchase_manage_button.Click += new System.EventHandler(this.Purchase_manage_button_Click);
            // 
            // warehouse_manage_button
            // 
            this.warehouse_manage_button.Location = new System.Drawing.Point(205, 0);
            this.warehouse_manage_button.Name = "warehouse_manage_button";
            this.warehouse_manage_button.Size = new System.Drawing.Size(200, 30);
            this.warehouse_manage_button.TabIndex = 2;
            this.warehouse_manage_button.Text = "Warehouse Management";
            this.warehouse_manage_button.UseVisualStyleBackColor = true;
            this.warehouse_manage_button.Click += new System.EventHandler(this.Button2_Click);
            // 
            // inventory_report_button
            // 
            this.inventory_report_button.Location = new System.Drawing.Point(411, 0);
            this.inventory_report_button.Name = "inventory_report_button";
            this.inventory_report_button.Size = new System.Drawing.Size(200, 30);
            this.inventory_report_button.TabIndex = 3;
            this.inventory_report_button.Text = "Inventory Report";
            this.inventory_report_button.UseVisualStyleBackColor = true;
            // 
            // InventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inventory_report_button);
            this.Controls.Add(this.warehouse_manage_button);
            this.Controls.Add(this.purchase_manage_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InventoryManagement";
            this.Text = "Inventory Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button purchase_manage_button;
        private System.Windows.Forms.Button warehouse_manage_button;
        private System.Windows.Forms.Button inventory_report_button;
    }
}

