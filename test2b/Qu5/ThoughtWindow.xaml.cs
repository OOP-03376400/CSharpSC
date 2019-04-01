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

namespace Qu5
{
    /// <summary>
    /// Interaction logic for ThoughtWindow.xaml
    /// </summary>
    public partial class ThoughtWindow : Window
    {
        public ThoughtWindow()
        {
            InitializeComponent();
        }
        private void SaveThoughtbtn_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new ThoughtEntities())
            {
                db.Thoughts.Add(new Thought { Id = 0, Thought1 = ThoughtVal.Text });
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
    }
}
