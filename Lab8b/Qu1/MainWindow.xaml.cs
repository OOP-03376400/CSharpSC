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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Qu1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using (var DB = new ProductDBEntities())
            {
                var LProducts = (from P in DB.Products
                                 orderby P.UnitPrice ascending
                                 select new { P.ProductID, P.UnitPrice, P.ProductName }).ToList();
                dataList.ItemsSource = LProducts;
            }
            
        }
    }
}
