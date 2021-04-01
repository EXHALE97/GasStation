using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data.Common;
using System.Collections;
using Queries.Entities;
using Queries.Interfaces;
using Queries.Repositories;


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
