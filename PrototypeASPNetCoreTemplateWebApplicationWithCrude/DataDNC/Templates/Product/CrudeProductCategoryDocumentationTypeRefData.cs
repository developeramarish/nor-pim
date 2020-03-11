﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 9:34:37 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public partial class ProductCategoryDocumentationTypeRef {
        
        public const string BottomText = "BT";
        
        public const string TopText = "TT";
    }
    
    //[Serializable()]
    public partial class CrudeProductCategoryDocumentationTypeRefData {
        
        public string ProductCategoryDocumentationTypeRcd { get; set; } //;
        
        public string ProductCategoryDocumentationTypeName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductCategoryDocumentationTypeRcd(string productCategoryDocumentationTypeRcd) {
            string sql = @" select top 1 product_category_documentation_type_rcd, product_category_documentation_type_name, user_id, date_time
                            from [product_category_documentation_type_ref]
                            where product_category_documentation_type_rcd = @product_category_documentation_type_rcd
                            order by product_category_documentation_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@product_category_documentation_type_rcd",SqlDbType.NVarChar).Value = productCategoryDocumentationTypeRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeProductCategoryDocumentationTypeRefData GetByProductCategoryDocumentationTypeRcd(string productCategoryDocumentationTypeRcd) {
            string sql = @" select top 1 product_category_documentation_type_rcd, product_category_documentation_type_name, user_id, date_time
                            from [product_category_documentation_type_ref]
                            where product_category_documentation_type_rcd = @product_category_documentation_type_rcd
                            order by product_category_documentation_type_name";

            var ret = new CrudeProductCategoryDocumentationTypeRefData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_category_documentation_type_rcd",SqlDbType.NVarChar).Value = productCategoryDocumentationTypeRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeProductCategoryDocumentationTypeRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductCategoryDocumentationTypeRefData>();

            string sql = @" select product_category_documentation_type_rcd, product_category_documentation_type_name, user_id, date_time
                            from [product_category_documentation_type_ref]
                            where user_id = @user_id
                              
                            order by product_category_documentation_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryDocumentationTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByProductCategoryDocumentationTypeName(string productCategoryDocumentationTypeName) {
            string sql = @" select top 1 product_category_documentation_type_rcd, product_category_documentation_type_name, user_id, date_time
                            from [product_category_documentation_type_ref]
                            where product_category_documentation_type_name like '%' + @productCategoryDocumentationTypeName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@productCategoryDocumentationTypeName",SqlDbType.NVarChar).Value = productCategoryDocumentationTypeName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeProductCategoryDocumentationTypeRefData> FetchAll() {
            var dataList = new List<CrudeProductCategoryDocumentationTypeRefData>();

            string sql = @" select product_category_documentation_type_rcd, product_category_documentation_type_name, user_id, date_time
                            from [product_category_documentation_type_ref]
                            order by product_category_documentation_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryDocumentationTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductCategoryDocumentationTypeRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductCategoryDocumentationTypeRefData>();

            string sql = @" select top " + limit.ToString() + @" product_category_documentation_type_rcd, product_category_documentation_type_name, user_id, date_time
                            from [product_category_documentation_type_ref]
                            order by product_category_documentation_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryDocumentationTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductCategoryDocumentationTypeRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductCategoryDocumentationTypeRefData>();

            string sql = @" select product_category_documentation_type_rcd, product_category_documentation_type_name, user_id, date_time
                            from [product_category_documentation_type_ref]
                            order by product_category_documentation_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductCategoryDocumentationTypeRefData();
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
            string sql = @" select count(*) as count from [product_category_documentation_type_ref]";

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
        
        public static List<CrudeProductCategoryDocumentationTypeRefData> FetchWithFilter(string productCategoryDocumentationTypeRcd, string productCategoryDocumentationTypeName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductCategoryDocumentationTypeRefData>();

            string sql = @" select product_category_documentation_type_rcd, product_category_documentation_type_name, user_id, date_time
                            from [product_category_documentation_type_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(productCategoryDocumentationTypeRcd)) {
                        sql += "  and product_category_documentation_type_rcd like '%' + @product_category_documentation_type_rcd + '%'";
                        command.Parameters.Add("@product_category_documentation_type_rcd", SqlDbType.NVarChar).Value = productCategoryDocumentationTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(productCategoryDocumentationTypeName)) {
                        sql += "  and product_category_documentation_type_name like '%' + @product_category_documentation_type_name + '%'";
                        command.Parameters.Add("@product_category_documentation_type_name", SqlDbType.NVarChar).Value = productCategoryDocumentationTypeName.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by product_category_documentation_type_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryDocumentationTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_category_documentation_type_rcd"] != System.DBNull.Value) ProductCategoryDocumentationTypeRcd = (System.String) reader["product_category_documentation_type_rcd"];
            if (reader["product_category_documentation_type_name"] != System.DBNull.Value) ProductCategoryDocumentationTypeName = (System.String) reader["product_category_documentation_type_name"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [product_category_documentation_type_ref] (product_category_documentation_type_rcd, product_category_documentation_type_name, user_id, date_time)";
            sql += "            values (@product_category_documentation_type_rcd, @product_category_documentation_type_name, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_category_documentation_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductCategoryDocumentationTypeRcd;
                    command.Parameters.Add("@product_category_documentation_type_name",SqlDbType.NVarChar).Value = (System.String)ProductCategoryDocumentationTypeName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [product_category_documentation_type_ref] (product_category_documentation_type_rcd, product_category_documentation_type_name, user_id, date_time)";
            sql += "            values (@product_category_documentation_type_rcd, @product_category_documentation_type_name, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_category_documentation_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductCategoryDocumentationTypeRcd;
                command.Parameters.Add("@product_category_documentation_type_name",SqlDbType.NVarChar).Value = (System.String)ProductCategoryDocumentationTypeName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_category_documentation_type_ref] set
                 product_category_documentation_type_rcd = @product_category_documentation_type_rcd
                ,product_category_documentation_type_name = @product_category_documentation_type_name
                ,user_id = @user_id
                ,date_time = @date_time
            where product_category_documentation_type_rcd = @product_category_documentation_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_category_documentation_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductCategoryDocumentationTypeRcd;
                    command.Parameters.Add("@product_category_documentation_type_name",SqlDbType.NVarChar).Value = (System.String)ProductCategoryDocumentationTypeName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_category_documentation_type_ref] set
                 product_category_documentation_type_rcd = @product_category_documentation_type_rcd
                ,product_category_documentation_type_name = @product_category_documentation_type_name
                ,user_id = @user_id
                ,date_time = @date_time
            where product_category_documentation_type_rcd = @product_category_documentation_type_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_category_documentation_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductCategoryDocumentationTypeRcd;
                command.Parameters.Add("@product_category_documentation_type_name",SqlDbType.NVarChar).Value = (System.String)ProductCategoryDocumentationTypeName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string productCategoryDocumentationTypeRcd) {
            string sql = @" delete [product_category_documentation_type_ref] 
                where product_category_documentation_type_rcd = @product_category_documentation_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_category_documentation_type_rcd",SqlDbType.NVarChar).Value = productCategoryDocumentationTypeRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}