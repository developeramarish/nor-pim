﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 10:14:44 PM
  Template: sql2x.TemplateByServiceTableCrudGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public partial class ProductReferenceAttributeController : Controller {

        [HttpGet]
        public ActionResult ProductReferenceAttributeIndex() {

            return RedirectToAction(
                    "ProductReferenceAttributeEdit",
                    new {    productAttributeRcd = String.Empty    }
                    );
        }

        [HttpGet]
        public ActionResult ProductReferenceAttributeEdit(
            ) {

            ProductReferenceAttributeContract productContract =
                new ProductReferenceAttributeServiceClient().
                        ProductReferenceAttributeCompleteGet(
                            String.Empty,
                            new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}")
                            );


            return View(
                "~/Views/Templates/ProductReference/ProductReferenceAttribute/ProductReferenceAttributeEdit.cshtml",
                productContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductReferenceAttributeEdit(
            [Bind()] ProductReferenceAttributeContract productContract
            ) {
            new ProductReferenceAttributeServiceClient().
                    ProductReferenceAttributeCompleteUpdate(
                        String.Empty,
                        productContract,
                        new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}")
                        );

            return RedirectToAction(
                    "ProductReferenceAttributeEdit",
                    new {    productAttributeRcd = String.Empty}
                    );
        }

        [HttpGet]
        public ActionResult ProductReferenceAttributeCreate(System.Guid? userId) {
            var productContract = new ProductReferenceAttributeContract();
            productContract.ProductAttributeRefNew = new CrudeProductAttributeRefContract();
            if (userId != null) productContract.ProductAttributeRefNew.UserId = (System.Guid) userId;

            if (userId == null)
                productContract.ProductAttributeRefNew.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            productContract.ProductAttributeRefNew.DateTime = DateTime.UtcNow;

            return View(
                "~/Views/Templates/ProductReference/ProductReferenceAttribute/ProductReferenceAttributeCreate.cshtml",
                productContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductReferenceAttributeCreate([Bind()] ProductReferenceAttributeContract productContract) {
            if (ModelState.IsValid) {

                new CrudeProductAttributeRefServiceClient().Insert(productContract.ProductAttributeRefNew);

                return RedirectToAction(
                        "ProductReferenceAttributeEdit",
                        new {    productAttributeRcd = String.Empty}
                        );
            }

            return View(
                "~/Views/Templates/ProductReference/ProductReferenceAttribute/ProductReferenceAttributeCreate.cshtml",
                productContract
                );
        }

    }
}