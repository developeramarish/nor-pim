﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 9:52:46 PM
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class ProductMaintenanceInfoIndexWithFilterController : Controller {

        [HttpGet]
        public ActionResult ProductMaintenanceInfoIndexWithFilterIndex(System.Guid productId) {

            return View(
                "~/Views/Durian/ProductMaintenanceSearch/ProductMaintenanceInfoIndexWithFilterIndex.cshtml",
                new ProductMaintenanceSearchService().ProductMaintenanceInfoIndexWithFilter(productId)
                );
        }

    }
}