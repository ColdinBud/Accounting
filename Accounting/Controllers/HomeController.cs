using Accounting.Enum;
using Accounting.Models;
using Accounting.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Accounting.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AssetViewModel viewModel = new AssetViewModel();
            viewModel.assetModelList = FakeAssetList();

            return View(viewModel);
        }

        private List<AssetModel> FakeAssetList()
        {
            List<AssetModel> modelList = new List<AssetModel>();
            modelList.Add(new AssetModel { Category = CategoryType.expense, Price = 300, Date = new DateTime(2016, 1, 1), Remark = "" });
            modelList.Add(new AssetModel { Category = CategoryType.expense, Price = 1600, Date = new DateTime(2016, 1, 2), Remark = "" });
            modelList.Add(new AssetModel { Category = CategoryType.expense, Price = 800, Date = new DateTime(2016, 1, 3), Remark = "" });
            return modelList;
        }



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
    }
}