using Queries.Interfaces;

namespace Queries.Factory
{
    public interface IRepositoryFactory 
    {
        IStationRepository GetStationRepository();

        IEmployeeRepository GetEmployeeRepository();

        IClientRepository GetClientRepository();

        IDealRepository GetDealRepository();

        IWarehouseRepository GetWarehouseRepository();

        ISupplyRepository GetSupplyRepository();

        ICredentialsRepository GetCredentialsRepository();

        ISupplyTypeRepository GetSupplyTypeRepository();

        IHistoryRepository GetHistoryRepository();

        IDatabaseRepository GetDatabaseRepository();
    }
}
