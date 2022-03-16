using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TetWebApplication.Data;
using TetWebApplication.Models;

namespace TetWebApplication.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Test()
        {
            return View();
        }

        public ActionResult RequestPage()
        {
            OrderDataAccessObject dataObject = new OrderDataAccessObject();

            var data = dataObject.GetOrders();

            List<RequestDto> requests = new List<RequestDto>();
            foreach (DataRow row in data.Rows)
            {
                requests.Add(new RequestDto()
                {
                    RequestId = Convert.ToInt32(row.ItemArray[0].ToString()),
                    RequestType = row.ItemArray[1].ToString(),
                    RequestStatus = row.ItemArray[2].ToString(),
                    CreateDate = Convert.ToDateTime(row.ItemArray[3].ToString())
                });
            }
            return View(requests);
        }
    }
}