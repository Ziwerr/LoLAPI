using RiotSharp.Misc;
using System;
using System.Windows;
using System.Windows.Input;

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
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
            this.DragMove();
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

        private void DockPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

    }
}
