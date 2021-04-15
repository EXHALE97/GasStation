using System;
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
                var dealList = Factory.GetDealRepository().GetDealsForClient(clientId);

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
            try
            {
                
                dgvElements = Factory.GetDealRepository().ShowDealTable();
                dealsTable.Rows.Clear();
                foreach (Deal deal in dgvElements)
                {
                    //string cardnum = factory.GetClientRepository().FindCardNumByCarID(deal.GetCarID()); 
                    //dealsTable.Rows.Add(deal.GetDealID(), factory.GetStationRepository().GetStationAddressById(factory.GetEmployeeRepository().FindStationIDByStaffID(deal.GetStaff_id())).Trim().Replace(" ", string.Empty),
                    //    factory.GetEmployeeRepository().FindEmployeeById(deal.GetStaff_id()), deal.GetFuelType(), deal.GetFuelAmount(),
                    //    deal.GetDealPrice(), cardnum, deal.GetDealDate());
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Код ошибки: " + e.State, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception) { MessageBox.Show("Неизвестная ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void ShowWorkerTable(int ID)
        {
            try
            {
                dgvElements = Factory.GetDealRepository().ShowWorkerDealTable(ID);
                dealsTable.Rows.Clear();
                foreach (Deal deal in dgvElements)
                {
                    //dealsTable.Rows.Add(deal.GetFuelType(), deal.GetFuelAmount(), deal.GetDealPrice(), factory.GetClientRepository().FindCardNumByCarID(deal.GetCarID()), deal.GetDealDate());
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Код ошибки: " + e.State, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception) { MessageBox.Show("Неизвестная ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void ShowUserTable(string cardnum)
        {
            try
            {
                dgvElements = Factory.GetDealRepository().ShowUserDealTable(Factory.GetClientRepository().FindCarIDByCardnum(cardnum));
                dealsTable.Rows.Clear();
                foreach (Deal deal in dgvElements)
                {
                    //dealsTable.Rows.Add(deal.GetFuelType(), deal.GetFuelAmount(), deal.GetDealPrice(), deal.GetDealDate());
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Код ошибки: " + e.State, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception) { MessageBox.Show("Неизвестная ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void FindDealsByStationID(int station_id)
        {
            try
            {
                //List<int> IDs = new List<int>();
                //IDs = factory.GetEmployeeRepository().FindStaffIDByStationID(station_id);
                //dealsTable.Rows.Clear();
                //if (IDs.Count != 0)
                //{
                //    List<Deal> stationDealList = new List<Deal>(); 
                //    foreach (int id in IDs)
                //    {
                //        stationDealList = factory.GetDealRepository().ShowWorkerDealTable(id);
                //        foreach (Deal deal in stationDealList)
                //        {
                //            dealsTable.Rows.Add(deal.GetDealID(), factory.GetStationRepository().GetStationAddressById(factory.GetEmployeeRepository().FindStationIDByStaffID(deal.GetStaff_id())).Trim().Replace(" ", string.Empty),
                //                factory.GetEmployeeRepository().FindEmployeeById(deal.GetStaff_id()), deal.GetFuelType(), deal.GetFuelAmount(),
                //                deal.GetDealPrice(), factory.GetClientRepository().FindCardNumByCarID(deal.GetCarID()), deal.GetDealDate());
                //        }
                //    }
                //}
            }
            catch (SqlException e)
            {
                MessageBox.Show("Код ошибки: " + e.State, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception) { MessageBox.Show("Неизвестная ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
