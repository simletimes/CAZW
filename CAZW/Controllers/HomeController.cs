using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CAZW.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 登录页面（get获取返回登录视图）
        /// </summary>
        /// <returns></returns>
        public ActionResult login()
        {
            return View();
        }

        /// <summary>
        /// 新闻列表页面（get获取返回新闻页面视图）
        /// </summary>
        /// <returns></returns>
        public ActionResult news()
        {
            return View();
        }

        /// <summary>
        /// 搜索查询页面（get获取返回搜索页面视图）
        /// </summary>
        /// <returns></returns>
        public ActionResult search()
        {
            return View();
        }

        /// <summary>
        /// 服务中心页面（get获取返回服务页面视图）
        /// </summary>
        /// <returns></returns>
        public ActionResult service()
        {
            return View();
        }
        
    }
}