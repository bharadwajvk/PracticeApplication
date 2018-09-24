using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication4.Entity;
using WebApplication4.Mapper;

namespace WebApplication4.Models
{
    public class UserModel : DbContext
    {
        MVCPracticeEntities db = new MVCPracticeEntities();
        public static List<User> userList = new List<User>();
        public UserModel()
        {
            userList =UserList();
        }
        public List<User> UserList()
        {
            return new UserMapper().MapUserDetailsToUsers(db.UserDetails.ToList());
        }
        public List<User> AddList(User user)
        {
           var userdetail = new UserMapper().MapUserToUserDetail(user);
           db.sp_AddUserDetail(userdetail.FirstName, userdetail.LastName, userdetail.Email, userdetail.PhoneNumber, userdetail.Address1, userdetail.Country);
           return UserList();
        }
        public List<User> DeleteList(int id)
        {
            db.sp_DeleteUserDetail(id);
            return UserList();
        }
        public List<User> EditUser(User newuser)
        {
            var userdetail = new UserMapper().MapUserToUserDetail(newuser);
            db.sp_EditUserDetail(userdetail.Id,userdetail.FirstName, userdetail.LastName, userdetail.Email, userdetail.PhoneNumber, userdetail.Address1, userdetail.Country);
            return UserList();
        }
    }
}