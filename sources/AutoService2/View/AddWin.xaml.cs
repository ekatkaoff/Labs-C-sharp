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
    /// Логика взаимодействия для AddWin.xaml
    /// </summary>
    public partial class AddWin : Window
    {
        public Items item { get; set; }
        public AddWin()
        {
            InitializeComponent();
            BoxTypeCar.ItemsSource = Enum.GetValues(typeof(TypeCar)).Cast<TypeCar>();
        }

        ///<summary>
        /// Обработка сохранения
        ///</summary>
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            item = new Items()
            {
                DateAdd = DateTime.Now,
                Type = (TypeCar)BoxTypeCar.SelectedItem,
                Model = ModelText.Text,
                FIO = new FIO(FText.Text, IText.Text, OText.Text),
                Phone = PhoneText.Text,
                Description = DescriptionText.Text,
                State = State.New,
                
            };
            this.DialogResult = true;
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
