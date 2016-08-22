using Accounting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Accounting.ViewModels
{
    public class AssetViewModel
    {
        public List<AssetModel> assetModelList = new List<AssetModel>();
        
        //public CategoryType Category { get; set; }
        //public DateTime Date { get; set; }
        //public decimal Price { get; set; }
        //public string Remark { get; set; }
    }
}