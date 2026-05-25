using System.Collections.Generic;
using UHFReader.DAL;
using UHFReader.Models;

namespace UHFReader.BLL
{
    public class InventoryBll
    {
        private InventoryDal _inventoryDal = new InventoryDal();

        public bool AddInventory(int medicineId, int quantity)
        {
            return _inventoryDal.AddOrUpdateInventory(medicineId, quantity) > 0;
        }

        public bool ReduceInventory(int medicineId, int quantity)
        {
            var inventory = _inventoryDal.GetInventoryByMedicineId(medicineId);
            if (inventory != null && inventory.Quantity >= quantity)
            {
                return _inventoryDal.AddOrUpdateInventory(medicineId, -quantity) > 0;
            }
            return false;
        }

        public Inventory GetInventoryByMedicineId(int medicineId)
        {
            return _inventoryDal.GetInventoryByMedicineId(medicineId);
        }

        public List<dynamic> GetAllInventoryWithMedicine()
        {
            return _inventoryDal.GetAllInventoryWithMedicine();
        }
    }
}
