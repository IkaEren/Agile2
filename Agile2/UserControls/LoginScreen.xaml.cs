using System;
using System.Configuration;
using System.Linq;
using System.Security;
using System.Windows;
using System.Windows.Controls;
using Agile2.Helpers;
using AgileData;

namespace Agile2.UserControls
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : UserControl, ISwitchable
    {
        private readonly AgileDbContext _context = new AgileDbContext();
        private string _loginEmail;
        private SecureString _securePassword;
        private Member _loginMember;

        public LoginScreen()
        {
            InitializeComponent();
        }

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Member loggingInMember = _context.Members.SingleOrDefault(m => m.Email == TxtUsername.Text);
                if (loggingInMember == null)
                {
                    throw new NullReferenceException();
                }

                PageSwitcher switcher = new PageSwitcher(loggingInMember);
            }
            catch (Exception ex) when (ex is NullReferenceException)
            {
                MessageBox.Show("Username or password is wrong.");
            }
        }
}
}