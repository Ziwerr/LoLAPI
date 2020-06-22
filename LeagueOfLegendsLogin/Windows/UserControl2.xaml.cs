using System.Windows.Controls;

namespace LeagueOfLegendsLogin.Windows
{
    /// <summary>
    /// Logika interakcji dla klasy UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        ViewModelLeaderBoard modelLeaderBoard;

        public UserControl2()
        {
            modelLeaderBoard = new ViewModelLeaderBoard();
            InitializeComponent();
            DataContext = modelLeaderBoard;
        }

    }
}
