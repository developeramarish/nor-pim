﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 12:31:51 PM
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CategoryFindController : Controller {

        [HttpGet]
        public ActionResult CategoryFindIndex(System.String findWhat) {

            return View(
                "~/Views/Durian/CategorySearch/CategoryFindIndex.cshtml",
                new CategorySearchService().CategoryFind(findWhat)
                );
        }

    }
}
