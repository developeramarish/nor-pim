﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 10:08:39 PM
  Template: sql2x.GenerateDurian.DurianController
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc {
    public class ProductReferenceAttributeUnitSearchController : Controller {

        [HttpGet]
        public ActionResult ProductReferenceAttributeUnitSearchIndex() {

            return View(
                "~/Views/Durian/ProductReferenceAttributeUnitSearch/ProductReferenceAttributeUnitSearch.cshtml"
                );
        }

    }
}