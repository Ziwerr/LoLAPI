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
using System.Windows.Shapes;

namespace LeagueOfLegendsLogin.Windows
{
    /// <summary>
    /// Logika interakcji dla klasy WindowSummoner.xaml
    /// </summary>
    public partial class WindowSummoner : Window
    {
        ControllerSummoner controllerSummoner;
        public WindowSummoner()
        {
            InitializeComponent();
            controllerSummoner = new ControllerSummoner();
            DataContext = controllerSummoner.GetContextFromSummoner();
        }

        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {
            controllerSummoner.OpenMain();
            this.Close();
        }
    }
}
