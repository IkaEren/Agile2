using System;
using System.Windows;
using System.Windows.Controls;
using Agile2.Helpers;
using Agile2.UserControls;
using AgileData;

namespace Agile2
{
    /// <summary>
    /// Interaction logic for PageSwitcher.xaml
    /// </summary>
    public partial class PageSwitcher : Window
    {
        public Member LoggedInMember { get; set; }
        public Transaction BuyedSt00f { get; } = new Transaction();

        public PageSwitcher(Member loggedInMember)
        {
            InitializeComponent();
            LoggedInMember = LoggedInMember;
            Switcher.pageSwitcher = this;
            Switcher.Switch(new LoginScreen());
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        public void Navigate(UserControl nextPage, object state)
        {
            this.Content = nextPage;
            ISwitchable s = nextPage as ISwitchable;

            if (s != null)
                s.UtilizeState(state);
            else
                throw new ArgumentException("NextPage is not ISwitchable! "
                  + nextPage.Name.ToString());
        }
    }
}
