using System.Collections.Generic;
using UHFReader.Models;

namespace UHFReader.DAL
{
    public class MedicineDal : BaseDal
    {
        public int AddMedicine(Medicine medicine)
        {
            string sql = "INSERT INTO Medicines (Code, Name, Specification, Manufacturer, Description) VALUES (@Code, @Name, @Specification, @Manufacturer, @Description)";
            return Execute(sql, medicine);
        }

        public int UpdateMedicine(Medicine medicine)
        {
            string sql = "UPDATE Medicines SET Code=@Code, Name=@Name, Specification=@Specification, Manufacturer=@Manufacturer, Description=@Description WHERE Id=@Id";
            return Execute(sql, medicine);
        }

        public int DeleteMedicine(int id)
        {
            string sql = "DELETE FROM Medicines WHERE Id=@Id";
            return Execute(sql, new { Id = id });
        }

        public Medicine GetMedicineById(int id)
        {
            string sql = "SELECT * FROM Medicines WHERE Id=@Id";
            return QueryFirstOrDefault<Medicine>(sql, new { Id = id });
        }

        public List<Medicine> GetAllMedicines()
        {
            string sql = "SELECT * FROM Medicines ORDER BY CreateTime DESC";
            return (List<Medicine>)Query<Medicine>(sql);
        }

        public List<Medicine> SearchMedicines(string keyword)
        {
            string sql = "SELECT * FROM Medicines WHERE Name LIKE @Keyword OR Code LIKE @Keyword ORDER BY CreateTime DESC";
            return (List<Medicine>)Query<Medicine>(sql, new { Keyword = "%" + keyword + "%" });
        }

        public bool ExistsByCode(string code)
        {
            string sql = "SELECT COUNT(1) FROM Medicines WHERE Code = @Code";
            var result = QueryFirstOrDefault<int?>(sql, new { Code = code });
            return result.HasValue && result.Value > 0;
        }
    }
}
