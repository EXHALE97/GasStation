using System.Collections.Generic;
using System.Linq;
using Queries.Entities;
using Queries.Factory;
using Queries.Support.MessageBox;
using Queries.Support.Validators;

namespace Queries.Controllers
{
    public class CredentialsController : BaseController
    {
        private readonly IRepositoryFactory factory;
        private List<string> errorList;

        public CredentialsController(IRepositoryFactory factory)
        {
            this.factory = factory;
        }

        public string TryLogin(Credentials credentials)
        {
            return factory.GetCredentialsRepository().GetRoleByCredentials(credentials);
        }

        public bool AddToLoginTable(Credentials dbUser)
        {
            return DoFormAction(() =>
            {
                if (CredentialsValidator.CheckAddition(dbUser, out errorList))
                {
                    factory.GetCredentialsRepository().AddNewCredentials(dbUser);
                    return true;
                }

                ErrorMessageBox.ShowCustomErrorMessage(errorList.Aggregate(string.Empty,
                    (current, error) => current + "Ошибка №" + errorList.IndexOf(error) + ": " + error + " \n"));

                return false;
            });
        }
    }
}
