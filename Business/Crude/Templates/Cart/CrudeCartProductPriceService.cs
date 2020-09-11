﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:40:05 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeSoap.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel.Activation;
using SolutionNorSolutionPim.DataAccessLayer;

// Business Logic Layer
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  SOAP http services, using Windows Communication Framework
// links:
//   https://en.wikipedia.org/wiki/Business_logic: business logic layer
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // this interface is used to expose C# objects as SOAP services using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [ServiceContract()]
    public partial interface ICrudeCartProductPriceService {
        
        [OperationContract()]
        CrudeCartProductPriceContract FetchByCartProductPriceId(System.Guid cartProductPriceId);
        
        [OperationContract()]
        List<CrudeCartProductPriceContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeCartProductPriceContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeCartProductPriceContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeCartProductPriceContract> FetchByStateRcd(string stateRcd);
        
        [OperationContract()]
        List<CrudeCartProductPriceContract> FetchWithFilter(System.Guid cartProductPriceId, System.Guid financialCurrencyId, decimal amount, string stateRcd, System.Guid userId, System.DateTime dateTime, System.Guid productId);
        
        [OperationContract()]
        List<CrudeCartProductPriceContract> FetchAll();
        
        [OperationContract()]
        List<CrudeCartProductPriceContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeCartProductPriceContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeCartProductPriceContract contract);
        
        [OperationContract()]
        void Update(CrudeCartProductPriceContract contract);
        
        [OperationContract()]
        void Delete(System.Guid cartProductPriceId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of cart_product_price's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeCartProductPriceService : ICrudeCartProductPriceService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   cartProductPriceId: primary key of table cart_product_price
        public CrudeCartProductPriceContract FetchByCartProductPriceId(System.Guid cartProductPriceId) {
            var dataAccessLayer = new CrudeCartProductPriceData();
            var contract = new CrudeCartProductPriceContract();

            dataAccessLayer.FetchByCartProductPriceId(cartProductPriceId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeCartProductPriceContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToContractList(CrudeCartProductPriceData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeCartProductPriceContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeCartProductPriceData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeCartProductPriceContract> FetchByProductId(System.Guid productId) {
            return DataListToContractList(CrudeCartProductPriceData.FetchByProductId(productId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeCartProductPriceContract> FetchByStateRcd(string stateRcd) {
            return DataListToContractList(CrudeCartProductPriceData.FetchByStateRcd(stateRcd));
        }
        
        public static List<CrudeCartProductPriceContract> DataListToContractList(List<CrudeCartProductPriceData> dataList) {
            var contractList = new List<CrudeCartProductPriceContract>();

            foreach (CrudeCartProductPriceData data in dataList) {
                var contract = new CrudeCartProductPriceContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeCartProductPriceContract> contractList, List<CrudeCartProductPriceData> dataList) {
            foreach (CrudeCartProductPriceContract contract in contractList) {
                var data = new CrudeCartProductPriceData();
                CrudeCartProductPriceService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeCartProductPriceContract> FetchAll() {
            var list = new List<CrudeCartProductPriceContract>();
            List<CrudeCartProductPriceData> dataList = CrudeCartProductPriceData.FetchAll();

            foreach (CrudeCartProductPriceData crudeCartProductPrice in dataList) {
                var contract = new CrudeCartProductPriceContract();
                DataToContract(crudeCartProductPrice, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeCartProductPriceContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeCartProductPriceContract>();
            List<CrudeCartProductPriceData> dataList = CrudeCartProductPriceData.FetchAllWithLimit(limit);

            foreach (CrudeCartProductPriceData crudeCartProductPrice in dataList) {
                var contract = new CrudeCartProductPriceContract();
                DataToContract(crudeCartProductPrice, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeCartProductPriceContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeCartProductPriceContract>();
            List<CrudeCartProductPriceData> dataList = CrudeCartProductPriceData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeCartProductPriceData crudeCartProductPrice in dataList) {
                var contract = new CrudeCartProductPriceContract();
                DataToContract(crudeCartProductPrice, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeCartProductPriceData.FetchAllCount();
        }
        
        public List<CrudeCartProductPriceContract> FetchWithFilter(System.Guid cartProductPriceId, System.Guid financialCurrencyId, decimal amount, string stateRcd, System.Guid userId, System.DateTime dateTime, System.Guid productId) {
            var list = new List<CrudeCartProductPriceContract>();
            List<CrudeCartProductPriceData> dataList = CrudeCartProductPriceData.FetchWithFilter(
                cartProductPriceId: cartProductPriceId,
                financialCurrencyId: financialCurrencyId,
                amount: amount,
                stateRcd: stateRcd,
                userId: userId,
                dateTime: dateTime,
                productId: productId
                );

            foreach (CrudeCartProductPriceData data in dataList) {
                var crudeCartProductPriceContract = new CrudeCartProductPriceContract();
                DataToContract(data, crudeCartProductPriceContract);
                list.Add(crudeCartProductPriceContract);
            }

            return list;
        }
        
        public void Insert(CrudeCartProductPriceContract contract) {
            var data = new CrudeCartProductPriceData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeCartProductPriceContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeCartProductPriceData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeCartProductPriceContract contract) {
            var data = new CrudeCartProductPriceData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeCartProductPriceContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeCartProductPriceData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid cartProductPriceId) {
            CrudeCartProductPriceData.Delete(cartProductPriceId);
        }
        
        public static void ContractToData(CrudeCartProductPriceContract contract, CrudeCartProductPriceData data) {
            data.CartProductPriceId = contract.CartProductPriceId;
            data.FinancialCurrencyId = contract.FinancialCurrencyId;
            data.Amount = contract.Amount;
            data.StateRcd = contract.StateRcd;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
            data.ProductId = contract.ProductId;
        }
        
        public static void DataToContract(CrudeCartProductPriceData data, CrudeCartProductPriceContract contract) {
            contract.CartProductPriceId = data.CartProductPriceId;
            contract.FinancialCurrencyId = data.FinancialCurrencyId;
            contract.Amount = data.Amount;
            contract.StateRcd = data.StateRcd;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
            contract.ProductId = data.ProductId;
        }
    }
}
