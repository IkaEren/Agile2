﻿using System;
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

namespace Agile2.UserControls
{
    /// <summary>
    /// Interaction logic for ChooseBookingView.xaml
    /// </summary>
    public partial class ChooseBookingView : UserControl , ISwitchable
    {
        public ChooseBookingView()
        {
            InitializeComponent();
        }

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }
    }
}