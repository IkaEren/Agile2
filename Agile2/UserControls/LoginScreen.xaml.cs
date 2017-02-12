using System;
using System.Windows.Controls;
using Agile2.Helpers;

namespace Agile2.UserControls
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : UserControl, ISwitchable
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }
    }
}
