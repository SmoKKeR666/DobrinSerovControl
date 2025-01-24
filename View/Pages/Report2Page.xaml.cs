using DobrinSerovControl.AppData;
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
    /// Логика взаимодействия для Report2Page.xaml
    /// </summary>
    public partial class Report2Page : Page
    {
        public Report2Page()
        {
            InitializeComponent();

            SpecialCmb.SelectedValuePath = "ID";
            SpecialCmb.DisplayMemberPath = "Name";
            SpecialCmb.ItemsSource = App.context.Special.ToList();
        }

        private void MarkBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new Report2Page2((sender as Button).DataContext as Group));
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            int SelectedSpecial = Convert.ToInt32(SpecialCmb.SelectedValue);

            DataGr.ItemsSource = App.context.Group.Where(x => x.IdSpecial == SelectedSpecial).ToList();
        }
    }
}
