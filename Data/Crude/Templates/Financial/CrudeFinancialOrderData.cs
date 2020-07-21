﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:46:58 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

// Data Access Layer
// the DataAccessLayer is the first layer that has access to data coming from
//  sql server after being streamed over a net or internal process
// links:
//   https://en.wikipedia.org/wiki/Data_access_layer: data access layer
namespace SolutionNorSolutionPim.DataAccessLayer {

    // this class serves as a data access layer between c# and sql server
    // it is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of financial_order's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/: serialization
    [Serializable()]
    public partial class CrudeFinancialOrderData {
        
        public System.Guid FinancialOrderId { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public string Comment { get; set; }
        
        public System.Guid LocationAddressId { get; set; }
        
        public System.Guid FinancialCurrencyId { get; set; }
        
        public string FinancialOrderSourceRcd { get; set; }
        
        public System.Guid ClientId { get; set; }
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   financialOrderId: primary key of table financial_order
        public void FetchByFinancialOrderId(System.Guid financialOrderId) {
            // create query against financial_order
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 financial_order_id, user_id, date_time, comment, location_address_id, financial_currency_id, financial_order_source_rcd, client_id
                            from [financial_order]
                            where financial_order_id = @financial_order_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                // dirty read
                // starting a transaction seems to be the only way of doing a dirty read
                // a dirty read means a row is read even if it is marked
                //   as locked by another database transaction
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = financialOrderId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        // fetch by Primary key into new class instance
        public static CrudeFinancialOrderData GetByFinancialOrderId(System.Guid financialOrderId) {
            string sql = @" select top 1 financial_order_id, user_id, date_time, comment, location_address_id, financial_currency_id, financial_order_source_rcd, client_id
                            from [financial_order]
                            where financial_order_id = @financial_order_id";

            var ret = new CrudeFinancialOrderData();

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = financialOrderId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serialized class if row was found
                    if (reader.Read())
                        ret.Populate(reader);
                }
            }

            return ret;
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeFinancialOrderData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeFinancialOrderData>();

            string sql = @" select financial_order_id, user_id, date_time, comment, location_address_id, financial_currency_id, financial_order_source_rcd, client_id
                            from [financial_order]
                            where user_id = @user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeFinancialOrderData> FetchByLocationAddressId(System.Guid locationAddressId) {
            var dataList = new List<CrudeFinancialOrderData>();

            string sql = @" select financial_order_id, user_id, date_time, comment, location_address_id, financial_currency_id, financial_order_source_rcd, client_id
                            from [financial_order]
                            where location_address_id = @location_address_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@location_address_id", SqlDbType.UniqueIdentifier).Value = locationAddressId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeFinancialOrderData> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            var dataList = new List<CrudeFinancialOrderData>();

            string sql = @" select financial_order_id, user_id, date_time, comment, location_address_id, financial_currency_id, financial_order_source_rcd, client_id
                            from [financial_order]
                            where financial_currency_id = @financial_currency_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_currency_id", SqlDbType.UniqueIdentifier).Value = financialCurrencyId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeFinancialOrderData> FetchByClientId(System.Guid clientId) {
            var dataList = new List<CrudeFinancialOrderData>();

            string sql = @" select financial_order_id, user_id, date_time, comment, location_address_id, financial_currency_id, financial_order_source_rcd, client_id
                            from [financial_order]
                            where client_id = @client_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_id", SqlDbType.UniqueIdentifier).Value = clientId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeFinancialOrderData> FetchByFinancialOrderSourceRcd(string financialOrderSourceRcd) {
            var dataList = new List<CrudeFinancialOrderData>();

            string sql = @" select financial_order_id, user_id, date_time, comment, location_address_id, financial_currency_id, financial_order_source_rcd, client_id
                            from [financial_order]
                            where financial_order_source_rcd = @financial_order_source_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_order_source_rcd", SqlDbType.NVarChar).Value = financialOrderSourceRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances
        public static List<CrudeFinancialOrderData> FetchAll() {
            var dataList = new List<CrudeFinancialOrderData>();

            string sql = @" select financial_order_id, user_id, date_time, comment, location_address_id, financial_currency_id, financial_order_source_rcd, client_id
                            from [financial_order]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public static List<CrudeFinancialOrderData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeFinancialOrderData>();

            string sql = @" select top " + limit.ToString() + @" financial_order_id, user_id, date_time, comment, location_address_id, financial_currency_id, financial_order_source_rcd, client_id
                            from [financial_order]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, only populating specific columns , with a limit on number of returned rows and order by columns starting at a specific row
        public static List<CrudeFinancialOrderData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeFinancialOrderData>();

            string sql = @" select financial_order_id, user_id, date_time, comment, location_address_id, financial_currency_id, financial_order_source_rcd, client_id
                            from [financial_order]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeFinancialOrderData();
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
        
        // get a count of rows in table
        public static int FetchAllCount() {
            string sql = @" select count(*) as count from [financial_order]";

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
        
        // fetch all from table into new List of class instances, filtered by any column
        public static List<CrudeFinancialOrderData> FetchWithFilter(System.Guid financialOrderId, System.Guid userId, System.DateTime dateTime, string comment, System.Guid locationAddressId, System.Guid financialCurrencyId, string financialOrderSourceRcd, System.Guid clientId) {
            var dataList = new List<CrudeFinancialOrderData>();

            string sql = @" select financial_order_id, user_id, date_time, comment, location_address_id, financial_currency_id, financial_order_source_rcd, client_id
                            from [financial_order]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (financialOrderId != Guid.Empty) {
                        sql += "  and financial_order_id = @financial_order_id";
                        command.Parameters.Add("@financial_order_id", SqlDbType.UniqueIdentifier).Value = financialOrderId;
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    if (!string.IsNullOrEmpty(comment)) {
                        sql += "  and comment like '%' + @comment + '%'";
                        command.Parameters.Add("@comment", SqlDbType.NVarChar).Value = comment.Replace("'","''");
                    }
                    if (locationAddressId != Guid.Empty) {
                        sql += "  and location_address_id = @location_address_id";
                        command.Parameters.Add("@location_address_id", SqlDbType.UniqueIdentifier).Value = locationAddressId;
                    }
                    if (financialCurrencyId != Guid.Empty) {
                        sql += "  and financial_currency_id = @financial_currency_id";
                        command.Parameters.Add("@financial_currency_id", SqlDbType.UniqueIdentifier).Value = financialCurrencyId;
                    }
                    if (!string.IsNullOrEmpty(financialOrderSourceRcd)) {
                        sql += "  and financial_order_source_rcd like '%' + @financial_order_source_rcd + '%'";
                        command.Parameters.Add("@financial_order_source_rcd", SqlDbType.NVarChar).Value = financialOrderSourceRcd.Replace("'","''");
                    }
                    if (clientId != Guid.Empty) {
                        sql += "  and client_id = @client_id";
                        command.Parameters.Add("@client_id", SqlDbType.UniqueIdentifier).Value = clientId;
                    }
                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // read all columns out and populate object members
        public void Populate(IDataReader reader) {
            if (reader["financial_order_id"] != System.DBNull.Value) FinancialOrderId = (System.Guid) reader["financial_order_id"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
            if (reader["comment"] != System.DBNull.Value) Comment = (System.String) reader["comment"];
            if (reader["location_address_id"] != System.DBNull.Value) LocationAddressId = (System.Guid) reader["location_address_id"];
            if (reader["financial_currency_id"] != System.DBNull.Value) FinancialCurrencyId = (System.Guid) reader["financial_currency_id"];
            if (reader["financial_order_source_rcd"] != System.DBNull.Value) FinancialOrderSourceRcd = (System.String) reader["financial_order_source_rcd"];
            if (reader["client_id"] != System.DBNull.Value) ClientId = (System.Guid) reader["client_id"];
        }
        
        // insert all object members as a new row in table
        public void Insert() {

            if (FinancialOrderId == Guid.Empty)
                FinancialOrderId = Guid.NewGuid();

            string sql = "insert into [financial_order] (financial_order_id, user_id, date_time, comment, location_address_id, financial_currency_id, financial_order_source_rcd, client_id)";
            sql += "            values (@financial_order_id, @user_id, @date_time, @comment, @location_address_id, @financial_currency_id, @financial_order_source_rcd, @client_id)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Comment)) ? (object)DBNull.Value : (System.String)Comment;
                    command.Parameters.Add("@location_address_id",SqlDbType.UniqueIdentifier).Value = (LocationAddressId == Guid.Empty ? (object)DBNull.Value : (System.Guid)LocationAddressId);
                    command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                    command.Parameters.Add("@financial_order_source_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialOrderSourceRcd;
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (FinancialOrderId == Guid.Empty)
                FinancialOrderId = Guid.NewGuid();

            string sql = "insert into [financial_order] (financial_order_id, user_id, date_time, comment, location_address_id, financial_currency_id, financial_order_source_rcd, client_id)";
            sql += "            values (@financial_order_id, @user_id, @date_time, @comment, @location_address_id, @financial_currency_id, @financial_order_source_rcd, @client_id)";

            // use passed in connection
            // transaction scope etc is determined by caller
            // there are no result from this action, SqlClient will raise an exception in case
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Comment)) ? (object)DBNull.Value : (System.String)Comment;
                command.Parameters.Add("@location_address_id",SqlDbType.UniqueIdentifier).Value = (LocationAddressId == Guid.Empty ? (object)DBNull.Value : (System.Guid)LocationAddressId);
                command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                command.Parameters.Add("@financial_order_source_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialOrderSourceRcd;
                command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                command.ExecuteNonQuery();
            }
        }
        
        // update all object members on a row in table based on primary key
        public void Update() {
            string sql = @" update [financial_order] set
                 financial_order_id = @financial_order_id
                ,user_id = @user_id
                ,date_time = @date_time
                ,comment = @comment
                ,location_address_id = @location_address_id
                ,financial_currency_id = @financial_currency_id
                ,financial_order_source_rcd = @financial_order_source_rcd
                ,client_id = @client_id
            where financial_order_id = @financial_order_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Comment)) ? (object)DBNull.Value : (System.String)Comment;
                    command.Parameters.Add("@location_address_id",SqlDbType.UniqueIdentifier).Value = (LocationAddressId == Guid.Empty ? (object)DBNull.Value : (System.Guid)LocationAddressId);
                    command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                    command.Parameters.Add("@financial_order_source_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialOrderSourceRcd;
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [financial_order] set
                 financial_order_id = @financial_order_id
                ,user_id = @user_id
                ,date_time = @date_time
                ,comment = @comment
                ,location_address_id = @location_address_id
                ,financial_currency_id = @financial_currency_id
                ,financial_order_source_rcd = @financial_order_source_rcd
                ,client_id = @client_id
            where financial_order_id = @financial_order_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Comment)) ? (object)DBNull.Value : (System.String)Comment;
                command.Parameters.Add("@location_address_id",SqlDbType.UniqueIdentifier).Value = (LocationAddressId == Guid.Empty ? (object)DBNull.Value : (System.Guid)LocationAddressId);
                command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                command.Parameters.Add("@financial_order_source_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialOrderSourceRcd;
                command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                command.ExecuteNonQuery();
            }
        }
        
        // delete a row in table based on primary key
        public static void Delete(System.Guid financialOrderId) {
            string sql = @" delete [financial_order] 
                where financial_order_id = @financial_order_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = financialOrderId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
