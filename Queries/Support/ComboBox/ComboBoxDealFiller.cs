using System.Collections.Generic;
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

        public void FillCardNumbers(System.Windows.Forms.ComboBox comboBox)
        {
            foreach (var id in factory.GetClientRepository().GetActivatedClientCards())
            {
                comboBox.Items.Add(id);
            }
        }

        public void FillSupplyTypes(System.Windows.Forms.ComboBox comboBox)
        {
            foreach (var supplyType in factory.GetSupplyRepository().GetSupplyTypes())
            {
                comboBox.Items.Add(supplyType.Name);
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

        

        private string RemoveSpaces(string inputString)
        {
            inputString = inputString.Trim().Replace(" ", string.Empty);

            return inputString;
        }
    }
}
