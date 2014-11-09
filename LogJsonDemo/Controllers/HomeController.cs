using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LogJsonDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "项目示例";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "log类库:debug.writline 和 trance writline 在输出面板写日志 和根据配置输出到文本文件里.实例转json";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "联系.";

            return View();
        }
    }
}
