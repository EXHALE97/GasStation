using Queries.Connection;
using Queries.Repositories;
using Queries.Interfaces;

namespace Queries
{  
    public class RepositoryFactory : IRepositoryFactory
    {
        private DataBaseConnection dbc;

        public RepositoryFactory(DataBaseConnection dbc)
        {
            //if (dbc == null)
            //{
            //    throw new ArgumentNullException("Connection out!");
            //}

            this.dbc = dbc;
        }

        public IStationRepository GetStationRepository()
        {
            return new StationRepository(dbc);
        }

        public IStaffRepository GetStaffRepository()
        {
            return new StaffRepository(dbc);
        }

        public ICarRepository GetCarRepository()
        {
            return new CarRepository(dbc);
        }

        public IDealRepository GetDealRepository()
        {
            return new DealRepository(dbc);
        }

        public IAccountRepository GetAccountRepository()
        {
            return new AccountRepository(dbc);
        }

        public ISupplyRepository GetSupplyRepository()
        {
            return new SupplyRepository(dbc);
        }

        public ICredentialsRepository GetLoginRepository()
        {
            return new CredentialsRepository(dbc);
        }
    }
}
