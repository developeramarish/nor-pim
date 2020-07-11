﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 12:49:13 PM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {

    [Serializable()]
    public partial class DefaultUserActivityGroupedByAddressData {
        
        public string OriginatingAddress { get; set; }
        
        public int Occurrences { get; set; }
        
        public void Populate(IDataReader reader, DefaultUserActivityGroupedByAddressDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.OriginatingAddress)) OriginatingAddress = reader.GetString(ordinals.OriginatingAddress);
            if (!reader.IsDBNull(ordinals.Occurrences)) Occurrences = reader.GetInt32(ordinals.Occurrences);
        }
    }
    
    public partial class DefaultUserActivityGroupedByAddressDataOrdinals {
        
        public int OriginatingAddress;
        
        public int Occurrences;
        
        public DefaultUserActivityGroupedByAddressDataOrdinals(IDataReader reader) {
            OriginatingAddress = reader.GetOrdinal("originating_address");
            Occurrences = reader.GetOrdinal("occurrences");
        }
    }
}
