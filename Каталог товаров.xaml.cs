using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace pract
{
    /// <summary>
    /// Логика взаимодействия для Каталог_товаров.xaml
    /// </summary>
    public partial class Каталог_товаров : Window
    {
        public Каталог_товаров()
        {
            InitializeComponent();
            var abc = new AppDbContext();
            LViewTours.ItemsSource = abc.Tovars.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Магазин_товаров_для_кухни_и_кулинарии маг = new Магазин_товаров_для_кухни_и_кулинарии();
            маг.Show();
            this.Hide();
        }
    }
}
