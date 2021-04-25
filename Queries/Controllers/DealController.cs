using System.Linq;
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

        public DealController(IRepositoryFactory factory)
        {
            Factory = factory;
        }

        public DealController(DataGridView dealsTable, IRepositoryFactory factory)
        {
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
                    dealsTable.Rows.Add(deal.Id, deal.ClientCardId, deal.Client, deal.Employee, deal.Station, deal.SupplyType,
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
                    dealsTable.Rows.Add(deal.ClientCardId, deal.Client, deal.SupplyType,
                        deal.SupplyTypeAmount, deal.Price, deal.CountDiscount(), deal.CountFullPrice(), deal.Date);
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
                    dealsTable.Rows.Add(deal.SupplyType, deal.SupplyTypeAmount, deal.CountFullPrice(), deal.Date);
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
                    dealsTable.Rows.Add(deal.Id, deal.ClientCardId, deal.Client, deal.Employee, deal.Station, deal.SupplyType,
                        deal.SupplyTypeAmount, deal.Price, deal.CountDiscount(), deal.CountFullPrice(), deal.Date); ;
                }
            });
        }

        public bool UpdateTable(Deal deal)
        {
            return DoFormAction(() =>
            {
                if (DealValidator.CheckUpdate(deal, out var errorList))
                {
                    Factory.GetDealRepository().UpdateDealTable(deal);
                    return true;
                }

                ErrorMessageBox.ShowCustomErrorMessage(errorList.Aggregate(string.Empty,
                    (current, error) => current + "Ошибка №" + errorList.IndexOf(error) + ": " + error + " \n"));

                return false;
            });
        }

        public bool AddToTable(Deal deal)
        {
            return DoFormAction(() =>
            {
                if (DealValidator.CheckAddition(deal, out var errorList))
                {
                    Factory.GetDealRepository().AddToDealTable(deal);
                    return true;
                }

                ErrorMessageBox.ShowCustomErrorMessage(errorList.Aggregate(string.Empty,
                    (current, error) => current + "Ошибка №" + errorList.IndexOf(error) + ": " + error + " \n"));

                return false;
            });
        }
    }
}
