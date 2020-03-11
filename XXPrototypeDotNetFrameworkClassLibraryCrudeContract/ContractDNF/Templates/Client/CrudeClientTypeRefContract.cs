/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 8:51:31 PM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeClientTypeRefContract {
        
        [DataMember()]
        public string ClientTypeRcd { get; set; } //;
        
        [DataMember()]
        public string ClientTypeName { get; set; } //;
        
        [DataMember()]
        public string ClientTypeDescription { get; set; } //;
        
        [DataMember()]
        public bool ActiveFlag { get; set; } //;
        
        [DataMember()]
        public int SortOrder { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
}