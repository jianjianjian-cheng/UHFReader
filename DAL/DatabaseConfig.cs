using System.Configuration;

namespace UHFReader.DAL
{
    public class DatabaseConfig
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["DefaultConnection"]?.ConnectionString 
            ?? "Server=localhost;Database=RfidMedicineDb;Uid=root;Pwd=123456;Charset=utf8;";
    }
}
