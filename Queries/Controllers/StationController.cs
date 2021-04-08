using System.Linq;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Factory;
using Queries.Support.MessageBox;
using Queries.Support.Validators;

namespace Queries.Controllers
{
    public class StationController : BaseController
    {
        private readonly DataGridView stationsTable;

        public StationController(DataGridView stationsTable, IRepositoryFactory factory)
        {
            Factory = factory;
            this.stationsTable = stationsTable;
        }

        public void ShowTable()
        {
            DoFormAction(() =>
            {
                stationsTable.Rows.Clear();

                foreach (var station in Factory.GetStationRepository().GetStations())
                {
                    if (stationsTable.Columns.Count == 4)
                    {
                        stationsTable.Rows.Add(station.Name, station.City, station.Address, station.IsWorking.ToString());
                    }
                    else
                    {
                        stationsTable.Rows.Add(station.Id, station.Name, station.City, station.Address, station.IsWorking.ToString());
                    }
                }
            });
        }

        public void FindInTable(string country, string city)
        {
            DoFormAction(() =>
            {
                var stations = Factory.GetStationRepository().FindStations(country, city);
                stationsTable.Rows.Clear();
                foreach (var station in stations)
                {
                    stationsTable.Rows.Add(station.Name, station.City, station.Address);
                }
            });
        }

        public bool AddToTable(Station station)
        {
            return DoFormAction(() =>
            {
                if (StationValidator.CheckAddition(station, out var errorList))
                {
                    Factory.GetStationRepository().AddToStationTable(station);
                    return true;
                }

                ErrorMessageBox.ShowCustomErrorMessage(errorList.Aggregate(string.Empty,
                    (current, error) => current + "Ошибка №" + errorList.IndexOf(error) + ": " + error + " \n"));

                return false;
            });
        }
    }
}
