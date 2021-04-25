using System.Windows.Forms;
using Queries.Factory;

namespace Queries.Support.Backup
{
    public class BackupTool
    {
        private readonly IRepositoryFactory factory;

        public BackupTool(IRepositoryFactory factory)
        {
            this.factory = factory;
        }

        public void CreateBackup()
        {
            var saveFileDialog = new SaveFileDialog { Filter = "Backup Files(*.bak; *.trn)|*.bak", DefaultExt = "bak", FileName = "gas_station.bak" };
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            factory.GetDatabaseRepository().CreateBackup(saveFileDialog.FileName);
        }

        public void RestoreBackup()
        {
            var openFileDialog = new OpenFileDialog { Filter = "Backup Files(*.bak; *.trn)|*.bak", DefaultExt = "bak" };
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            factory.GetDatabaseRepository().RestoreBackup(openFileDialog.FileName);
        }
    }
}