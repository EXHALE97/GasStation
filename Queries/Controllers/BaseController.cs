using System;
using System.Data.SqlClient;
using Queries.Factory;
using Queries.Support.MessageBox;

namespace Queries.Controllers
{
    public abstract class BaseController
    {
        protected IRepositoryFactory Factory;

        protected T DoFormAction<T>(Func<T> action)
        {
            try
            {
                return action();
            }
            catch (SqlException e)
            {
                ErrorMessageBox.ShowSqlErrorMessage(e);
            }
            catch (Exception)
            {
                ErrorMessageBox.ShowUnknownErrorMessage();
            }

            return default(T);
        }

        protected void DoFormAction(Action action)
        {
            try
            {
                action();
            }
            catch (SqlException e)
            {
                ErrorMessageBox.ShowSqlErrorMessage(e);
            }
            catch (Exception)
            {
                ErrorMessageBox.ShowUnknownErrorMessage();
            }
        }
    }
}