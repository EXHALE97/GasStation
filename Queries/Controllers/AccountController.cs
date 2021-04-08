using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Factory;
using Queries.Interfaces;

namespace Queries.Controllers
{
    public class AccountController
    {
        private DataGridView dgv;
        private List<Accounting> dgvElements;
        private IRepositoryFactory factory;

        public AccountController(DataGridView dgv, IRepositoryFactory factory)
        {
            dgvElements = new List<Accounting>();
            this.dgv = dgv;
            this.factory = factory;
        }

        public void ShowTable()
        {
            try
            {
                dgvElements = factory.GetAccountRepository().GetAccounting();
                dgv.Rows.Clear();
                foreach (Accounting account in dgvElements)
                {
                    dgv.Rows.Add(account.GetStationID(), factory.GetStationRepository().GetStationAddressById(account.GetStationID()), account.GetAccountRole(), account.GetFuelAccountType(), 
                        account.GetFuelAccountAmount(), account.GetAccountDate());
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

        public void FilterBYStationID(int id)
        {
            try
            {
                dgvElements = factory.GetAccountRepository().GetAccountingBYStationID(id);
                dgv.Rows.Clear();
                foreach (Accounting account in dgvElements)
                {
                    dgv.Rows.Add(account.GetStationID(), factory.GetStationRepository().GetStationAddressById(account.GetStationID()), account.GetAccountRole(), account.GetFuelAccountType(),
                        account.GetFuelAccountAmount(), account.GetAccountDate());
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
    }
}
