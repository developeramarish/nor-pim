﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/3/2020 3:56:43 PM
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

    public class ProductSearchById {
        
        public ProductSearchByIdContract ProductSearchByIdFromDal(ProductSearchByIdData data) {
            var contract = new ProductSearchByIdContract();
            DataToContract(data, contract);

            return contract;
        }
        
        public void DataToContract(ProductSearchByIdData dalProductSearchById, ProductSearchByIdContract dataContract) {
            dataContract.ProductName = dalProductSearchById.ProductName;
            dataContract.Identifier = dalProductSearchById.Identifier;
            dataContract.Value = dalProductSearchById.Value;
            dataContract.ProductInfoValue = dalProductSearchById.ProductInfoValue;
            dataContract.ProductImageTypeRcd = dalProductSearchById.ProductImageTypeRcd;
            dataContract.ProductImageTypeName = dalProductSearchById.ProductImageTypeName;
            dataContract.Image = dalProductSearchById.Image;
        }
    }
}
