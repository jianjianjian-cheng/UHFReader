using System.Collections.Generic;
using UHFReader.Models;

namespace UHFReader.DAL
{
    public class RfidTagDal : BaseDal
    {
        public int AddTag(RfidTag tag)
        {
            string sql = "INSERT INTO RfidTags (Epc, Tid, MedicineId, Status, BindTime) VALUES (@Epc, @Tid, @MedicineId, @Status, @BindTime)";
            return Execute(sql, tag);
        }

        public int UpdateTag(RfidTag tag)
        {
            string sql = "UPDATE RfidTags SET Epc=@Epc, Tid=@Tid, MedicineId=@MedicineId, Status=@Status, BindTime=@BindTime WHERE Id=@Id";
            return Execute(sql, tag);
        }

        public int UpdateTagStatus(string epc, string status)
        {
            string sql = "UPDATE RfidTags SET Status=@Status WHERE Epc=@Epc";
            return Execute(sql, new { Epc = epc, Status = status });
        }

        public RfidTag GetTagByEpc(string epc)
        {
            string sql = "SELECT * FROM RfidTags WHERE Epc=@Epc";
            return QueryFirstOrDefault<RfidTag>(sql, new { Epc = epc });
        }

        public List<RfidTag> GetAllTags()
        {
            string sql = "SELECT * FROM RfidTags ORDER BY CreateTime DESC";
            return (List<RfidTag>)Query<RfidTag>(sql);
        }

        public List<RfidTag> GetTagsByStatus(string status)
        {
            string sql = "SELECT * FROM RfidTags WHERE Status=@Status ORDER BY CreateTime DESC";
            return (List<RfidTag>)Query<RfidTag>(sql, new { Status = status });
        }
    }
}
