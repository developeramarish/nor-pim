﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 9:13:36 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [ServiceContract()]
    public partial interface ICartProductSearchService {
        
        [OperationContract()]
        List<GetCartProductContract> GetCartProduct(System.Guid clientId, System.Guid productId, System.Guid financialCurrencyId, System.Guid userId, System.Guid cartProductId);
    }
    
    public partial class CartProductSearchService : ICartProductSearchService {
        
        public virtual List<GetCartProductContract> GetCartProduct(System.Guid clientId, System.Guid productId, System.Guid financialCurrencyId, System.Guid userId, System.Guid cartProductId) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.CartProductSearch();
            var businessLogicLayer = new GetCartProduct();
            return businessLogicLayer.GetCartProductFromDal(dataAccessLayer.GetCartProduct(clientId, productId, financialCurrencyId, userId, cartProductId));
        }
    }
}