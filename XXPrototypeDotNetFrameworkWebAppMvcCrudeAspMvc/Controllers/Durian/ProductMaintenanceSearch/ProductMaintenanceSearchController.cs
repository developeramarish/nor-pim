﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 9:54:10 PM
  Template: sql2x.GenerateDurian.DurianController
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc {
    public class ProductMaintenanceSearchController : Controller {

        [HttpGet]
        public ActionResult ProductMaintenanceSearchIndex() {

            return View(
                "~/Views/Durian/ProductMaintenanceSearch/ProductMaintenanceSearch.cshtml"
                );
        }

    }
}