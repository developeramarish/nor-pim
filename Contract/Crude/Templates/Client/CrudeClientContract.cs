﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/30/2020 4:37:29 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public partial class CrudeClientContract {
        
        [DataMember()]
        public System.Guid ClientId { get; set; }
        
        [DataMember()]
        public string ClientTypeRcd { get; set; }
        
        [DataMember()]
        public string ClientNationalityRcd { get; set; }
        
        [DataMember()]
        public string ClientGenderRcd { get; set; }
        
        [DataMember()]
        public string ClientTitleRcd { get; set; }
        
        [DataMember()]
        public System.Guid ClientAddressId { get; set; }
        
        [DataMember()]
        public string FirstName { get; set; }
        
        [DataMember()]
        public string MiddleName { get; set; }
        
        [DataMember()]
        public string LastName { get; set; }
        
        [DataMember()]
        public byte[] Image { get; set; }
        
        [DataMember()]
        public string ImageBlobFilename { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
