/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 8:51:52 PM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeLocationCityContract {
        
        [DataMember()]
        public System.Guid LocationCityId { get; set; } //;
        
        [DataMember()]
        public System.Guid LocationCountryId { get; set; } //;
        
        [DataMember()]
        public string LocationCityCode { get; set; } //;
        
        [DataMember()]
        public string LocationCityName { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
}