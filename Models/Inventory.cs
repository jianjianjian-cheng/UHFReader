using System;

namespace UHFReader.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public int MedicineId { get; set; }
        public int Quantity { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
