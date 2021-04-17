﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Factory;
using Queries.Support.MessageBox;
using Queries.Support.Validators;

namespace Queries.Controllers
{
    public class DealController : BaseController
    {
        private readonly DataGridView dealsTable;
        private List<Deal> dgvElements;
        private List<string> errorList;


        public DealController(DataGridView dealsTable, IRepositoryFactory factory)
        {
            dgvElements = new List<Deal>();
            Factory = factory;
            this.dealsTable = dealsTable;
        }

        public int ShowDealsForClient(int clientId)
        {
            return DoFormAction(() =>
            {
                var dealList = Factory.GetDealRepository().GetDealsByClient(clientId);

                if (dealList.Count != 0)
                {
                    foreach (var deal in dealList)
                    {
                        dealsTable.Rows.Add(deal.SupplyType, deal.SupplyTypeAmount, deal.CountFullPrice(),
                            deal.CountDiscount(), deal.Price, deal.Date);
                    }
                }
                else ErrorMessageBox.ShowCustomErrorMessage("Сделок с данным пользователем не найдено!");

                return dealList.Count;
            });
        }

        public void ShowTable()
        {
            DoFormAction(() =>
            {
                dealsTable.Rows.Clear();
                foreach (var deal in Factory.GetDealRepository().GetDeals())
                {
                    dealsTable.Rows.Add(deal.Id, deal.Client, deal.Employee, deal.Station, deal.SupplyType,
                        deal.SupplyTypeAmount, deal.Price, deal.CountDiscount(), deal.CountFullPrice(), deal.Date);
                }
            });
        }

        public void ShowWorkerTable(int id)
        {
            DoFormAction(() =>
            {
                dealsTable.Rows.Clear();
                foreach (var deal in Factory.GetDealRepository().GetDealsByEmployee(id))
                {
                    dealsTable.Rows.Add(deal.Id);
                }
            });
        }

        public void ShowUserTable(int id)
        {
            DoFormAction(() =>
            {
                dealsTable.Rows.Clear();
                foreach (var deal in Factory.GetDealRepository().GetDealsByClient(id))
                {
                    dealsTable.Rows.Add(deal.Id);
                }
            });
        }

        public void ShowDealTableByStation(string stationName)
        {
            DoFormAction(() =>
            {
                dealsTable.Rows.Clear();
                foreach (var deal in Factory.GetDealRepository().GetDealsByStation(Factory.GetStationRepository().GetStationIdByName(stationName)))
                {
                    dealsTable.Rows.Add(deal.Id, deal.Client, deal.Employee, deal.Station, deal.SupplyType,
                        deal.SupplyTypeAmount, deal.Price, deal.CountDiscount(), deal.CountFullPrice(), deal.Date); ;
                }
            });
        }

        public bool UpdateTable(int id, Deal deal)
        {
            bool checkFlag = false;
            try
            {
                if (checkFlag = DealValidator.CheckUpdate(id, deal, out errorList))
                {
                    Factory.GetDealRepository().UpdateDealTable(id, deal);
                }
                else
                {
                    //int k = 0;
                    //foreach (string str in errorList)
                    //{
                    //    k++;
                    //    error += "Ошибка №" + k + ": " + str + " \n";
                    //}
                    //MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException e)
            {
                checkFlag = false;
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                checkFlag = false;
                MessageBox.Show("Неизвестная ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return checkFlag;
        }

        public bool AddToTable(Deal deal)
        {
            bool checkFlag = false;
            try
            {
                if (checkFlag = DealValidator.CheckAddition(deal, out errorList))
                {
                    Factory.GetDealRepository().AddToDealTable(deal);
                }
                else
                {
                    //int k = 0;
                    //foreach (string str in errorList)
                    //{
                    //    k++;
                    //    error += "Ошибка №" + k + ": " + str + " \n";
                    //}
                    //MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException e)
            {
                checkFlag = false;
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
