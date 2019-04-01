using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            string connectionString =
                "Data Source=.\\SQLEXPRESS01;Initial Catalog=ProductDB;"
                + "Integrated Security=true";

            string queryString =
                "SELECT * FROM dbo.Products";

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                using (var DTProducts = new DataTable())
                {
                    DTProducts.Load(command.ExecuteReader());
                    dataList.ItemsSource = DTProducts.DefaultView;
                }
                connection.Close();             
            }
        }
    }
}
