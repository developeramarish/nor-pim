﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 9:29:23 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeFinancialOrderLineModel {
        
        [Display(Name="Financial Order Line Id")]
        [Required()]
        public System.Guid FinancialOrderLineId { get; set; } //;
        
        [Display(Name="Financial Order Id")]
        [Required()]
        public System.Guid FinancialOrderId { get; set; } //;
        
        [Display(Name="Product Id")]
        [Required()]
        public System.Guid ProductId { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
        
        [Display(Name="Comment")]
        [Required()]
        public string Comment { get; set; } //;
        
        [Display(Name="Line Number")]
        [Required()]
        public int LineNumber { get; set; } //;
        
        [Display(Name="Financial Unit Of Measurement")]
        [Required()]
        public string FinancialUnitOfMeasurementRcd { get; set; } //;
        
        [Display(Name="Quantity Number")]
        [Required()]
        public int QuantityNumber { get; set; } //;
        
        [Display(Name="Financial Currency Id")]
        [Required()]
        public System.Guid FinancialCurrencyId { get; set; } //;
        
        [Display(Name="Amount")]
        [Required()]
        public decimal Amount { get; set; } //;
    }
}