using DobrinSerovControl.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DobrinSerovControl
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static DobrinSerovControl8Entities context = new DobrinSerovControl8Entities();
    }
}
