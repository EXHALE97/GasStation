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

        public void ShowTable(bool workingOnly)
        {
            DoFormAction(() =>
            {
                stationsTable.Rows.Clear();

                foreach (var station in Factory.GetStationRepository().GetStations(workingOnly))
                {
                    switch (stationsTable.Columns.Count)
                    {
                        case 3:
                            stationsTable.Rows.Add(station.Name, station.City, station.Address);
                            break;
                        case 4:
                            stationsTable.Rows.Add(station.Name, station.City, station.Address, station.IsWorking.ToString());
                            break;
                        default:
                            stationsTable.Rows.Add(station.Id, station.Name, station.City, station.Address, station.IsWorking.ToString());
                            break;
                    }
                }
            });
        }

        public void ShowStationsByCity(string city)
        {
            DoFormAction(() =>
            {
                var stations = Factory.GetStationRepository().GetStationsByCity(city);
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
                if (StationValidator.CheckFields(station, out var errorList))
                {
                    Factory.GetStationRepository().AddToStationTable(station);
                    return true;
                }

                ErrorMessageBox.ShowCustomErrorMessage(errorList.Aggregate(string.Empty,
                    (current, error) => current + "Ошибка №" + errorList.IndexOf(error) + ": " + error + " \n"));

                return false;
            });
        }

        public bool UpdateStation(Station station)
        {
            return DoFormAction(() =>
            {
                if (StationValidator.CheckFields(station, out var errorList))
                {
                    Factory.GetStationRepository().UpdateStation(station);
                    return true;
                }

                ErrorMessageBox.ShowCustomErrorMessage(errorList.Aggregate(string.Empty,
                    (current, error) => current + "Ошибка №" + errorList.IndexOf(error) + ": " + error + " \n"));

                return false;
            });
        }
    }
}
