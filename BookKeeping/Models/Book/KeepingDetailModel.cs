using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookKeeping.Models.Book
{
    public class KeepingDetailModel
    {
        public int ID { get; set; }
        [Display(Name = "類別ID")]
        public int CategoryID { get; set; }
        [Display(Name = "類別")]
        public string CategoryDesc { get; set; }
        [Display(Name = "金額")]
        public decimal Amount { get; set; }
        [Display(Name = "日期")]
        public DateTime RecordDt { get; set; }
        [Display(Name = "備註")]
        public string Comment { get; set; }
    }
}