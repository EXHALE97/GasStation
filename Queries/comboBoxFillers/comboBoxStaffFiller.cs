using System.Collections.Generic;
using System.Windows.Forms;
using Queries.Interfaces;

namespace Queries.comboBoxFillers
{
    public class ComboBoxStaffFiller
    {
        private ComboBox cb;
        private List<string> comboBoxElements;
        private IRepositoryFactory factory;

        public ComboBoxStaffFiller(ComboBox cb, IRepositoryFactory factory)
        {
            this.cb = cb;
            this.factory = factory;
        }

        public void СbOrgFill()
        {
            comboBoxElements = factory.GetStationRepository().GetOrganizations();
            foreach (string st in comboBoxElements)
            {
                cb.Items.Add(st);
            }
        }

        public void СbStationFill(string Orgname)
        {
            comboBoxElements = factory.GetStationRepository().GetStationsAddress(Orgname);
            foreach (string st in comboBoxElements)
            {
                string cbString = RemoveSpaces(st);
                cb.Items.Add(cbString);
            }
        }

        private string RemoveSpaces(string inputString)
        {
            inputString = inputString.Trim().Replace(" ", string.Empty);

            return inputString;
        }
    }
}
