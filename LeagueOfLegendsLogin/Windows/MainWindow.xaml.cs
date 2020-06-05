using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LeagueOfLegendsLogin.Windows
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller controller;
        ViewModel viewModel;
        public MainWindow()
        {
            controller = new Controller();
            viewModel = new ViewModel();
            InitializeComponent();
            DataContext = viewModel;
        }

        private void btn_Search_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(viewModel.Region))
                return;
            if (string.IsNullOrEmpty(viewModel.SummonerName))
                return;

            if(controller.GetSummoner(viewModel.SummonerName))
            {
                WindowSummoner windowSummoner = new WindowSummoner();
                windowSummoner.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Not Found");
            }
        }
    }
}
