using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ContractReader
{
    
    public class ContractsService : IContractsService
    {
        public List<Contract> GetContracts()
        {
            using (ContractDatabaseEntities db = new ContractDatabaseEntities())
            {
                var result = db.Contracts.Select(x=>x).ToList();
                return result.Select(x => new Contract(
                    x.idContract,
                    x.ContractNumber,
                    x.ContractDate,
                    x.ContractLastUpdate
                    )).ToList();
            }
        }
    }
}
