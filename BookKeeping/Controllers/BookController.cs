using BookKeeping.Models.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookKeeping.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            Random r = new Random();
            List<KeepingDetailModel> lstDetail = new List<KeepingDetailModel>();
            for (int i = 1; i <= 100; i++) {
                KeepingDetailModel detail = new KeepingDetailModel();
                detail.ID = i;
                detail.CategoryID = r.Next(1, 3);
                if (detail.CategoryID == 1)
                    detail.CategoryDesc = "支出";
                else
                    detail.CategoryDesc = "收入";
                detail.Amount = r.Next(1, 10000);
                detail.RecordDt = DateTime.Now.AddDays(0 - r.Next(1,300));
                lstDetail.Add(detail);
            }
            var model = new KeepingDetailListViewModel
            {
                KeepingDetails = lstDetail,
                Categories = new SelectList(this.Categories(), "Value", "Text"),
            };
            return View(model);
        }
        private List<SelectListItem> Categories()
        {
            List<SelectListItem> lstObjs = new List<SelectListItem>();
           
            lstObjs.Add(new SelectListItem()
            {
                Value = "",
                Text = "請選擇"
            });

            lstObjs.Add(new SelectListItem()
            {
                Value = "1",
                Text = "支出"
            });

            lstObjs.Add(new SelectListItem()
            {
                Value = "2",
                Text = "收入"
            });
            
            return lstObjs;
        }
    }
}