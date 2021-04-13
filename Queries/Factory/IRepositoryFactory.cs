using Queries.Interfaces;

namespace Queries.Factory
{
    public interface IRepositoryFactory 
    {
        IStationRepository GetStationRepository();

        IEmployeeRepository GetEmployeeRepository();

        ICarRepository GetCarRepository();

        IDealRepository GetDealRepository();

        IAccountRepository GetAccountRepository();

        ISupplyRepository GetSupplyRepository();

        ICredentialsRepository GetCredentialsRepository();
    }
}
