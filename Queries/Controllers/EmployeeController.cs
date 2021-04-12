using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Factory;
using Queries.Support.MessageBox;
using Queries.Support.Validators;

namespace Queries.Controllers
{
    public class EmployeeController : BaseController
    {
        private readonly DataGridView dataGridView;
        private List<string> errorList;

        public EmployeeController(DataGridView dataGridView, IRepositoryFactory factory)
        {
            Factory = factory;
            this.dataGridView = dataGridView;
        }

        public void ShowTable(bool workingOnly)
        {
            DoFormAction(() =>
            {
                dataGridView.Rows.Clear();
                foreach(var employee in Factory.GetStaffRepository().GetEmployees(workingOnly))
                {
                    dataGridView.Rows.Add(employee.Id, employee.CredId, employee.SurName, employee.Name,
                        employee.MiddleName, employee.Birthday, employee.EmploymentDate, employee.ContractEndDate,
                        employee.Position, employee.Salary, employee.Address, employee.Phone, employee.IsWorking);
                }
            });
        }

        public bool AddToTable(Employee employee)
        {
            return DoFormAction(() =>
            {
                if (EmployeeValidator.CheckAddition(employee, out errorList))
                {
                    Factory.GetStaffRepository().AddToEmployeeTable(employee);
                    return true;
                }

                ErrorMessageBox.ShowCustomErrorMessage(errorList.Aggregate(string.Empty,
                    (current, error) => current + "Ошибка №" + errorList.IndexOf(error) + ": " + error + " \n"));

                return false;
            });
        }

        public bool UpdateTable(int id, Employee wk)
        {
            return DoFormAction(() =>
            {
                if (EmployeeValidator.CheckUpdate(id, wk, out errorList))
                {
                    Factory.GetStaffRepository().UpdateEmployeeTable(id, wk);
                }

                ErrorMessageBox.ShowCustomErrorMessage(errorList.Aggregate(string.Empty,
                    (current, error) => current + "Ошибка №" + errorList.IndexOf(error) + ": " + error + " \n"));

                return false;
            });
        }

        public bool DeleteFromTable(int id)
        {
            return DoFormAction(() =>
            {
                if (!EmployeeValidator.CheckDelete(id, out errorList))
                {
                    Factory.GetStaffRepository().DeleteFromEmployeeTable(id);
                }

                ErrorMessageBox.ShowCustomErrorMessage(errorList.Aggregate(string.Empty,
                    (current, error) => current + "Ошибка №" + errorList.IndexOf(error) + ": " + error + " \n"));

                return false;
            });
        }
    }
}
