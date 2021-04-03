using System.Collections.Generic;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Interfaces;

namespace Queries.comboBoxFillers
{
    public class ComboBoxSupplyFiller
    {
        private ComboBox cb;
        private IRepositoryFactory factory;

        public ComboBoxSupplyFiller(ComboBox cb, IRepositoryFactory factory)
        {
            this.cb = cb;
            this.factory = factory;
        }

        public void СbStationListFill()
        {
            List<Station> comboBoxStationElements = factory.GetStationRepository().GetStations();
            foreach (Station station in comboBoxStationElements)
            {
                cb.Items.Add(factory.GetStationRepository().GetStationAddressById(station.GetStation_id()));
            }
        }
    }
}
