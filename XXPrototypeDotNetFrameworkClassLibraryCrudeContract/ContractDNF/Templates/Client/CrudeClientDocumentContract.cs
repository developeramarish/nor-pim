/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 8:51:28 PM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeClientDocumentContract {
        
        [DataMember()]
        public System.Guid ClientDocumentId { get; set; } //;
        
        [DataMember()]
        public System.Guid ClientId { get; set; } //;
        
        [DataMember()]
        public string ClientDocumentTypeRcd { get; set; } //;
        
        [DataMember()]
        public string DocumentName { get; set; } //;
        
        [DataMember()]
        public System.DateTime DocumentDateTime { get; set; } //;
        
        [DataMember()]
        public System.DateTime ExpiryDateTime { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
}