﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 9:55:18 PM
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class DashboardCountsController : Controller {

        [HttpGet]
        public ActionResult DashboardCountsIndex(System.String dashboardLayoutRcd) {

            return View(
                "~/Views/Durian/DefaultSearch/DashboardCountsIndex.cshtml",
                new DefaultSearchService().DashboardCounts(dashboardLayoutRcd)
                );
        }

    }
}