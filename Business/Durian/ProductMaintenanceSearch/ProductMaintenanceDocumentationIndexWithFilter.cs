﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 3:59:54 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class ProductMaintenanceDocumentationIndexWithFilter {
        
        public List<ProductMaintenanceDocumentationIndexWithFilterContract> ProductMaintenanceDocumentationIndexWithFilterFromDal(List<ProductMaintenanceDocumentationIndexWithFilterData> dataList) {
           var list = new List<ProductMaintenanceDocumentationIndexWithFilterContract>();

           foreach (ProductMaintenanceDocumentationIndexWithFilterData data in dataList) {
               var contract = new ProductMaintenanceDocumentationIndexWithFilterContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(ProductMaintenanceDocumentationIndexWithFilterData dalProductMaintenanceDocumentationIndexWithFilter, ProductMaintenanceDocumentationIndexWithFilterContract dataContract) {
            dataContract.ProductName = dalProductMaintenanceDocumentationIndexWithFilter.ProductName;
            dataContract.StateRcd = dalProductMaintenanceDocumentationIndexWithFilter.StateRcd;
            dataContract.ProductDocumentationTypeName = dalProductMaintenanceDocumentationIndexWithFilter.ProductDocumentationTypeName;
            dataContract.DefaultUserName = dalProductMaintenanceDocumentationIndexWithFilter.DefaultUserName;
            dataContract.ProductId = dalProductMaintenanceDocumentationIndexWithFilter.ProductId;
            dataContract.ProductDocumentationTypeRcd = dalProductMaintenanceDocumentationIndexWithFilter.ProductDocumentationTypeRcd;
            dataContract.Documentation = dalProductMaintenanceDocumentationIndexWithFilter.Documentation;
            dataContract.UserId = dalProductMaintenanceDocumentationIndexWithFilter.UserId;
            dataContract.DateTime = dalProductMaintenanceDocumentationIndexWithFilter.DateTime;
            dataContract.ProductDocumentationId = dalProductMaintenanceDocumentationIndexWithFilter.ProductDocumentationId;
        }
    }
}
