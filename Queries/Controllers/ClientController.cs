using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Factory;
using Queries.Support.Validators;

namespace Queries.Controllers
{
    public class ClientController : BaseController
    {
        private readonly DataGridView table;
        private string error;

        public ClientController(DataGridView table, IRepositoryFactory factory)
        {
            Factory = factory;
            this.table = table;
        }

        public void ShowTable()
        {
            DoFormAction(() =>
            {
                table.Rows.Clear();

                foreach (var client in Factory.GetClientRepository().GetClients())
                {
                    table.Rows.Add(client.Id, client.FirstName, client.LastName, client.MiddleName ?? "-",
                        client.CardId, client.DiscountPercent, client.ActivationDate, client.CredId == 0 ? "-" : client.CredId.ToString());
                }
            });
        }

        public bool AddToTable(Client car)
        {
            bool checkFlag = false;
            try
            {
                var errorList = new List<string>();
                if (ClientValidator.CheckAddition(car, out errorList))
                {
                    Factory.GetClientRepository().AddToCarTable(car);
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
