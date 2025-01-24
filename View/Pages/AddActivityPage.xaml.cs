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
    /// Логика взаимодействия для AddActivityPage.xaml
    /// </summary>
    public partial class AddActivityPage : Page
    {
        public AddActivityPage()
        {
            InitializeComponent();

            EventTypeCmb.SelectedValuePath = "ID";
            EventTypeCmb.DisplayMemberPath = "Name";
            EventTypeCmb.ItemsSource = App.context.Activity.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EventNameTxb.Text))
            {
                MessageBox.Show("Введите соревнование");
            }
            if (string.IsNullOrWhiteSpace(EventTypeCmb.Text))
            {
                MessageBox.Show("Выберите вид соревнования");
            }
            Activity activity = new Activity()
            {
                Name = EventNameTxb.Text,
                Directions = EventTypeCmb.SelectedItem as Directions
            };

            App.context.Activity.Add(activity);
            App.context.SaveChanges();
            MessageBox.Show("Активность добавлена");

            EventNameTxb.Text = "";
            EventTypeCmb.Text = "";
        }
    }
}
