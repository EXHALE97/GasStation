using System.Collections.Generic;
using Queries.Entities;
using Queries.Factory;

namespace Queries.Support.ComboBox
{
    public class ComboBoxDealFiller
    {
        private List<string> comboBoxElements;
        private readonly IRepositoryFactory factory;

        public ComboBoxDealFiller(IRepositoryFactory factory)
        {
            this.factory = factory;
        }

        //public void FillStationNamesComboBox()
        //{
        //    List<Station> comboBoxStationElements = factory.GetRepository().GetStations();
        //    foreach (Station station in comboBoxStationElements)
        //    {
        //        comboBox.Items.Add(station.GetStation_id().ToString().Trim().Replace(" ", string.Empty));
        //    }
        //}

        public void FillStationNamesComboBox(System.Windows.Forms.ComboBox comboBox)
        {
            foreach (var station in factory.GetStationRepository().GetStations(false))
            {
                comboBox.Items.Add(station.Name);
            }
        }

        public void СbOrgFill(System.Windows.Forms.ComboBox comboBox)
        {
            comboBoxElements = factory.GetStationRepository().GetOrganizations();
            foreach (var st in comboBoxElements)
            {
                comboBox.Items.Add(st);
            }
        }

        public void СbStationFill(string Orgname, System.Windows.Forms.ComboBox comboBox)
        {
            comboBoxElements = factory.GetStationRepository().GetStationsAddress(Orgname);
            foreach (string st in comboBoxElements)
            {
                comboBox.Items.Add(st.Trim().Replace(" ", string.Empty));
            }
        }

        public void СbCardnumFill()
        {
            List<Client> comboBoxCarElements = factory.GetClientRepository().GetClients();
            foreach (Client car in comboBoxCarElements)
            {               
                //comboBox.Items.Add(car.GetCardNum().Trim().Replace(" ", string.Empty));
            }
        }

        private string RemoveSpaces(string inputString)
        {
            inputString = inputString.Trim().Replace(" ", string.Empty);

            return inputString;
        }
    }
}
