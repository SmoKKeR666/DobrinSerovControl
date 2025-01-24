using DobrinSerovControl.AppData;
using DobrinSerovControl.View.Pages;
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

namespace DobrinSerovControl
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ClassFrame.mainFrame = MenuFrame;
            ClassFrame.mainFrame.Navigate(new MenuPage());

            ClassFrame.mainFrame = FunctionalFrame;
            ClassFrame.mainFrame.Navigate(new ImagePage());
        }
    }
}
