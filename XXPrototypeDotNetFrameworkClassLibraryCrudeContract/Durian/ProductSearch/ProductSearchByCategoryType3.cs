/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 10:06:12 PM
  Template: sql2x.ContractsGenerator.Method
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class ProductSearchByCategoryType3Contract {
        
        [DataMember()]
        public System.Guid ProductId { get; set; } //;
        
        [DataMember()]
        public string ProductName { get; set; } //;
        
        [DataMember()]
        public string Gtin13 { get; set; } //;
        
        [DataMember()]
        public string Hn { get; set; } //;
        
        [DataMember()]
        public string Color { get; set; } //;
    }
}