using System;

namespace Queries.Entities
{
    public class Deal
    {
        public int d_deal_id { private set; get; }
        public int d_car_id { private set; get; }
        public int d_staff_id { private set; get; }
        public string d_fueltype { private set; get; }
        public int d_fuelamount { private set; get; }
        public int d_dealprice { private set; get; }
        public string d_cardnum { private set; get; }
        public DateTime d_dealdate { private set; get; }


        public void dealSet(int deal_id, int car_id, int staff_id, string fueltype, int fuelamount, int dealprice, DateTime dealdate)
        {
            d_deal_id = deal_id;
            d_car_id = car_id;
            d_staff_id = staff_id;
            d_fueltype = fueltype;
            d_fuelamount = fuelamount;
            d_dealprice = dealprice;
            d_dealdate = dealdate;
        }

        public void dealSet(string fueltype, int fuelamount, int dealprice, DateTime dealdate)
        {
            d_fueltype = fueltype;
            d_fuelamount = fuelamount;
            d_dealprice = dealprice;
            d_dealdate = dealdate;
        }

        public void dealSet(int car_id, string fueltype, int fuelamount, int dealprice, DateTime dealdate)
        {
            d_car_id = car_id;
            d_fueltype = fueltype;
            d_fuelamount = fuelamount;
            d_dealprice = dealprice;
            d_dealdate = dealdate;
        }

        public int GetDealID() => d_deal_id;
        public int GetCarID() => d_car_id;
        public int GetStaff_id() => d_staff_id;
        public string GetFuelType() => d_fueltype;
        public int GetFuelAmount() => d_fuelamount;
        public int GetDealPrice() => d_dealprice;
        public string GetCardNum() => d_cardnum;
        public DateTime GetDealDate() => d_dealdate;
    }
}
