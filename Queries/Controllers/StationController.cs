using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Interfaces;
using Queries.Validators;

namespace Queries.Controllers
{
    public class StationController
    {
        private readonly DataGridView stationsTable;
        private readonly StationValidator stationValidator;
        private readonly IRepositoryFactory factory;
        private List<string> errorList;
        private string error;

        public StationController(DataGridView stationsTable, IRepositoryFactory factory)
        {
            this.factory = factory;
            this.stationsTable = stationsTable;
            stationValidator = new StationValidator();
        }

        public void ShowTable()
        {
            try
            {
                var rowsCount = stationsTable.Rows.Count;
                var stations = factory.GetStationRepository().GetStations();

                stationsTable.Rows.Clear();
                
                foreach (var ps in stations)
                {
                    if (rowsCount == 4)
                    {
                        stationsTable.Rows.Add(ps.Name, ps.Country, ps.City, ps.Address);
                    }
                    else
                    {
                        stationsTable.Rows.Add(ps.Id, ps.Name, ps.Country, ps.City, ps.Address);
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Код ошибки: " + e.State, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Неизвестная ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FindInTable(string country, string city)
        {
            try
            {
                var stations = factory.GetStationRepository().FindStations(country, city);
                stationsTable.Rows.Clear();
                foreach (var ps in stations)
                {
                    stationsTable.Rows.Add(ps.Name, ps.Country, ps.City, ps.Address);
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Код ошибки: " + e.State, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Неизвестная ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool AddToTable(Station st)
        {
            errorList = new List<string>();
            bool checkFlag = false;
            try
            {
                if (checkFlag = stationValidator.CheckAddition(st, out errorList))
                {
                    factory.GetStationRepository().AddToStationTable(st);
                }
                else
                {
                    int k = 0;
                    foreach (string str in errorList)
                    {
                        k++;
                        error += "Ошибка №" + k + ": " + str + " \n";
                    }
                    MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException e)
            {
                checkFlag = false;
                MessageBox.Show("Код ошибки: " + e.State, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                checkFlag = false;
                MessageBox.Show("Неизвестная ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return checkFlag;
        }
    }
}
