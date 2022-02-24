using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleCode.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult SubmitLogin(string strUserName,string strPassword)
        {
            string strStatus = string.Empty; //01 - Success 00 - failure
            string strMessage = string.Empty;
            string strResult = string.Empty;
            try
            {

            }
            catch (Exception ex)
            {

            }
            return Json(new { Status=strStatus,Message = strMessage,Result=strResult});
        }

        
    }
}