using System.Linq;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Factory;
using Queries.Support.MessageBox;
using Queries.Support.Validators;

namespace Queries.Controllers
{
    public class SupplyTypeController : BaseController
    {
        private readonly DataGridView table;

        public SupplyTypeController(DataGridView table, IRepositoryFactory factory)
        {
            Factory = factory;
            this.table = table;
        }

        public void ShowTable()
        {
            DoFormAction(() =>
            {
                table.Rows.Clear();
                foreach (var supplyType in Factory.GetSupplyTypeRepository().GetSupplyTypes())
                {
                    table.Rows.Add(supplyType.Id, supplyType.Name, supplyType.Price, supplyType.IsSelling);
                }
            });
        }

        public bool AddSupplyType(SupplyType supplyType)
        {
            return DoFormAction(() =>
            {
                if (SupplyTypeValidator.CheckFields(supplyType, out var errorList))
                {
                    Factory.GetSupplyTypeRepository().AddSupplyType(supplyType);
                    return true;
                }

                ErrorMessageBox.ShowCustomErrorMessage(errorList.Aggregate(string.Empty,
                    (current, error) => current + "Ошибка №" + errorList.IndexOf(error) + ": " + error + " \n"));

                return false;
            });
        }

        public bool UpdateSupplyType(SupplyType supplyType)
        {
            return DoFormAction(() =>
            {
                if (SupplyTypeValidator.CheckFields(supplyType, out var errorList))
                {
                    Factory.GetSupplyTypeRepository().UpdateSupplyType(supplyType);
                    return true;
                }

                ErrorMessageBox.ShowCustomErrorMessage(errorList.Aggregate(string.Empty,
                    (current, error) => current + "Ошибка №" + errorList.IndexOf(error) + ": " + error + " \n"));

                return false;
            });
        }

        public bool DeleteCurrentRowFromTable(int id)
        {
            return DoFormAction(() =>
            {
                if (SupplyTypeValidator.CheckDelete(id, out var errorList))
                {
                    Factory.GetSupplyTypeRepository().DeleteSupplyType(id);
                    return true;
                }

                ErrorMessageBox.ShowCustomErrorMessage(errorList.Aggregate(string.Empty,
                    (current, error) => current + "Ошибка №" + errorList.IndexOf(error) + ": " + error + " \n"));

                return false;
            });
        }
    }
}