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
        ViewModelSummoner modelSummoner;
        public WindowSummoner()
        {
            InitializeComponent();
            modelSummoner = new ViewModelSummoner();
            DataContext = modelSummoner;
        }
        public void OpenMain()
        {
            MainWindow profile = new MainWindow();
            profile.Show();
        }

        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {
            OpenMain();
            Close();
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_Minimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btn_Website_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://leagueoflegends.com");
        }

        private void btn_Historia_Click(object sender, RoutedEventArgs e)
        {
            UserHistory.Visibility = System.Windows.Visibility.Visible;
            UserLeaderBoard.Visibility = System.Windows.Visibility.Hidden;
            btn_Historia.BorderBrush = new SolidColorBrush(Colors.Orange);
            btn_Historia.BorderThickness = new Thickness(2);
            btn_Ranking.BorderBrush = null;

        }

        private void btn_Ranking_Click(object sender, RoutedEventArgs e)
        {
            UserHistory.Visibility = System.Windows.Visibility.Hidden;
            UserLeaderBoard.Visibility = System.Windows.Visibility.Visible;
            btn_Historia.BorderBrush = null;
            btn_Ranking.BorderBrush = new SolidColorBrush(Colors.Orange);
            btn_Ranking.BorderThickness = new Thickness(2);

        }
        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
