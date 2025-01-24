using DobrinSerovControl.Model;
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

namespace DobrinSerovControl.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Report2Page2.xaml
    /// </summary>
    public partial class Report2Page2 : Page
    {
        public Report2Page2(Group group)
        {
            InitializeComponent();

            DataGr.ItemsSource = App.context.Journal.Where(x => x.IdGroup == group.ID).ToList();
        }

        private void PrintBtn_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
                printDialog.PrintVisual(DataGr, "Баллы");
        }
    }
}
