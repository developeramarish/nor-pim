﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 9:34:39 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeProductCategoryDocumentationTypeRefModel {
        
        [Display(Name="Product Category Documentation Type")]
        [Required()]
        public string ProductCategoryDocumentationTypeRcd { get; set; } //;
        
        [Display(Name="Product Category Documentation Type Name")]
        [Required()]
        public string ProductCategoryDocumentationTypeName { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}