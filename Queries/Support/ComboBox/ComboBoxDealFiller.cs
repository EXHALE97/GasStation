using System.Collections.Generic;
using Queries.Entities;
using Queries.Factory;

namespace Queries.Support.ComboBox
{
    public class ComboBoxDealFiller
    {
        private System.Windows.Forms.ComboBox cb;
        private List<string> comboBoxElements;
        private IRepositoryFactory factory;

        public ComboBoxDealFiller(System.Windows.Forms.ComboBox cb, IRepositoryFactory factory)
        {
            this.cb = cb;
            this.factory = factory;
        }

        //public void СbStationListFill()
        //{
        //    List<Station> comboBoxStationElements = factory.GetRepository().GetStations();
        //    foreach (Station station in comboBoxStationElements)
        //    {
        //        cb.Items.Add(station.GetStation_id().ToString().Trim().Replace(" ", string.Empty));
        //    }
        //}

        public void СbStationListFill()
        {
            foreach (var station in factory.GetStationRepository().GetStations(false))
            {
                cb.Items.Add(factory.GetStationRepository().GetStationAddressById(station.Id));
            }
        }

        public void СbOrgFill()
        {
            comboBoxElements = factory.GetStationRepository().GetOrganizations();
            foreach (var st in comboBoxElements)
            {
                cb.Items.Add(st);
            }
        }

        public void СbStationFill(string Orgname)
        {
            comboBoxElements = factory.GetStationRepository().GetStationsAddress(Orgname);
            foreach (string st in comboBoxElements)
            {
                cb.Items.Add(st.Trim().Replace(" ", string.Empty));
            }
        }

        public void СbCardnumFill()
        {
            List<Client> comboBoxCarElements = factory.GetClientRepository().GetClients();
            foreach (Client car in comboBoxCarElements)
            {               
                //cb.Items.Add(car.GetCardNum().Trim().Replace(" ", string.Empty));
            }
        }

        private string RemoveSpaces(string inputString)
        {
            inputString = inputString.Trim().Replace(" ", string.Empty);

            return inputString;
        }
    }
}
