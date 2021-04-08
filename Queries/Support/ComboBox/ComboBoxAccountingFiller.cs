using Queries.Factory;

namespace Queries.Support.ComboBox
{
    public class ComboBoxAccountingFiller
    {
        private readonly System.Windows.Forms.ComboBox comboBox;
        private readonly IRepositoryFactory factory;

        public ComboBoxAccountingFiller(System.Windows.Forms.ComboBox comboBox, IRepositoryFactory factory)
        {
            this.comboBox = comboBox;
            this.factory = factory;
        }

        public void СbStationListFill()
        {
            var comboBoxStationElements = factory.GetStationRepository().GetStations();
            foreach (var station in comboBoxStationElements)
            {
                comboBox.Items.Add(factory.GetStationRepository().GetStationAddressById(station.Id));
            }
        }
    }
}
