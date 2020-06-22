using System.Windows.Controls;

namespace LeagueOfLegendsLogin.Windows
{
    /// <summary>
    /// Logika interakcji dla klasy UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        ViewModelMatches modelMatches;
        public UserControl1()
        {
            InitializeComponent();
            modelMatches = new ViewModelMatches();
            DataContext = modelMatches;
        }
    }
}
