using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPim.DataAccessLayer
{
    /// <summary> 
    /// Provides Product Reference search with different parameter and result sets
    /// </summary>
    /// <domain>ProductReference</domain>
    public class ProductReferenceAttributeUnitSearch
    {

        /// <summary>Get Product Attribute Unit Ref</summary>
        /// <cardinality>Many</cardinality>
        /// <template>ByServiceTableCrud</template>
        public List<ProductReferenceAttributeUnitSearchWithFilterData> ProductReferenceAttributeUnitSearchWithFilter() {
            var ret = new List<ProductReferenceAttributeUnitSearchWithFilterData>();
            string sql = @"
select 
     paur.product_attribute_unit_name
    ,paur.product_attribute_unit_rcd
    ,paur.date_time
from product_attribute_unit_ref as paur

where 1 = 1
";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.CommandText = sql;

                    // Logging log = Logging.PerformanceTimeStart("ProductReferenceAttributeUnitSearchWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    // log.PerformanceTimeStop(sql, command);

                    var ordinals = new ProductReferenceAttributeUnitSearchWithFilterDataOrdinals(reader);

                    while (reader.Read()) {
                        var data = new ProductReferenceAttributeUnitSearchWithFilterData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }
    
    }
}