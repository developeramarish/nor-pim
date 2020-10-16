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
    public partial class CrudeDefaultErrorContract {
        
        [DataMember()]
        public System.Guid DefaultErrorId { get; set; }
        
        [DataMember()]
        public string DefaultErrorLayerRcd { get; set; }
        
        [DataMember()]
        public string DefaultErrorTypeRcd { get; set; }
        
        [DataMember()]
        public string LayerAddress { get; set; }
        
        [DataMember()]
        public string ErrorMessage { get; set; }
        
        [DataMember()]
        public string StackTrace { get; set; }
        
        [DataMember()]
        public string MethodName { get; set; }
        
        [DataMember()]
        public string DomainName { get; set; }
        
        [DataMember()]
        public string ClassName { get; set; }
        
        [DataMember()]
        public System.Guid DefaultUserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
