﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 2:54:35 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public partial class CrudeFinancialOrderContract {
        
        [DataMember()]
        public System.Guid FinancialOrderId { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
        
        [DataMember()]
        public string Comment { get; set; }
        
        [DataMember()]
        public System.Guid LocationAddressId { get; set; }
        
        [DataMember()]
        public System.Guid FinancialCurrencyId { get; set; }
        
        [DataMember()]
        public string FinancialOrderSourceRcd { get; set; }
        
        [DataMember()]
        public System.Guid ClientId { get; set; }
    }
}
