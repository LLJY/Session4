using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session4
{
    public partial class InventoryManagement : Form
    {
        List<InventoryInfo> Inventories = new List<InventoryInfo>();
        public InventoryManagement()
        {
            Initialize();
        }
        public async void Initialize()
        {
            Task<List<InventoryInfo>> dbTask = DBController.getParts();
            InitializeComponent();
            Type dgvType = dataGridView1.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
              BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dataGridView1, true, null);
            Inventories = await dbTask;
            dataGridView1.DataSource = Inventories;
        }
        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Purchase_manage_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var PO = new PurchaseOrder();
            PO.Closed += (s, args) => this.Close();
            PO.Show();
        }
    }
    public class InventoryInfo
    {
        public string PartName { get; set; }
        public string TransactionType { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
    }
}
