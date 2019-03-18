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

namespace Qu3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>
        {
            new Student
            {
                firstName = "Bill",
                lastName = "phil",
                age = 55
            },
            new Student
            {
                firstName = "Jill",
                lastName = "phil",
                age = 51
            }
        };
        public MainWindow()
        {
            InitializeComponent();
            Combo.ItemsSource = students;
        }
    }
}
