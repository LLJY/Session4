using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session4
{
    public partial class PurchaseOrder : Form
    {
        List<PartsAdded> ListofParts = new List<PartsAdded>();
        public PurchaseOrder()
        {
            Initialize();
        }
        public async void Initialize()
        {
            Task<List<string>> dbtask1 = DBController.getPartsString();
            Task<List<string>> dbtask2 = DBController.getSuppliers();
            Task<List<string>> dbtask3 = DBController.getWarehouse();
            InitializeComponent();
            dataGridView1.DataSource = ListofParts;
            part_combo.DataSource = await dbtask1;
            supply_box.DataSource = await dbtask2;
            warehouse_box.DataSource = await dbtask3;
        }

        private async void Add_button_Click(object sender, EventArgs e)
        {
            PartsAdded parts = new PartsAdded();
            //igiveup
            parts.PartName = part_combo.SelectedItem.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
            bool? needbatch = await DBController.checkIfBatch(parts.PartName);
            if (needbatch == true)
            {
                parts.BatchNumber = batch_box.Text;
            }
            parts.Amount = amount_box.Text;
            ListofParts.Add(parts);
            dataGridView1.DataSource = ListofParts;
            dataGridView1.Refresh();
        }
    }
    public class PartsAdded
    {
        public string PartName { get; set; }
        public string BatchNumber { get; set; }
        public string Amount { get; set; }
    }
}
