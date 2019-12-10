namespace Session4
{
    partial class PurchaseOrder
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
            this.supply_box = new System.Windows.Forms.ComboBox();
            this.warehouse_box = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.add_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.amount_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.batch_box = new System.Windows.Forms.TextBox();
            this.part_combo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Warehouse:";
            // 
            // supply_box
            // 
            this.supply_box.FormattingEnabled = true;
            this.supply_box.Location = new System.Drawing.Point(12, 58);
            this.supply_box.Name = "supply_box";
            this.supply_box.Size = new System.Drawing.Size(211, 21);
            this.supply_box.TabIndex = 2;
            // 
            // warehouse_box
            // 
            this.warehouse_box.FormattingEnabled = true;
            this.warehouse_box.Location = new System.Drawing.Point(385, 58);
            this.warehouse_box.Name = "warehouse_box";
            this.warehouse_box.Size = new System.Drawing.Size(211, 21);
            this.warehouse_box.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date:";
            // 
            // date_picker
            // 
            this.date_picker.Location = new System.Drawing.Point(53, 111);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(200, 20);
            this.date_picker.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add_button);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.amount_box);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.batch_box);
            this.groupBox1.Controls.Add(this.part_combo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 263);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parts List";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(695, 32);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 11;
            this.add_button.Text = "+ Add to List";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Amount:";
            // 
            // amount_box
            // 
            this.amount_box.Location = new System.Drawing.Point(485, 29);
            this.amount_box.Name = "amount_box";
            this.amount_box.Size = new System.Drawing.Size(100, 20);
            this.amount_box.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Batch Number:";
            // 
            // batch_box
            // 
            this.batch_box.Location = new System.Drawing.Point(310, 29);
            this.batch_box.Name = "batch_box";
            this.batch_box.Size = new System.Drawing.Size(100, 20);
            this.batch_box.TabIndex = 3;
            // 
            // part_combo
            // 
            this.part_combo.FormattingEnabled = true;
            this.part_combo.Location = new System.Drawing.Point(72, 30);
            this.part_combo.Name = "part_combo";
            this.part_combo.Size = new System.Drawing.Size(121, 21);
            this.part_combo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Part Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 196);
            this.dataGridView1.TabIndex = 0;
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.date_picker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.warehouse_box);
            this.Controls.Add(this.supply_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PurchaseOrder";
            this.Text = "Purchase Order";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox supply_box;
        private System.Windows.Forms.ComboBox warehouse_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_picker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox amount_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox batch_box;
        private System.Windows.Forms.ComboBox part_combo;
        private System.Windows.Forms.Label label4;
    }
}