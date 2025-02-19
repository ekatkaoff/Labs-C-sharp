using AutoService2.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Documents.DocumentStructures;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AutoService2.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Items SelectedItem { get; set; }

        public ObservableCollection<Items> items {  get; set; } = new ObservableCollection<Items>();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        ///<summary>
        /// Обработка добавления заявки
        ///</summary>
        private void AddItems_Click(object sender, RoutedEventArgs e)
        {
            AddWin addWin = new AddWin();
            if (addWin.ShowDialog() == true)
            {
                if (addWin.item != null)
                {
                    items.Add(addWin.item);
                }
            }

        }
        ///<summary>
        /// Обработка редактирования заявки
        ///</summary>
        private void EditItems_Click(object sender, RoutedEventArgs e)
        {
            if(SelectedItem !=  null)
            {
                EditWin editWin = new(SelectedItem);
                if (editWin.ShowDialog() == true)
                {
                    if (editWin.item != null)
                    {
                        var temp = items.FirstOrDefault(q => q.id == SelectedItem.id);

                        if (temp != null) 
                        { 
                            int index = items.IndexOf(temp);
                            items[index] = editWin.item;
                            ItemsGrid.ItemsSource = null;
                            ItemsGrid.ItemsSource = items;
                        }
                    }
                }    
            }
        }

        private void DeleteItems_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchItems_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
