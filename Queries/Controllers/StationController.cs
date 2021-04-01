using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Interfaces;
using Queries.Validators;

namespace Queries.dgvControllers
{
    public class StationController
    {
        private DataGridView dgv;
        private StationValidator stationValidator;
        private List<Station> dgvElements;
        private IRepositoryFactory factory;
        private List<string> errorList;
        private string error;

        public StationController(DataGridView dgv, IRepositoryFactory factory)
        {
            this.factory = factory;
            this.dgv = dgv;
            stationValidator = new StationValidator();
        }

        public void ShowTable()
        {
            try
            {
                dgvElements = new List<Station>();
                dgvElements = factory.GetStationRepository().GetStations();
                dgv.Rows.Clear();
                foreach (Station ps in dgvElements)
                {
                    dgv.Rows.Add(ps.GetOrgName(), ps.GetCountry(), ps.GetCity(), ps.GetStreet());
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

        public void ShowAdminTable()
        {
            try
            {
                dgvElements = new List<Station>();
                dgvElements = factory.GetStationRepository().GetStations();
                dgv.Rows.Clear();
                foreach (Station ps in dgvElements)
                {
                    dgv.Rows.Add(ps.GetStation_id(), ps.GetOrgName(), ps.GetCountry(), ps.GetCity(), ps.GetStreet(), ps.GetStorageCap());
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
                dgvElements = new List<Station>();
                dgvElements = factory.GetStationRepository().FindStations(country, city);
                dgv.Rows.Clear();
                foreach (Station ps in dgvElements)
                {
                    dgv.Rows.Add(ps.GetOrgName(), ps.GetCountry(), ps.GetCity(), ps.GetStreet());
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
