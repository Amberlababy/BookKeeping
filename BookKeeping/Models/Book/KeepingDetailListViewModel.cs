using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookKeeping.Models.Book
{
    public class KeepingDetailListViewModel
    {
        public List<KeepingDetailModel> KeepingDetails { get; set; }
        public SelectList Categories { get; set; }
    }
}