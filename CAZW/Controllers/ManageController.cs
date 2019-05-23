using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CAZW.Controllers
{
    public class ManageController : Controller
    {
        // GET: Manage
        /// <summary>
        /// iframe框架展示用户管理
        /// </summary>
        /// <returns></returns>
        public ActionResult Manage()
        {
            return View();
        }

        // GET: Manage
        /// <summary>
        /// iframe框架展示文章修改页面
        /// </summary>
        /// <returns></returns>
        public ActionResult articleManage()
        {
            return View();
        }

        /// <summary>
        /// iframe框架展示修改密码部分
        /// </summary>
        /// <returns></returns>
        public ActionResult pwdAlter()
        {
            return View();
        }

        /// <summary>
        /// iframe框架展示用户编辑部分
        /// </summary>
        /// <returns></returns>
        public ActionResult userEdit()
        {
            return View();
        }
        /// <summary>
        /// iframe框架展示系统设置部分
        /// </summary>
        /// <returns></returns>
        public ActionResult systemSetting()
        {
            return View();
        }


        
    }
}