﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/31/2020 5:16:59 AM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public partial class CrudeClientDocumentTypeRefContract {
        
        [DataMember()]
        public string ClientDocumentTypeRcd { get; set; }
        
        [DataMember()]
        public string ClientDocumentTypeName { get; set; }
        
        [DataMember()]
        public string ClientDocumentTypeDescription { get; set; }
        
        [DataMember()]
        public bool ActiveFlag { get; set; }
        
        [DataMember()]
        public int SortOrder { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
