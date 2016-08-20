using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDbModel.Services
{
    public class UserService
    {

        UsersDbEntities db = null;
        public UserService() {
            
            db = new UsersDbEntities();
        }
        public bool Login(string userName, string password)
        {
            return true;
        }

        public User GetUser(int id)
        {
            return db.Users.FirstOrDefault(u => u.Id == id);
        }

        public List<User> GetUsers()
        {
            return db.Users.ToList();
        }
    }
}
