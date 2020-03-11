/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 8:54:57 PM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    public partial class FinancialVoucherTypeRef {
        
        public const string DisruptionVoucher = "DV";
        
        public const string FlightVoucher = "FV";
    }
    
    [Serializable()]
    public partial class CrudeFinancialVoucherTypeRefData {
        
        public string FinancialVoucherTypeRcd { get; set; } //;
        
        public string FinancialVoucherTypeName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByFinancialVoucherTypeRcd(string financialVoucherTypeRcd) {
            string sql = @" select top 1 financial_voucher_type_rcd, financial_voucher_type_name, user_id, date_time
                            from [financial_voucher_type_ref]
                            where financial_voucher_type_rcd = @financial_voucher_type_rcd
                            order by financial_voucher_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@financial_voucher_type_rcd",SqlDbType.NVarChar).Value = financialVoucherTypeRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeFinancialVoucherTypeRefData GetByFinancialVoucherTypeRcd(string financialVoucherTypeRcd) {
            string sql = @" select top 1 financial_voucher_type_rcd, financial_voucher_type_name, user_id, date_time
                            from [financial_voucher_type_ref]
                            where financial_voucher_type_rcd = @financial_voucher_type_rcd
                            order by financial_voucher_type_name";

            var ret = new CrudeFinancialVoucherTypeRefData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_voucher_type_rcd",SqlDbType.NVarChar).Value = financialVoucherTypeRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeFinancialVoucherTypeRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeFinancialVoucherTypeRefData>();

            string sql = @" select financial_voucher_type_rcd, financial_voucher_type_name, user_id, date_time
                            from [financial_voucher_type_ref]
                            where user_id = @user_id
                              
                            order by financial_voucher_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialVoucherTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByFinancialVoucherTypeName(string financialVoucherTypeName) {
            string sql = @" select top 1 financial_voucher_type_rcd, financial_voucher_type_name, user_id, date_time
                            from [financial_voucher_type_ref]
                            where financial_voucher_type_name like '%' + @financialVoucherTypeName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@financialVoucherTypeName",SqlDbType.NVarChar).Value = financialVoucherTypeName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeFinancialVoucherTypeRefData> FetchAll() {
            var dataList = new List<CrudeFinancialVoucherTypeRefData>();

            string sql = @" select financial_voucher_type_rcd, financial_voucher_type_name, user_id, date_time
                            from [financial_voucher_type_ref]
                            order by financial_voucher_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialVoucherTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialVoucherTypeRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeFinancialVoucherTypeRefData>();

            string sql = @" select top " + limit.ToString() + @" financial_voucher_type_rcd, financial_voucher_type_name, user_id, date_time
                            from [financial_voucher_type_ref]
                            order by financial_voucher_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialVoucherTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialVoucherTypeRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeFinancialVoucherTypeRefData>();

            string sql = @" select financial_voucher_type_rcd, financial_voucher_type_name, user_id, date_time
                            from [financial_voucher_type_ref]
                            order by financial_voucher_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeFinancialVoucherTypeRefData();
                            data.Populate(reader);
                            dataList.Add(data);
                        }
                        count++;
                        if (count > limit + offset) break;
                    }
                }
                
                return dataList;
            }
        }
        
        public static int FetchAllCount() {
            string sql = @" select count(*) as count from [financial_voucher_type_ref]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                int count = 0;

                using (var command = new SqlCommand(sql, conn)) {
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    reader.Read();
                    count = (System.Int32) reader["count"];
                }

                return count;
            }
        }
        
        public static List<CrudeFinancialVoucherTypeRefData> FetchWithFilter(string financialVoucherTypeRcd, string financialVoucherTypeName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeFinancialVoucherTypeRefData>();

            string sql = @" select financial_voucher_type_rcd, financial_voucher_type_name, user_id, date_time
                            from [financial_voucher_type_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(financialVoucherTypeRcd)) {
                        sql += "  and financial_voucher_type_rcd like '%' + @financial_voucher_type_rcd + '%'";
                        command.Parameters.Add("@financial_voucher_type_rcd", SqlDbType.NVarChar).Value = financialVoucherTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(financialVoucherTypeName)) {
                        sql += "  and financial_voucher_type_name like '%' + @financial_voucher_type_name + '%'";
                        command.Parameters.Add("@financial_voucher_type_name", SqlDbType.NVarChar).Value = financialVoucherTypeName.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by financial_voucher_type_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialVoucherTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["financial_voucher_type_rcd"] != System.DBNull.Value) FinancialVoucherTypeRcd = (System.String) reader["financial_voucher_type_rcd"];
            if (reader["financial_voucher_type_name"] != System.DBNull.Value) FinancialVoucherTypeName = (System.String) reader["financial_voucher_type_name"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [financial_voucher_type_ref] (financial_voucher_type_rcd, financial_voucher_type_name, user_id, date_time)";
            sql += "            values (@financial_voucher_type_rcd, @financial_voucher_type_name, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@financial_voucher_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialVoucherTypeRcd;
                    command.Parameters.Add("@financial_voucher_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialVoucherTypeName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [financial_voucher_type_ref] (financial_voucher_type_rcd, financial_voucher_type_name, user_id, date_time)";
            sql += "            values (@financial_voucher_type_rcd, @financial_voucher_type_name, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_voucher_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialVoucherTypeRcd;
                command.Parameters.Add("@financial_voucher_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialVoucherTypeName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [financial_voucher_type_ref] set
                 financial_voucher_type_rcd = @financial_voucher_type_rcd
                ,financial_voucher_type_name = @financial_voucher_type_name
                ,user_id = @user_id
                ,date_time = @date_time
            where financial_voucher_type_rcd = @financial_voucher_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@financial_voucher_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialVoucherTypeRcd;
                    command.Parameters.Add("@financial_voucher_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialVoucherTypeName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [financial_voucher_type_ref] set
                 financial_voucher_type_rcd = @financial_voucher_type_rcd
                ,financial_voucher_type_name = @financial_voucher_type_name
                ,user_id = @user_id
                ,date_time = @date_time
            where financial_voucher_type_rcd = @financial_voucher_type_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_voucher_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialVoucherTypeRcd;
                command.Parameters.Add("@financial_voucher_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialVoucherTypeName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string financialVoucherTypeRcd) {
            string sql = @" delete [financial_voucher_type_ref] 
                where financial_voucher_type_rcd = @financial_voucher_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_voucher_type_rcd",SqlDbType.NVarChar).Value = financialVoucherTypeRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}