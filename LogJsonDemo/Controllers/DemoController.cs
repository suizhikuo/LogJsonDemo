using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace LogJsonDemo.Controllers
{
    public class DemoController : Controller
    {
        //
        // GET: /Demo/

        public ActionResult DebugTrance()
        {
            System.Diagnostics.Debug.WriteLine("Debug在output面板输出");
            System.Diagnostics.Trace.WriteLine("Trace在output面板输出");

            System.Diagnostics.Debug.Assert(false, "断言报错.");

            return View();
        }


        public ActionResult ClassJson()
        {
            var myclass = new Models.ClassToJson()
            {
                id = 1,
                Name = "nameas",
                Address = "adizhidafdf",
                Phone = "asdfasdf",
            };

            JavaScriptSerializer jss = new JavaScriptSerializer();
            var jsonstr = jss.Serialize(myclass);
            System.Diagnostics.Debug.WriteLine(jsonstr);

            string LogText = string.Format("我的文本日志");
            StreamWriter logWriter = System.IO.File.AppendText(Server.MapPath("~/") + "app.log");
            logWriter.WriteLine(LogText);
            logWriter.Close();

            return View();
        }
    }
}
