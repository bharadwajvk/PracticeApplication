using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Entity;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class UserController : Controller
    {
        UserModel user = new UserModel();
        public ActionResult UserView()
        {
            return View(UserModel.userList);
        }
        [HttpPost]
        public ActionResult UserRegistration(User user1)
        {
            if (ModelState.IsValid)
            {
                var model =  user.AddList(user1);
                return View("UserView", model);
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult UserRegistration()
        {
            return View("");
        }
        public ActionResult UserDelete(int id)
        {
            user.DeleteList(id);
            var model = new UserModel().UserList();
            return View("UserView", model);
        }
        [HttpGet]
        public ActionResult UserEdit(int id=0)
        {
            User model = UserModel.userList.Where(x => x.Id == id).FirstOrDefault();
            return View("UserEdit", model);
        }

        [HttpPost]
        public ActionResult UserEdit(User user1)
        {
            user.EditUser(user1);
            return View("UserView", UserModel.userList);
        }

        #region User AJAX Methods
        [HttpGet]
        public ActionResult UserViewAjax()
        {
            return View(UserModel.userList);
        }
       
        [HttpGet]
        public ActionResult UserRegistrationAjax()
        {
            return View("UserRegistrationAjax");
        }
        #endregion

    }
}