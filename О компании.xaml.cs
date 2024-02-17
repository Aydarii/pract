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

namespace pract
{
    /// <summary>
    /// Логика взаимодействия для О_компании.xaml
    /// </summary>
    public partial class О_компании : Window
    {
        public О_компании()
        {
            InitializeComponent();
        }

        private void o_kompanyy(object sender, RoutedEventArgs e)
        {
            Магазин_товаров_для_кухни_и_кулинарии маг = new Магазин_товаров_для_кухни_и_кулинарии();
            маг.Show();
            Hide();
        }
    }
}
