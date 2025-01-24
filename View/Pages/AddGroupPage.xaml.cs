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
    /// Логика взаимодействия для AddGroupPage.xaml
    /// </summary>
    public partial class AddGroupPage : Page
    {
        public AddGroupPage()
        {
            InitializeComponent();

            SpecialtyCmb.SelectedValuePath = "ID";
            SpecialtyCmb.DisplayMemberPath = "Name";
            SpecialtyCmb.ItemsSource = App.context.Special.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(GroupNameTxb.Text))
            {
                MessageBox.Show("Введите группу");
            }
            if (string.IsNullOrWhiteSpace(SpecialtyCmb.Text))
            {
                MessageBox.Show("Выберите специальность");
            }
            Group group = new Group()
            {
                Name = GroupNameTxb.Text,
                Special = SpecialtyCmb.SelectedItem as Special
            };

            App.context.Group.Add(group);
            App.context.SaveChanges();
            MessageBox.Show("Группа добавлена");

            GroupNameTxb.Text = "";
            SpecialtyCmb.Text = "";
        }
    }
}
