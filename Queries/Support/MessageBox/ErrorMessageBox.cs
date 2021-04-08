using System.Data.SqlClient;
using System.Windows.Forms;
using MessageBoxClass = System.Windows.Forms.MessageBox;

namespace Queries.Support.MessageBox
{
    public static class ErrorMessageBox
    {
        public static void ShowInvalidDataMessage()
        {
            MessageBoxClass.Show("Данные введены некорректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowSqlErrorMessage(SqlException exception)
        {
            MessageBoxClass.Show("Код ошибки: " + exception.State + "\n" + exception.Message, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowUnknownErrorMessage()
        {
            MessageBoxClass.Show("Неизвестная ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowCustomErrorMessage(string message)
        {
            MessageBoxClass.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}