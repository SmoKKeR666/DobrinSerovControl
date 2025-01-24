using DobrinSerovControl.AppData;
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
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void AddGroupBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new AddGroupPage());
        }

        private void AddActivityBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new AddActivityPage());
        }

        private void AccountingBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new AccountingPage());
        }

        private void Report1Btn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new Report1Page());
        }

        private void Report2Btn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new Report2Page());
        }
    }
}
