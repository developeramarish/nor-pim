﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 12:21:32 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public class DefaultUserListContract {
        
        [DataMember()]
        public System.DateTime LastActivityDateTime { get; set; }
        
        [DataMember()]
        public string DefaultUserName { get; set; }
        
        [DataMember()]
        public string DefaultUserCode { get; set; }
        
        [DataMember()]
        public System.DateTime CreatedDateTime { get; set; }
        
        [DataMember()]
        public string Email { get; set; }
        
        [DataMember()]
        public string DefaultStateName { get; set; }
        
        [DataMember()]
        public int ActivityCount { get; set; }
        
        [DataMember()]
        public string CreatedByDefaultUserCode { get; set; }
        
        [DataMember()]
        public string CreatedByDefaultUserName { get; set; }
        
        [DataMember()]
        public System.Guid DefaultUserId { get; set; }
    }
}
