using UHFReader.DAL;
using UHFReader.Models;

namespace UHFReader.BLL
{
    public class UserBll
    {
        private UserDal _userDal = new UserDal();

        public User Login(string username, string password)
        {
            var user = _userDal.GetUserByUsername(username);
            if (user != null && user.Password == password)
            {
                return user;
            }
            return null;
        }
    }
}
