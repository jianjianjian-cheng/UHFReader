using System;

namespace UHFReader.Models
{
    public class RfidTag
    {
        public int Id { get; set; }
        public string Epc { get; set; }
        public string Tid { get; set; }
        public int? MedicineId { get; set; }
        public string Status { get; set; }
        public DateTime? BindTime { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
