using System.Collections.Generic;
using UHFReader.Models;
using Dapper;

namespace UHFReader.DAL
{
    public class InventoryDal : BaseDal
    {
        public int AddOrUpdateInventory(int medicineId, int quantityChange)
        {
            string sqlCheck = "SELECT * FROM Inventory WHERE MedicineId=@MedicineId";
            var inventory = QueryFirstOrDefault<Inventory>(sqlCheck, new { MedicineId = medicineId });

            if (inventory != null)
            {
                string sqlUpdate = "UPDATE Inventory SET Quantity=Quantity+@QuantityChange WHERE MedicineId=@MedicineId";
                return Execute(sqlUpdate, new { MedicineId = medicineId, QuantityChange = quantityChange });
            }
            else
            {
                string sqlInsert = "INSERT INTO Inventory (MedicineId, Quantity) VALUES (@MedicineId, @Quantity)";
                return Execute(sqlInsert, new { MedicineId = medicineId, Quantity = quantityChange });
            }
        }

        public int UpdateInventory(int medicineId, int quantity)
        {
            string sql = "UPDATE Inventory SET Quantity=@Quantity WHERE MedicineId=@MedicineId";
            return Execute(sql, new { MedicineId = medicineId, Quantity = quantity });
        }

        public Inventory GetInventoryByMedicineId(int medicineId)
        {
            string sql = "SELECT * FROM Inventory WHERE MedicineId=@MedicineId";
            return QueryFirstOrDefault<Inventory>(sql, new { MedicineId = medicineId });
        }

        public List<dynamic> GetAllInventoryWithMedicine()
        {
            string sql = @"SELECT i.*, m.Code, m.Name, m.Specification, m.Manufacturer 
                          FROM Inventory i 
                          LEFT JOIN Medicines m ON i.MedicineId = m.Id 
                          ORDER BY i.UpdateTime DESC";
            var list = new List<dynamic>();
            using (var conn = GetConnection())
            {
                var result = conn.Query(sql);
                foreach (var item in result)
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
