using MessageBoxClass = System.Windows.Forms.MessageBox;

namespace Queries.Support.MessageBox
{
    public static class SuccessMessageBox
    {
        public static void ShowSuccessBox()
        {
            MessageBoxClass.Show("Операция выполнена успешно!");
        }
    }
}