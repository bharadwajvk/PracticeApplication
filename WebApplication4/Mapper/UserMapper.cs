using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Entity;
using WebApplication4.Models;

namespace WebApplication4.Mapper
{
    public class UserMapper
    {
        public List<User> MapUserDetailsToUsers(List<UserDetail> userDetails)
        {
            List<User> userList = new List<User>();
            foreach (var item in userDetails)
            {
                User u = new User();
                u.Id = item.Id;
                u.FirstName = item.FirstName;
                u.LastName = item.LastName;
                u.Email = item.Email;
                u.PhoneNumber = item.PhoneNumber;
                u.country = (CountryEnum)Enum.Parse(typeof(CountryEnum), item.Country);
                userList.Add(u);
            }
            return userList;
        }
        public User MapUserDetailToUser(UserDetail userDetails)
        {
            User u = new User();
            u.Id = userDetails.Id;
            u.FirstName = userDetails.FirstName;
            u.LastName = userDetails.LastName;
            u.Email = userDetails.Email;
            u.PhoneNumber = userDetails.PhoneNumber;
            u.country = (CountryEnum)Enum.Parse(typeof(CountryEnum), userDetails.Country);
            return u;
        }
        public UserDetail MapUserToUserDetail(User user)
        {
            UserDetail u = new UserDetail();
            u.Id = user.Id;
            u.FirstName = user.FirstName;
            u.LastName = user.LastName;
            u.Email = user.Email;
            u.PhoneNumber = user.PhoneNumber;
            u.Country = user.country.ToString();
            return u;
        }
    }

}