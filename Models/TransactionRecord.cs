using System;

namespace UHFReader.Models
{
    public class TransactionRecord
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int MedicineId { get; set; }
        public int? TagId { get; set; }
        public string Epc { get; set; }
        public int Quantity { get; set; }
        public int OperatorId { get; set; }
        public string OperatorName { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
