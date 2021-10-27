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

namespace Work_With_SQL_Server
{
    /// <summary>
    /// Логика взаимодействия для FormСreatingRecord.xaml
    /// </summary>
    public partial class FormСreatingRecord : Window
    {
        UniversityEntities db = UniversityEntities.GetContext();
        public FormСreatingRecord()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            Pract_18 str = new Pract_18();
            str.Surname = name1.Text;
            str.Name = name2.Text;
            str.Patronymic = name3.Text;
            str.NumberReportBook = number.Text;
            str.Like1 = like1.IsChecked;
            str.Like2 = like2.IsChecked;
            str.Like3 = like3.IsChecked;
            str.Like4 = like4.IsChecked;
            str.Like5 = like5.IsChecked;
            str.LiveInHostel = (bool)live.IsChecked;
            db.Pract_18.Add(str);
            db.SaveChanges();
            this.Close();
        }
    }
}
