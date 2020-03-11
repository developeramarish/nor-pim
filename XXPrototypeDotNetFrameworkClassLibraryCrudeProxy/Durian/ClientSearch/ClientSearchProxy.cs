/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 9:51:16 PM
  Template: sql2x.ProxyGenerator.ProxyForMethod
*/
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IClientSearchService")]
    public interface IClientSearchService {
        [System.ServiceModel.OperationContract(Action = "http://tempuri.org/IClientSearchService/GetClientWithFilter", ReplyAction = "http://tempuri.org/IClientSearchService/GetClientWithFilterResponse")]
        List<GetClientWithFilterContract> GetClientWithFilter(string lastName, string clientTypeRcd);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClientSearchServiceChannel : IClientSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class ClientSearchService : System.ServiceModel.ClientBase<IClientSearchService>, IClientSearchService {
        
        public ClientSearchService() {
        }
        
        public ClientSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClientSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }

        public List<GetClientWithFilterContract> GetClientWithFilter(string lastName, string clientTypeRcd) {
            return base.Channel.GetClientWithFilter(lastName, clientTypeRcd);
        }
    }
}