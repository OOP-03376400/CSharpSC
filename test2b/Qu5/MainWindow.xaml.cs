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
using System.Configuration;

namespace Qu5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();           
        }

        private void SaveThoughtbtn_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new ThoughtEntities())
            {               
                db.Thoughts.Add(new Thought { Id = 0, Thought1 = ThoughtVal.Text});
                // This doesn't work because my Id field won't increment properly
                db.SaveChanges();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var DB = new ThoughtEntities())
            {
                var thoughts = (from t in DB.Thoughts
                                 orderby t.Id ascending
                                 select new { t.Id, t.Thought1 }).ToList();
                ThoughtList.ItemsSource = thoughts;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (passBox.Password == ConfigurationManager.AppSettings["Password"])
                signinLabel.Content = "Sign In Successful";
            else
                signinLabel.Content = "Sign In Not Successful";
        }
    }
}
