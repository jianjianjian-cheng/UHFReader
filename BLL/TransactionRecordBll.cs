using System;
using System.Collections.Generic;
using UHFReader.DAL;
using UHFReader.Models;

namespace UHFReader.BLL
{
  public class TransactionRecordBll
  {
    private TransactionRecordDal _transactionDal = new TransactionRecordDal();
    private InventoryBll _inventoryBll = new InventoryBll();
    private RfidTagBll _tagBll = new RfidTagBll();

    public bool StockIn(string epc, int medicineId, int operatorId, string operatorName)
    {
      var tag = _tagBll.GetTagByEpc(epc);
      if (tag == null || tag.MedicineId != medicineId)
      {
        return false;
      }

      if (tag.Status == "InStock")
      {
        return false;
      }

      _inventoryBll.AddInventory(medicineId, 1);
      _tagBll.UpdateTagStatus(epc, "InStock");

      var record = new TransactionRecord
      {
        Type = "In",
        MedicineId = medicineId,
        TagId = tag.Id,
        Epc = epc,
        Quantity = 1,
        OperatorId = operatorId,
        OperatorName = operatorName
      };
      return _transactionDal.AddTransaction(record) > 0;
    }

    public bool StockOut(string epc, int medicineId, int operatorId, string operatorName)
    {
      var tag = _tagBll.GetTagByEpc(epc);
      if (tag == null || tag.MedicineId != medicineId)
      {
        return false;
      }

      if (tag.Status != "InStock")
      {
        return false;
      }

      _inventoryBll.ReduceInventory(medicineId, 1);
      _tagBll.UpdateTagStatus(epc, "OutStock");

      var record = new TransactionRecord
      {
        Type = "Out",
        MedicineId = medicineId,
        TagId = tag.Id,
        Epc = epc,
        Quantity = 1,
        OperatorId = operatorId,
        OperatorName = operatorName
      };
      return _transactionDal.AddTransaction(record) > 0;
    }

    public List<dynamic> GetAllTransactions()
    {
      return _transactionDal.GetAllTransactions();
    }

    public List<dynamic> GetTransactionsByType(string type)
    {
      return _transactionDal.GetTransactionsByType(type);
    }
  }
}
