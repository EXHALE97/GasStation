﻿using System.Collections.Generic;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Interfaces;

namespace Queries.comboBoxFillers
{
    public class ComboBoxDealFiller
    {
        private ComboBox cb;
        private List<string> comboBoxElements;
        private IRepositoryFactory factory;

        public ComboBoxDealFiller(ComboBox cb, IRepositoryFactory factory)
        {
            this.cb = cb;
            this.factory = factory;
        }

        //public void СbStationListFill()
        //{
        //    List<Station> comboBoxStationElements = factory.GetStationRepository().GetStations();
        //    foreach (Station station in comboBoxStationElements)
        //    {
        //        cb.Items.Add(station.GetStation_id().ToString().Trim().Replace(" ", string.Empty));
        //    }
        //}

        public void СbStationListFill()
        {
            foreach (var station in factory.GetStationRepository().GetStations())
            {
                cb.Items.Add(factory.GetStationRepository().GetStationAdresByID(station.GetStation_id()));
            }
        }

        public void СbOrgFill()
        {
            comboBoxElements = factory.GetStationRepository().GetOrganisations();
            foreach (var st in comboBoxElements)
            {
                cb.Items.Add(st);
            }
        }

        public void СbStationFill(string Orgname)
        {
            comboBoxElements = factory.GetStationRepository().GetStationsAdres(Orgname);
            foreach (string st in comboBoxElements)
            {
                cb.Items.Add(st.Trim().Replace(" ", string.Empty));
            }
        }

        public void СbCardnumFill()
        {
            List<Car> comboBoxCarElements = factory.GetCarRepository().GetCars();
            foreach (Car car in comboBoxCarElements)
            {               
                cb.Items.Add(car.GetCardNum().Trim().Replace(" ", string.Empty));
            }
        }

        private string RemoveSpaces(string inputString)
        {
            inputString = inputString.Trim().Replace(" ", string.Empty);

            return inputString;
        }
    }
}
