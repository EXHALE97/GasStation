using Queries.Connection;
using Queries.Interfaces;
using Queries.Repositories;

namespace Queries.Factory
{  
    public class RepositoryFactory : IRepositoryFactory
    {
        private readonly DataBaseConnection dbc;

        public RepositoryFactory(DataBaseConnection dbc)
        {
            this.dbc = dbc;
        }

        public IStationRepository GetStationRepository()
        {
            return new StationRepository(dbc);
        }

        public IEmployeeRepository GetEmployeeRepository()
        {
            return new EmployeeRepository(dbc);
        }

        public IClientRepository GetClientRepository()
        {
            return new ClientRepository(dbc);
        }

        public IDealRepository GetDealRepository()
        {
            return new DealRepository(dbc);
        }

        public IWarehouseRepository GetWarehouseRepository()
        {
            return new WarehouseRepository(dbc);
        }

        public ISupplyRepository GetSupplyRepository()
        {
            return new SupplyRepository(dbc);
        }

        public ICredentialsRepository GetCredentialsRepository()
        {
            return new CredentialsRepository(dbc);
        }

        public ISupplyTypeRepository GetSupplyTypeRepository()
        {
            return new SupplyTypeRepository(dbc);
        }

        public IHistoryRepository GetHistoryRepository()
        {
            return new HistoryRepository(dbc);
        }

        public IDatabaseRepository GetDatabaseRepository()
        {
            return new DatabaseRepository(dbc);
        }
    }
}
