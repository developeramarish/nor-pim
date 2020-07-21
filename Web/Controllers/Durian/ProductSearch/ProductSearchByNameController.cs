﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:55:50 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class ProductSearchByNameController : Controller {

        [HttpGet]
        public ActionResult ProductSearchByNameIndex(System.String productName) {

            return View(
                "~/Views/Durian/ProductSearch/ProductSearchByNameIndex.cshtml",
                new ProductSearchService().ProductSearchByName(productName)
                );
        }

    }
}
