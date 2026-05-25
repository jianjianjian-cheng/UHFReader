using System;

namespace UHFReader.Models
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Specification { get; set; }
        public string Manufacturer { get; set; }
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
