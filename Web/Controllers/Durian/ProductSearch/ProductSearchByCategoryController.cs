﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 4:20:49 PM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class ProductSearchByCategoryController : Controller {

        [HttpGet]
        public ActionResult ProductSearchByCategoryIndex(System.Guid productCategoryId,System.Boolean onParent) {

            return View(
                "~/Views/Durian/ProductSearch/ProductSearchByCategoryIndex.cshtml",
                new ProductSearchService().ProductSearchByCategory(productCategoryId,onParent)
                );
        }

    }
}
