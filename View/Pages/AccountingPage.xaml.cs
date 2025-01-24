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
    /// Логика взаимодействия для AccountingPage.xaml
    /// </summary>
    public partial class AccountingPage : Page
    {
        public AccountingPage()
        {
            InitializeComponent();

            SpecialtyCmb.SelectedValuePath = "ID";
            SpecialtyCmb.DisplayMemberPath = "Name";
            SpecialtyCmb.ItemsSource = App.context.Special.ToList();

            CompetitionStatusCmb.SelectedValuePath = "ID";
            CompetitionStatusCmb.DisplayMemberPath = "Name";
            CompetitionStatusCmb.ItemsSource = App.context.Directions.ToList();

            GroupCmb.SelectedValuePath = "ID";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.Group.ToList();

            CompetitionCmb.SelectedValuePath = "ID";
            CompetitionCmb.DisplayMemberPath = "Name";
            CompetitionCmb.ItemsSource = App.context.Activity.ToList();
        }

        private void DatGr_Loaded(object sender, RoutedEventArgs e)
        {
            DatGr.ItemsSource = App.context.Journal.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(DatePick.Text))
            {
                mes += "Выберите дату\n";
            }
            if (string.IsNullOrWhiteSpace(SpecialtyCmb.Text))
            {
                mes += "Выберите специальность\n";
            }
            if (string.IsNullOrWhiteSpace(CompetitionStatusCmb.Text))
            {
                mes += "Выберите статус соревнования\n";
            }
            if (string.IsNullOrWhiteSpace(GroupCmb.Text))
            {
                mes += "Выберите группу\n";
            }
            if (string.IsNullOrWhiteSpace(CompetitionCmb.Text))
            {
                mes += "Выберите соревнование\n";
            }
            if (string.IsNullOrWhiteSpace(ScoreTxb.Text))
            {
                mes += "Введите баллы\n";
            }
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Journal journal = new Journal()
            {
                DateEvent = (DateTime)DatePick.SelectedDate,
                Group = GroupCmb.SelectedItem as Group,
                Activity = CompetitionCmb.SelectedItem as Activity,
                Mark = Convert.ToInt32(ScoreTxb.Text)
            };

            App.context.Journal.Add(journal);
            App.context.SaveChanges();
            MessageBox.Show("Баллы добавлены");
            DatGr.ItemsSource = App.context.Journal.ToList();

            DatePick.Text = "";
            SpecialtyCmb.Text = "";
            CompetitionStatusCmb.Text = "";
            GroupCmb.Text = "";
            CompetitionCmb.Text = "";
            ScoreTxb.Text = "";
        }
    }
}
