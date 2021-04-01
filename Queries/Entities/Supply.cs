using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries.Entities
{
    public class Supply
    {
        public int s_station_id { private set; get; }
        public int s_staff_id { private set; get; }
        public string s_fuelsupplytype { private set; get; }
        public int s_fuelsupplyamount { private set; get; }
        public DateTime s_supplydate { private set; get; }

        public void supplySet(int station_id, int staff_id, string fuelsupplytype, int fuelsupplyamount, DateTime supplydate)
        {
            s_station_id = station_id;
            s_staff_id = staff_id;
            s_fuelsupplytype = fuelsupplytype;
            s_fuelsupplyamount = fuelsupplyamount;
            s_supplydate = supplydate;
        }

        public int GetStationID() => s_station_id;
        public int GetStaffID() => s_staff_id;
        public string GetFuelSupplyType() => s_fuelsupplytype;
        public int GetFuelSupplyAmount() => s_fuelsupplyamount;
        public DateTime GetSupplyDate() => s_supplydate;
    }
}
