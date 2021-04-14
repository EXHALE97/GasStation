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

        public EmployeeController(IRepositoryFactory factory)
        {
            Factory = factory;
        }

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
                foreach(var employee in Factory.GetEmployeeRepository().GetEmployees(workingOnly))
                {
                    dataGridView.Rows.Add(employee.Id, employee.CredId == 0 ? "-" : employee.CredId.ToString(), employee.SurName,
                        employee.Name, employee.MiddleName ?? "-", employee.Birthday, employee.EmploymentDate, employee.ContractEndDate,
                        employee.Position, employee.Salary, employee.Address, employee.Phone, employee.IsWorking);
                }
            });
        }

        public bool AddToTable(Employee employee)
        {
            return DoFormAction(() =>
            {
                if (EmployeeValidator.CheckEmployee(employee, out errorList))
                {
                    Factory.GetEmployeeRepository().AddToEmployeeTable(employee);
                    return true;
                }

                ErrorMessageBox.ShowCustomErrorMessage(errorList.Aggregate(string.Empty,
                    (current, error) => current + "Ошибка №" + errorList.IndexOf(error) + ": " + error + " \n"));

                return false;
            });
        }

        public bool UpdateTable(int id, Employee employee)
        {
            return DoFormAction(() =>
            {
                if (EmployeeValidator.CheckEmployee(employee, out errorList))
                {
                    Factory.GetEmployeeRepository().UpdateEmployeeTable(id, employee);
                    return true;
                }

                ErrorMessageBox.ShowCustomErrorMessage(errorList.Aggregate(string.Empty,
                    (current, error) => current + "Ошибка №" + errorList.IndexOf(error) + ": " + error + " \n"));

                return false;
            });
        }

        public bool SetEmployeeCredentials(int employeeId, Credentials credentials)
        {
            return DoFormAction(() =>
            {
                if (CredentialsValidator.CheckAddition(credentials, out errorList))
                {
                    Factory.GetEmployeeRepository().SetEmployeeCredentials(employeeId, credentials);
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
                if (EmployeeValidator.CheckDelete(id, out errorList))
                {
                    Factory.GetEmployeeRepository().DeleteFromEmployeeTable(id);
                    return true;
                }

                ErrorMessageBox.ShowCustomErrorMessage(errorList.Aggregate(string.Empty,
                    (current, error) => current + "Ошибка №" + errorList.IndexOf(error) + ": " + error + " \n"));

                return false;
            });
        }

        public void FillCredentialsLoginsComboBox(ComboBox comboBox, int credId = 0)
        {
            comboBox.Items.Add("-");
            foreach (var item in Factory.GetCredentialsRepository().GetUserLogins())
            {
                comboBox.Items.Add(item);
            }
            comboBox.SelectedItem = credId == 0 ? "-" : Factory.GetCredentialsRepository().GetCredentialsLoginById(credId);
        }
    }
}
