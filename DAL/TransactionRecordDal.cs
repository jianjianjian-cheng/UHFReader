using System.Collections.Generic;
using UHFReader.Models;
using Dapper;

namespace UHFReader.DAL
{
  public class TransactionRecordDal : BaseDal
  {
    public int AddTransaction(TransactionRecord record)
    {
      string sql = @"INSERT INTO TransactionRecords (Type, MedicineId, TagId, Epc, Quantity, OperatorId, OperatorName) 
                          VALUES (@Type, @MedicineId, @TagId, @Epc, @Quantity, @OperatorId, @OperatorName)";
      return Execute(sql, record);
    }


    public List<dynamic> GetAllTransactions()
    {
      string sql = @"SELECT t.*, m.Name as MedicineName 
                          FROM TransactionRecords t 
                          LEFT JOIN Medicines m ON t.MedicineId = m.Id 
                          ORDER BY t.CreateTime DESC";
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

    public List<dynamic> GetTransactionsByType(string type)
    {
      string sql = @"SELECT t.*, m.Name as MedicineName 
                          FROM TransactionRecords t 
                          LEFT JOIN Medicines m ON t.MedicineId = m.Id 
                          WHERE t.Type = @Type 
                          ORDER BY t.CreateTime DESC";
      var list = new List<dynamic>();
      using (var conn = GetConnection())
      {
        var result = conn.Query(sql, new { Type = type });
        foreach (var item in result)
        {
          list.Add(item);
        }
      }
      return list;
    }
  }
}
