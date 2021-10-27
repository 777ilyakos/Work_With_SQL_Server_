using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Work_With_SQL_Server
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UniversityEntities db = UniversityEntities.GetContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db.Pract_18.Load();
            DataGrid1.ItemsSource = db.Pract_18.Local.ToBindingList();
        }

        private void СreatingRecord_Click(object sender, RoutedEventArgs e)
        {
            FormСreatingRecord form = new FormСreatingRecord();
            form.ShowDialog();
        }
    }
}