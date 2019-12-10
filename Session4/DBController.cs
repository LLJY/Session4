using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4
{
    class DBController
    {
        static Session4Entities db = new Session4Entities();
        public static async Task<List<InventoryInfo>> getParts()
        {
            List<InventoryInfo> returnlist = new List<InventoryInfo>();
            var query = (from part in db.Parts
                         join orderitem in db.OrderItems on part.ID equals orderitem.PartID
                         join order in db.Orders on orderitem.OrderID equals order.ID
                         join transaction in db.TransactionTypes on order.TransactionTypeID equals transaction.ID
                         join source in db.Warehouses on order.SourceWarehouseID equals source.ID
                         join destination in db.Warehouses on order.DestinationWarehouseID equals destination.ID
                         orderby order.Date ascending
                         select new { part, orderitem, order, transaction, source, destination});
            foreach (var item in query)
            {
                InventoryInfo inventory = new InventoryInfo();
                inventory.PartName = item.part.Name;
                inventory.TransactionType = item.transaction.Name;
                inventory.Date = item.order.Date;
                inventory.Amount = (int)item.orderitem.Amount;
                inventory.Source = item.source.Name;
                inventory.Destination = item.destination.Name;
                returnlist.Add(inventory);
            }
            return returnlist;
        }
        public static async Task<List<string>> getPartsString()
        {
            var query = (from parts in db.Parts
                         select parts.Name).ToList();
            return query;
        }
        public static async Task<List<string>> getSuppliers()
        {
            var query = (from supply in db.Suppliers
                         select supply.Name).ToList();
            return query;
        }
        public static async Task<List<string>> getWarehouse()
        {
            var query = (from w in db.Warehouses
                         select w.Name).ToList();
            return query;
        }
        public static async Task<bool?> checkIfBatch(string partname)
        {
            var query = (from parts in db.Parts
                         where parts.Name == partname
                         select parts.BatchNumberHasRequired).First();
            return query;
        }
    }
}
