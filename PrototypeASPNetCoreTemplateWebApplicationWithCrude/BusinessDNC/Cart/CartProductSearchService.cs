/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 10:17:08 PM
  Template: sql2x.DotNetCoreGenerateBusinessLogicLayer.DefaultUsing
*/

using System.Collections.Generic;
using SolutionNorSolutionPim.BusinessLogicLayer.Models;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public partial class CartProductSearchService {
        
        public virtual List<GetCartProductModel> GetCartProduct(System.Guid clientId, System.Guid productId, System.Guid financialCurrencyId, System.Guid userId, System.Guid cartProductId) {
            var dataAccessLayer = new SolutionNorSolutionPim.BusinessLogicLayer.CartProductSearch();
            var businessLogicLayer = new GetCartProduct();
            return businessLogicLayer.GetCartProductFromDal(dataAccessLayer.GetCartProduct(clientId, productId, financialCurrencyId, userId, cartProductId));
        }
    }
}