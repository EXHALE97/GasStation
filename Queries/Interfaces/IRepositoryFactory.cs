namespace Queries.Interfaces
{
    public interface IRepositoryFactory 
    {

        IStationRepository GetStationRepository();

        IStaffRepository GetStaffRepository();

        ICarRepository GetCarRepository();

        IDealRepository GetDealRepository();

        IAccountRepository GetAccountRepository();

        ISupplyRepository GetSupplyRepository();

        ILoginRepository GetLoginRepository();
    }
}
