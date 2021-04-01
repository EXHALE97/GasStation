using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data.Common;
using System.Collections;
using Queries;
using Queries.Entities;
using Queries.dgvControllers;
using Queries.comboBoxFillers;
using Queries.Repositories;
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
                cb.Items.Add(factory.GetStationRepository().GetStationAdresByID(station.GetStation_id()));
            }
        }
    }
}
