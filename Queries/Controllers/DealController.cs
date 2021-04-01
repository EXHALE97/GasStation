using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Npgsql;
using Queries.Entities;
using Queries.Repositories;
using Queries.Interfaces;
using Queries.Validators;

namespace Queries.dgvControllers
{
    public class DealController
    {
        private DataGridView dgv;
        private List<Deal> dgvElements;
        private IRepositoryFactory factory;
        private DealValidator dealValidator;
        private List<string> errorList;
        private string error;


        public DealController(DataGridView dgv, IRepositoryFactory factory)
        {
            dgvElements = new List<Deal>();
            this.factory = factory;
            this.dgv = dgv;
            dealValidator = new DealValidator();
        }

        public int ShowDeals(int id)
        {
            var foundDealList = new List<Deal>();
            var dealList = new List<Deal>();
            try {
                dealList = factory.GetDealRepository().ShowBuyerDealTable(id);
                if (dealList.Count != 0)
                {
                    foreach (Deal deal in dealList)
                    {
                        dgv.Rows.Add(deal.GetFuelType(), deal.GetFuelAmount(), deal.GetDealPrice(), deal.GetDealDate());
                    }
                }
                else MessageBox.Show("Сделок с данным пользователем не найдено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (PostgresException pe)
            {
                MessageBox.Show("Код ошибки: " + pe.SqlState, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception) { MessageBox.Show("Неизвестная ошибка!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return dealList.Count;
        }

        public void ShowTable()
        {
            try
            {
                
                dgvElements = factory.GetDealRepository().ShowDealTable();
                dgv.Rows.Clear();
                foreach (Deal deal in dgvElements)
                {
                    string cardnum = factory.GetCarRepository().FindCardNumByCarID(deal.GetCarID()); 
                    dgv.Rows.Add(deal.GetDealID(), factory.GetStationRepository().GetStationAdresByID(factory.GetStaffRepository().FindStationIDByStaffID(deal.GetStaff_id())).Trim().Replace(" ", string.Empty),
                        factory.GetStaffRepository().FindStaffByID(deal.GetStaff_id()), deal.GetFuelType(), deal.GetFuelAmount(),
                        deal.GetDealPrice(), cardnum, deal.GetDealDate());
                }
            }
            catch (PostgresException pe)
            {
                MessageBox.Show("Код ошибки: " + pe.SqlState, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception) { MessageBox.Show("Неизвестная ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void ShowWorkerTable(int ID)
        {
            try
            {
                dgvElements = factory.GetDealRepository().ShowWorkerDealTable(ID);
                dgv.Rows.Clear();
                foreach (Deal deal in dgvElements)
                {
                    dgv.Rows.Add(deal.GetFuelType(), deal.GetFuelAmount(), deal.GetDealPrice(), factory.GetCarRepository().FindCardNumByCarID(deal.GetCarID()), deal.GetDealDate());
                }
            }
            catch (PostgresException pe)
            {
                MessageBox.Show("Код ошибки: " + pe.SqlState, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception) { MessageBox.Show("Неизвестная ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void ShowUserTable(string cardnum)
        {
            try
            {
                dgvElements = factory.GetDealRepository().ShowUserDealTable(factory.GetCarRepository().FindCarIDByCardnum(cardnum));
                dgv.Rows.Clear();
                foreach (Deal deal in dgvElements)
                {
                    dgv.Rows.Add(deal.GetFuelType(), deal.GetFuelAmount(), deal.GetDealPrice(), deal.GetDealDate());
                }
            }
            catch (PostgresException pe)
            {
                MessageBox.Show("Код ошибки: " + pe.SqlState, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception) { MessageBox.Show("Неизвестная ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void FindDealsByStationID(int station_id)
        {
            try
            {
                List<int> IDs = new List<int>();
                IDs = factory.GetStaffRepository().FindStaffIDByStationID(station_id);
                dgv.Rows.Clear();
                if (IDs.Count != 0)
                {
                    List<Deal> stationDealList = new List<Deal>(); 
                    foreach (int id in IDs)
                    {
                        stationDealList = factory.GetDealRepository().ShowWorkerDealTable(id);
                        foreach (Deal deal in stationDealList)
                        {
                            dgv.Rows.Add(deal.GetDealID(), factory.GetStationRepository().GetStationAdresByID(factory.GetStaffRepository().FindStationIDByStaffID(deal.GetStaff_id())).Trim().Replace(" ", string.Empty),
                                factory.GetStaffRepository().FindStaffByID(deal.GetStaff_id()), deal.GetFuelType(), deal.GetFuelAmount(),
                                deal.GetDealPrice(), factory.GetCarRepository().FindCardNumByCarID(deal.GetCarID()), deal.GetDealDate());
                        }
                    }
                }
            }
            catch (PostgresException pe)
            {
                MessageBox.Show("Код ошибки: " + pe.SqlState, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception) { MessageBox.Show("Неизвестная ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public bool UpdateTable(int id, Deal deal)
        {
            bool checkFlag = false;
            try
            {
                if (checkFlag = dealValidator.CheckUpdate(id, deal, out errorList))
                {
                    factory.GetDealRepository().UpdateDealTable(id, deal);
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
            catch (PostgresException pe)
            {
                checkFlag = false;
                MessageBox.Show(pe.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (checkFlag = dealValidator.CheckAddition(deal, out errorList))
                {
                    factory.GetDealRepository().AddToDealTable(deal);
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
            catch (PostgresException pe)
            {
                checkFlag = false;
                MessageBox.Show(pe.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
