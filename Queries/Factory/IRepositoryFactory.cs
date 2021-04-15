using Queries.Interfaces;

namespace Queries.Factory
{
    public interface IRepositoryFactory 
    {
        IStationRepository GetStationRepository();

        IEmployeeRepository GetEmployeeRepository();

        IClientRepository GetClientRepository();

        IDealRepository GetDealRepository();

        IAccountRepository GetAccountRepository();

        ISupplyRepository GetSupplyRepository();

        ICredentialsRepository GetCredentialsRepository();
    }
}
