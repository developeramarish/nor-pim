/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 8:52:02 PM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeProductGatherSourceContract {
        
        [DataMember()]
        public System.Guid ProductGatherSourceId { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductGatherId { get; set; } //;
        
        [DataMember()]
        public string ProductGatherSourceTypeRcd { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
}