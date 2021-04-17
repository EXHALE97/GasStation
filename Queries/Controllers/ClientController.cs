using System.Linq;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Factory;
using Queries.Support.MessageBox;
using Queries.Support.Validators;

namespace Queries.Controllers
{
    public class ClientController : BaseController
    {
        private readonly DataGridView table;

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
                var x = Factory.GetClientRepository().GetClients();
                foreach (var client in Factory.GetClientRepository().GetClients())
                {
                    table.Rows.Add(client.Id, client.FirstName ?? "-", client.LastName ?? "-", client.MiddleName ?? "-",
                        client.CardId, client.DiscountPercent, client.ActivationDate, client.CredId == 0 ? "-" : client.CredId.ToString());
                }
            });
        }

        public void FillCardsComboBox(ComboBox comboBox)
        {
            DoFormAction(() =>
            {
                foreach (var id in Factory.GetClientRepository().GetNonActivatedClientCards())
                {
                    comboBox.Items.Add(id);
                }
            });
        }

        public bool AddToTable(Client client)
        {
            return DoFormAction(() =>
            {
                if (ClientValidator.CheckAddition(client, out var errorList))
                {
                    Factory.GetClientRepository().AddToClientTable(client);
                    return true;
                }

                ErrorMessageBox.ShowCustomErrorMessage(errorList.Aggregate(string.Empty,
                    (current, error) => current + "Ошибка №" + errorList.IndexOf(error) + ": " + error + " \n"));

                return false;
            });
        }
    }
}
