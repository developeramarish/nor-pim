/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 9:58:51 PM
  Template: sql2x.ContractsGenerator.Method
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class DefaultUserActivityGroupedContract {
        
        [DataMember()]
        public string OriginatingAddress { get; set; } //;
        
        [DataMember()]
        public string UserActivityTypeName { get; set; } //;
        
        [DataMember()]
        public string UserActivityNote { get; set; } //;
        
        [DataMember()]
        public int Occurrences { get; set; } //;
    }
}