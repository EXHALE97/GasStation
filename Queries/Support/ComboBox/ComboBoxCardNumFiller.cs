using System.Collections.Generic;
using Queries.Factory;

namespace Queries.Support.ComboBox
{
    public class ComboBoxCardNumFiller
    {
        private readonly System.Windows.Forms.ComboBox comboBox;
        private List<string> comboBoxElements;
        private readonly IRepositoryFactory factory;

        public ComboBoxCardNumFiller(System.Windows.Forms.ComboBox comboBox, IRepositoryFactory factory)
        {
            this.comboBox = comboBox;
            this.factory = factory;
        }

        public void CbCardNumFill()
        {
            comboBoxElements = factory.GetCarRepository().GetCardNumList();
            foreach (var st in comboBoxElements)
            {
                comboBox.Items.Add(st);
            }
        }
    }
}
