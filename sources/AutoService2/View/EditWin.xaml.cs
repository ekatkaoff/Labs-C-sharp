using AutoService2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AutoService2.View
{
    /// <summary>
    /// Логика взаимодействия для EditWin.xaml
    /// </summary>
    public partial class EditWin : Window
    {
        public Items item { get; set; }
        public EditWin(Items selectItem)
        {
            InitializeComponent();
            item = selectItem;

            FText.Text = selectItem.FIO.F;
            IText.Text = selectItem.FIO.I;
            OText.Text = selectItem.FIO.O;
            PhoneText.Text = selectItem.Phone;
            ModelText.Text = selectItem.Model;
            DescriptionText.Text = selectItem.Description;
            BoxState.SelectedIndex = ((int)selectItem.State);
            BoxTypeCar.SelectedIndex = ((int)selectItem.Type);
            BoxTypeCar.ItemsSource = Enum.GetValues(typeof(TypeCar)).Cast<TypeCar>();
            BoxState.ItemsSource = Enum.GetValues(typeof(State)).Cast<State>();
        }

        ///<summary>
        /// Обработка сохранения
        ///</summary>
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (item != null)
            {
                item.DateAdd = DateTime.Now;
                item.Type = (TypeCar)BoxTypeCar.SelectedItem;
                item.Model = ModelText.Text;
                item.FIO = new FIO(FText.Text, IText.Text, OText.Text);
                item.Phone = PhoneText.Text;
                item.Description = DescriptionText.Text;
                item.State = (State)BoxState.SelectedItem;

                this.DialogResult = true;
            }
            else
            {
                MessageBox.Show("Элемент не найден!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        ///<summary>
        /// Обработка закрытия
        ///</summary>
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
