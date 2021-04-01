using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries.Entities
{
    public class Account
    {
        public int a_station_id { private set; get; }
        public string a_accountrole { private set; get; }
        public string a_fuelaccounttype { private set; get; }
        public int a_fuelaccountamount { private set; get; }
        public DateTime a_accountdate { private set; get; }

        public void accountSet(int station_id, string accountrole, string fuelaccounttype, int fuelaccountamount, DateTime accountdate)
        {
            a_station_id = station_id;
            a_accountrole = accountrole;
            a_fuelaccounttype = fuelaccounttype;
            a_fuelaccountamount = fuelaccountamount;
            a_accountdate = accountdate;
        }

        public int GetStationID() => a_station_id;
        public string GetAccountRole() => a_accountrole;
        public string GetFuelAccountType() => a_fuelaccounttype;
        public int GetFuelAccountAmount() => a_fuelaccountamount;
        public DateTime GetAccountDate() => a_accountdate;
    }
}
