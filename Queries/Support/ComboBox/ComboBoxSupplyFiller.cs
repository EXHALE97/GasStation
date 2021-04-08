using System.Collections.Generic;
using Queries.Entities;
using Queries.Factory;

namespace Queries.Support.ComboBox
{
    public class ComboBoxSupplyFiller
    {
        private System.Windows.Forms.ComboBox cb;
        private IRepositoryFactory factory;

        public ComboBoxSupplyFiller(System.Windows.Forms.ComboBox cb, IRepositoryFactory factory)
        {
            this.cb = cb;
            this.factory = factory;
        }

        public void СbStationListFill()
        {
            List<Station> comboBoxStationElements = factory.GetStationRepository().GetStations();
            foreach (Station station in comboBoxStationElements)
            {
                cb.Items.Add(factory.GetStationRepository().GetStationAddressById(station.Id));
            }
        }
    }
}
