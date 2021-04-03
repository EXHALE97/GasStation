using System.Windows.Forms;
using Queries.Interfaces;

namespace Queries.comboBoxFillers
{
    public class ComboBoxAccountingFiller
    {
        private readonly ComboBox comboBox;
        private readonly IRepositoryFactory factory;

        public ComboBoxAccountingFiller(ComboBox comboBox, IRepositoryFactory factory)
        {
            this.comboBox = comboBox;
            this.factory = factory;
        }

        public void СbStationListFill()
        {
            var comboBoxStationElements = factory.GetStationRepository().GetStations();
            foreach (var station in comboBoxStationElements)
            {
                comboBox.Items.Add(factory.GetStationRepository().GetStationAddressById(station.GetStation_id()));
            }
        }
    }
}
