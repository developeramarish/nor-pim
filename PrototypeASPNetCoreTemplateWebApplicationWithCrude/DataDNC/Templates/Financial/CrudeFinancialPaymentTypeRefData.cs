﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 9:31:12 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public partial class FinancialPaymentTypeRef {
        
        public const string Accounting = "ACC";
        
        public const string Bank = "BANK";
        
        public const string Card = "CARD";
        
        public const string Cash = "CASH";
        
        public const string Coupon = "COUPON";
        
        public const string StandardPayment = "STD";
        
        public const string Voucher = "VOU";
    }
    
    //[Serializable()]
    public partial class CrudeFinancialPaymentTypeRefData {
        
        public string FinancialPaymentTypeRcd { get; set; } //;
        
        public string FinancialPaymentTypeName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByFinancialPaymentTypeRcd(string financialPaymentTypeRcd) {
            string sql = @" select top 1 financial_payment_type_rcd, financial_payment_type_name, user_id, date_time
                            from [financial_payment_type_ref]
                            where financial_payment_type_rcd = @financial_payment_type_rcd
                            order by financial_payment_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@financial_payment_type_rcd",SqlDbType.NVarChar).Value = financialPaymentTypeRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeFinancialPaymentTypeRefData GetByFinancialPaymentTypeRcd(string financialPaymentTypeRcd) {
            string sql = @" select top 1 financial_payment_type_rcd, financial_payment_type_name, user_id, date_time
                            from [financial_payment_type_ref]
                            where financial_payment_type_rcd = @financial_payment_type_rcd
                            order by financial_payment_type_name";

            var ret = new CrudeFinancialPaymentTypeRefData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_payment_type_rcd",SqlDbType.NVarChar).Value = financialPaymentTypeRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeFinancialPaymentTypeRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeFinancialPaymentTypeRefData>();

            string sql = @" select financial_payment_type_rcd, financial_payment_type_name, user_id, date_time
                            from [financial_payment_type_ref]
                            where user_id = @user_id
                              
                            order by financial_payment_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByFinancialPaymentTypeName(string financialPaymentTypeName) {
            string sql = @" select top 1 financial_payment_type_rcd, financial_payment_type_name, user_id, date_time
                            from [financial_payment_type_ref]
                            where financial_payment_type_name like '%' + @financialPaymentTypeName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@financialPaymentTypeName",SqlDbType.NVarChar).Value = financialPaymentTypeName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeFinancialPaymentTypeRefData> FetchAll() {
            var dataList = new List<CrudeFinancialPaymentTypeRefData>();

            string sql = @" select financial_payment_type_rcd, financial_payment_type_name, user_id, date_time
                            from [financial_payment_type_ref]
                            order by financial_payment_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialPaymentTypeRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeFinancialPaymentTypeRefData>();

            string sql = @" select top " + limit.ToString() + @" financial_payment_type_rcd, financial_payment_type_name, user_id, date_time
                            from [financial_payment_type_ref]
                            order by financial_payment_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialPaymentTypeRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeFinancialPaymentTypeRefData>();

            string sql = @" select financial_payment_type_rcd, financial_payment_type_name, user_id, date_time
                            from [financial_payment_type_ref]
                            order by financial_payment_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeFinancialPaymentTypeRefData();
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
            string sql = @" select count(*) as count from [financial_payment_type_ref]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
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
        
        public static List<CrudeFinancialPaymentTypeRefData> FetchWithFilter(string financialPaymentTypeRcd, string financialPaymentTypeName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeFinancialPaymentTypeRefData>();

            string sql = @" select financial_payment_type_rcd, financial_payment_type_name, user_id, date_time
                            from [financial_payment_type_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(financialPaymentTypeRcd)) {
                        sql += "  and financial_payment_type_rcd like '%' + @financial_payment_type_rcd + '%'";
                        command.Parameters.Add("@financial_payment_type_rcd", SqlDbType.NVarChar).Value = financialPaymentTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(financialPaymentTypeName)) {
                        sql += "  and financial_payment_type_name like '%' + @financial_payment_type_name + '%'";
                        command.Parameters.Add("@financial_payment_type_name", SqlDbType.NVarChar).Value = financialPaymentTypeName.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by financial_payment_type_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["financial_payment_type_rcd"] != System.DBNull.Value) FinancialPaymentTypeRcd = (System.String) reader["financial_payment_type_rcd"];
            if (reader["financial_payment_type_name"] != System.DBNull.Value) FinancialPaymentTypeName = (System.String) reader["financial_payment_type_name"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [financial_payment_type_ref] (financial_payment_type_rcd, financial_payment_type_name, user_id, date_time)";
            sql += "            values (@financial_payment_type_rcd, @financial_payment_type_name, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@financial_payment_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialPaymentTypeRcd;
                    command.Parameters.Add("@financial_payment_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialPaymentTypeName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [financial_payment_type_ref] (financial_payment_type_rcd, financial_payment_type_name, user_id, date_time)";
            sql += "            values (@financial_payment_type_rcd, @financial_payment_type_name, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_payment_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialPaymentTypeRcd;
                command.Parameters.Add("@financial_payment_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialPaymentTypeName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [financial_payment_type_ref] set
                 financial_payment_type_rcd = @financial_payment_type_rcd
                ,financial_payment_type_name = @financial_payment_type_name
                ,user_id = @user_id
                ,date_time = @date_time
            where financial_payment_type_rcd = @financial_payment_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@financial_payment_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialPaymentTypeRcd;
                    command.Parameters.Add("@financial_payment_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialPaymentTypeName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [financial_payment_type_ref] set
                 financial_payment_type_rcd = @financial_payment_type_rcd
                ,financial_payment_type_name = @financial_payment_type_name
                ,user_id = @user_id
                ,date_time = @date_time
            where financial_payment_type_rcd = @financial_payment_type_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_payment_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialPaymentTypeRcd;
                command.Parameters.Add("@financial_payment_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialPaymentTypeName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string financialPaymentTypeRcd) {
            string sql = @" delete [financial_payment_type_ref] 
                where financial_payment_type_rcd = @financial_payment_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_payment_type_rcd",SqlDbType.NVarChar).Value = financialPaymentTypeRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}