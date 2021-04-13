using Queries.Factory;

namespace Queries.Support.ComboBox
{
    public static class ComboBoxFiller
    {
        private static IRepositoryFactory _factory;

        public static void FillCredsComboBox(System.Windows.Forms.ComboBox comboBox)
        {
            comboBox.Items.Add("-");
            foreach (var item in _factory.GetCredentialsRepository().GetUserLogins())
            {
                comboBox.Items.Add(item);
            }
        }
    }
}
