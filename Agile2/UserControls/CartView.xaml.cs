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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Agile2.Helpers;
using AgileData;

namespace Agile2.UserControls
{
    /// <summary>
    /// Interaction logic for CartView.xaml
    /// </summary>
    public partial class CartView : UserControl , ISwitchable
    {
        Transaction transaction = new Transaction();
        
        public CartView()
        {
            InitializeComponent();
        }

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        private void CartView_OnLoaded(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Confirmation_OnClick_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
