using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ContractReader
{
    [ServiceContract]
    public interface IContractsService
    {
        [OperationContract]
        List<Contract> GetContracts();
    }

    [DataContract(IsReference = true)]
    public class Contract
    {
        int id;
        string contractNumber;
        DateTime contractDate;
        DateTime contractLastUpdate;

        public Contract(int id, string contractNumber, DateTime contractDate, DateTime contractLastUpdate)
        {
            this.id = id;
            this.contractNumber = contractNumber;
            this.contractDate = contractDate;
            this.contractLastUpdate = contractLastUpdate;
        }

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string ContractNumber
        {
            get { return contractNumber; }
            set { contractNumber = value; }
        }

        [DataMember]
        public DateTime ContractDate
        {
            get { return contractDate; }
            set { contractDate = value; }
        }

        [DataMember]
        public DateTime ContractLastUpdate
        {
            get { return contractLastUpdate; }
            set { contractLastUpdate = value; }
        }
    }
}
