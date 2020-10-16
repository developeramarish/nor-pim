﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 2:54:45 PM
  From Machine: DESKTOP-517I8BU
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
    // this class start with an identical representation of product_gather_key's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/: serialization
    [Serializable()]
    public partial class CrudeProductGatherKeyData {
        
        public System.Guid ProductGatherKeyId { get; set; }
        
        public string ProductGatherKeyValue { get; set; }
        
        public System.Guid ProductGatherId { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productGatherKeyId: primary key of table product_gather_key
        public void FetchByProductGatherKeyId(System.Guid productGatherKeyId) {
            // create query against product_gather_key
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 product_gather_key_id, product_gather_key_value, product_gather_id, user_id, date_time
                            from [product_gather_key]
                            where product_gather_key_id = @product_gather_key_id";

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
                    command.Parameters.Add("@product_gather_key_id",SqlDbType.UniqueIdentifier).Value = productGatherKeyId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        // fetch by Primary key into new class instance
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productGatherKeyId: primary key of table product_gather_key
        public static CrudeProductGatherKeyData GetByProductGatherKeyId(System.Guid productGatherKeyId) {
            // create query against product_gather_key
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 product_gather_key_id, product_gather_key_value, product_gather_id, user_id, date_time
                            from [product_gather_key]
                            where product_gather_key_id = @product_gather_key_id";

            var ret = new CrudeProductGatherKeyData();

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@product_gather_key_id",SqlDbType.UniqueIdentifier).Value = productGatherKeyId;

                    // execute query against product_gather_key
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serialized class if a row was found
                    if (reader.Read())
                        ret.Populate(reader);
                }
            }

            return ret;
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeProductGatherKeyData> FetchByProductGatherId(System.Guid productGatherId) {
            var dataList = new List<CrudeProductGatherKeyData>();

            // create query against product_gather_key
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select product_gather_key_id, product_gather_key_value, product_gather_id, user_id, date_time
                            from [product_gather_key]
                            where product_gather_id = @product_gather_id
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@product_gather_id", SqlDbType.UniqueIdentifier).Value = productGatherId;

                    // execute query against product_gather_key
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of product_gather_key
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeProductGatherKeyData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeProductGatherKeyData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductGatherKeyData>();

            // create query against product_gather_key
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select product_gather_key_id, product_gather_key_value, product_gather_id, user_id, date_time
                            from [product_gather_key]
                            where user_id = @user_id
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    // execute query against product_gather_key
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of product_gather_key
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeProductGatherKeyData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all rows from table product_gather_key into new List of class instances
        public static List<CrudeProductGatherKeyData> FetchAll() {
            var dataList = new List<CrudeProductGatherKeyData>();

            // create query against product_gather_key
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select product_gather_key_id, product_gather_key_value, product_gather_id, user_id, date_time
                            from [product_gather_key]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against product_gather_key
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of product_gather_key
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeProductGatherKeyData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public static List<CrudeProductGatherKeyData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductGatherKeyData>();

            // create query against product_gather_key
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top " + limit.ToString() + @" product_gather_key_id, product_gather_key_value, product_gather_id, user_id, date_time
                            from [product_gather_key]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against product_gather_key
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of product_gather_key
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeProductGatherKeyData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public static List<CrudeProductGatherKeyData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductGatherKeyData>();

            // create query against product_gather_key
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select product_gather_key_id, product_gather_key_value, product_gather_id, user_id, date_time
                            from [product_gather_key]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against product_gather_key
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    // read all rows returned from the query of product_gather_key
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductGatherKeyData();
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
            // create query against product_gather_key
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select count(*) as count from [product_gather_key]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                int count = 0;

                using (var command = new SqlCommand(sql, conn)) {
                    // execute query against product_gather_key
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    reader.Read();
                    count = (System.Int32) reader["count"];
                }

                return count;
            }
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public static List<CrudeProductGatherKeyData> FetchWithFilter(System.Guid productGatherKeyId, string productGatherKeyValue, System.Guid productGatherId, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductGatherKeyData>();

            // create query against product_gather_key
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select product_gather_key_id, product_gather_key_value, product_gather_id, user_id, date_time
                            from [product_gather_key]
                            where 1 = 1";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add search column(s) if they are not null or empty
                    // this search column(s) will be used together with the prepared ansi sql statement
                    if (productGatherKeyId != Guid.Empty) {
                        sql += "  and product_gather_key_id = @product_gather_key_id";
                        command.Parameters.Add("@product_gather_key_id", SqlDbType.UniqueIdentifier).Value = productGatherKeyId;
                    }
                    if (!string.IsNullOrEmpty(productGatherKeyValue)) {
                        sql += "  and product_gather_key_value like '%' + @product_gather_key_value + '%'";
                        command.Parameters.Add("@product_gather_key_value", SqlDbType.NVarChar).Value = productGatherKeyValue.Replace("'","''");
                    }
                    if (productGatherId != Guid.Empty) {
                        sql += "  and product_gather_id = @product_gather_id";
                        command.Parameters.Add("@product_gather_id", SqlDbType.UniqueIdentifier).Value = productGatherId;
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    command.CommandText = sql;

                    // execute query against product_gather_key
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of product_gather_key
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeProductGatherKeyData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // read all columns out and populate object members
        public void Populate(IDataReader reader) {
            if (reader["product_gather_key_id"] != System.DBNull.Value) ProductGatherKeyId = (System.Guid) reader["product_gather_key_id"];
            if (reader["product_gather_key_value"] != System.DBNull.Value) ProductGatherKeyValue = (System.String) reader["product_gather_key_value"];
            if (reader["product_gather_id"] != System.DBNull.Value) ProductGatherId = (System.Guid) reader["product_gather_id"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        // insert all object members as a new row in table
        public void Insert() {

            if (ProductGatherKeyId == Guid.Empty)
                ProductGatherKeyId = Guid.NewGuid();

            // create query against product_gather_key
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = "insert into [product_gather_key] (product_gather_key_id, product_gather_key_value, product_gather_id, user_id, date_time)";
            sql += "            values (@product_gather_key_id, @product_gather_key_value, @product_gather_id, @user_id, @date_time)";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    // add column(s) to insert as parameter
                    // the insert column(s) will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@product_gather_key_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductGatherKeyId;
                    command.Parameters.Add("@product_gather_key_value",SqlDbType.NVarChar).Value = (System.String)ProductGatherKeyValue;
                    command.Parameters.Add("@product_gather_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductGatherId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    // execute query against product_gather_key
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductGatherKeyId == Guid.Empty)
                ProductGatherKeyId = Guid.NewGuid();

            // create query against product_gather_key
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = "insert into [product_gather_key] (product_gather_key_id, product_gather_key_value, product_gather_id, user_id, date_time)";
            sql += "            values (@product_gather_key_id, @product_gather_key_value, @product_gather_id, @user_id, @date_time)";

            // use passed in connection
            // transaction scope etc is determined by caller
            // there are no result from this action, SqlClient will raise an exception in case
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to insert as parameter(s)
                // the insert column(s) will be used together with the prepared ansi sql statement
                command.Parameters.Add("@product_gather_key_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductGatherKeyId;
                command.Parameters.Add("@product_gather_key_value",SqlDbType.NVarChar).Value = (System.String)ProductGatherKeyValue;
                command.Parameters.Add("@product_gather_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductGatherId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                // execute query against product_gather_key
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                command.ExecuteNonQuery();
            }
        }
        
        // update all object members on a row in table based on primary key
        public void Update() {
            // create query against product_gather_key
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" update [product_gather_key] set
                 product_gather_key_id = @product_gather_key_id
                ,product_gather_key_value = @product_gather_key_value
                ,product_gather_id = @product_gather_id
                ,user_id = @user_id
                ,date_time = @date_time
            where product_gather_key_id = @product_gather_key_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // add column(s) to update as parameter(s)
                    // the update column(s) will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@product_gather_key_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductGatherKeyId;
                    command.Parameters.Add("@product_gather_key_value",SqlDbType.NVarChar).Value = (System.String)ProductGatherKeyValue;
                    command.Parameters.Add("@product_gather_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductGatherId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    // execute query against product_gather_key
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            // create query against product_gather_key
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" update [product_gather_key] set
                 product_gather_key_id = @product_gather_key_id
                ,product_gather_key_value = @product_gather_key_value
                ,product_gather_id = @product_gather_id
                ,user_id = @user_id
                ,date_time = @date_time
            where product_gather_key_id = @product_gather_key_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to update as parameter
                // the update column(s) will be used together with the prepared ansi sql statement
                command.Parameters.Add("@product_gather_key_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductGatherKeyId;
                command.Parameters.Add("@product_gather_key_value",SqlDbType.NVarChar).Value = (System.String)ProductGatherKeyValue;
                command.Parameters.Add("@product_gather_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductGatherId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                // execute query against product_gather_key
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                command.ExecuteNonQuery();
            }
        }
        
        // delete a row in table based on primary key
        public static void Delete(System.Guid productGatherKeyId) {
            // create query against product_gather_key
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" delete [product_gather_key] 
                where product_gather_key_id = @product_gather_key_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@product_gather_key_id",SqlDbType.UniqueIdentifier).Value = productGatherKeyId;
                    // execute query against product_gather_key
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
