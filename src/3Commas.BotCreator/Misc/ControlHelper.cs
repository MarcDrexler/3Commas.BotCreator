using System;
using System.Windows.Forms;

namespace _3Commas.BotCreator.Misc
{
    public static class ControlHelper
    {
        public static void AddValuesToCombobox<TEnum>(ComboBox comboBox, TEnum defaultValue)
        {
            AddValuesToCombobox<TEnum>(comboBox);
            comboBox.Text = defaultValue.ToString();
        }

        public static void AddValuesToCombobox<TEnum>(ComboBox comboBox)
        {
            comboBox.DataSource = (TEnum[])Enum.GetValues(typeof(TEnum));
        }
    }
}
