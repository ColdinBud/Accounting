using Accounting.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Accounting.Models
{
    public class AssetModel
    {
        public CategoryType Category { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public string Remark { get; set; }
    }
}