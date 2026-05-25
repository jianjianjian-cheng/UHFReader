using UHFReader.Models;

namespace UHFReader.DAL
{
    public class UserDal : BaseDal
    {
        public User GetUserByUsername(string username)
        {
            string sql = "SELECT * FROM Users WHERE Username = @Username";
            return QueryFirstOrDefault<User>(sql, new { Username = username });
        }

        public int AddUser(User user)
        {
            string sql = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)";
            return Execute(sql, user);
        }
    }
}
