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
    /// Логика взаимодействия для Report1Page.xaml
    /// </summary>
    public partial class Report1Page : Page
    {
        public Report1Page()
        {
            InitializeComponent();

            TeamCmb.SelectedValuePath = "ID";
            TeamCmb.DisplayMemberPath = "Name";
            TeamCmb.ItemsSource = App.context.Group.ToList();
        }

        private void DatGr_Loaded(object sender, RoutedEventArgs e)
        {
            DatGr.ItemsSource = App.context.Journal.ToList();
        }

        private void ChooseBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(DateStart.Text))
            {
                mes += "Выберите дату начала\n";
            }
            if (string.IsNullOrWhiteSpace(DateEnd.Text))
            {
                mes += "Выберите дату окончания\n";
            }
            if (string.IsNullOrWhiteSpace(TeamCmb.Text))
            {
                mes += "Выберите команду\n";
            }
            if (string.IsNullOrWhiteSpace(PerformanceTxb.Text))
            {
                mes += "Введите количество выст уплений\n";
            }
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            int select = Convert.ToInt32(TeamCmb.SelectedValue);
            var dateStart = (DateTime)DateStart.SelectedDate;
            var dateEnd = (DateTime)DateEnd.SelectedDate;

            var countGame = App.context.Journal.Where(x => x.IdGroup == select).Count();
            PerformanceTxb.Text = Convert.ToString(countGame);

            DatGr.ItemsSource = App.context.Journal.Where(x => x.IdGroup == select).Select(y => y.DateEvent >= dateStart && y.DateEvent <= dateEnd).ToList();
        }
    }
}
