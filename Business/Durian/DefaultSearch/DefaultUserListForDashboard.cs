﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 6:19:27 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DefaultUserListForDashboard {
        
        public List<DefaultUserListForDashboardContract> DefaultUserListForDashboardFromDal(List<DefaultUserListForDashboardData> dataList) {
           var list = new List<DefaultUserListForDashboardContract>();

           foreach (DefaultUserListForDashboardData data in dataList) {
               var contract = new DefaultUserListForDashboardContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(DefaultUserListForDashboardData dalDefaultUserListForDashboard, DefaultUserListForDashboardContract dataContract) {
            dataContract.DefaultUserCode = dalDefaultUserListForDashboard.DefaultUserCode;
            dataContract.DefaultUserName = dalDefaultUserListForDashboard.DefaultUserName;
            dataContract.Email = dalDefaultUserListForDashboard.Email;
            dataContract.DefaultStateName = dalDefaultUserListForDashboard.DefaultStateName;
            dataContract.ActivityCount = dalDefaultUserListForDashboard.ActivityCount;
            dataContract.LastActivityDateTime = dalDefaultUserListForDashboard.LastActivityDateTime;
            dataContract.CreatedDateTime = dalDefaultUserListForDashboard.CreatedDateTime;
            dataContract.CreatedByDefaultUserCode = dalDefaultUserListForDashboard.CreatedByDefaultUserCode;
            dataContract.CreatedByDefaultUserName = dalDefaultUserListForDashboard.CreatedByDefaultUserName;
            dataContract.DefaultUserId = dalDefaultUserListForDashboard.DefaultUserId;
        }
    }
}
