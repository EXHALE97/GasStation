using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries.Entities
{
    public class Car
    {
        protected int b_car_id { private set; get; }
        protected string b_carmark { private set; get; }
        protected string b_cardnum { private set; get; }

        public void buyerSet(int car_id, string carmark, string cardnum)
        {
            b_car_id = car_id;
            b_carmark = carmark;
            b_cardnum = cardnum;
        }

        public void buyerSet(string carmark, string cardnum)
        {
            b_carmark = carmark;
            b_cardnum = cardnum;
        }

        public int GetCarID() => b_car_id;
        public string GetCarMark() => b_carmark;
        public string GetCardNum() => b_cardnum;
    }
}
