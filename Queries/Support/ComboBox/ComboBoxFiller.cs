using Queries.Factory;

namespace Queries.Support.ComboBox
{
    public class ComboBoxFiller
    {
        private readonly IRepositoryFactory factory;

        public ComboBoxFiller(IRepositoryFactory factory)
        {
            this.factory = factory;
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
            foreach (var supplyType in factory.GetSupplyTypeRepository().GetSupplyTypes())
            {
                comboBox.Items.Add(supplyType.Name);
            }
        }

        public void FillStationNamesComboBox(System.Windows.Forms.ComboBox comboBox)
        {
            foreach (var station in factory.GetStationRepository().GetStations(false))
            {
                comboBox.Items.Add(station.Name);
            }
        }

        public void FillStationCitiesComboBox(System.Windows.Forms.ComboBox comboBox)
        {
            foreach (var city in factory.GetStationRepository().GetStationCities())
            {
                comboBox.Items.Add(city);
            }
        }
    }
}
