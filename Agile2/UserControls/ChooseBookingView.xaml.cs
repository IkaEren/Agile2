using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Interaction logic for ChooseBookingView.xaml
    /// </summary>
    public partial class ChooseBookingView : UserControl , ISwitchable
    {
        protected Facility selectedBooking;
        private readonly AgileDbContext _context = new AgileDbContext();
        private List<Booking> bookings = new List<Booking>();
        List<Booking> cfmBookings = new List<Booking>();

        public ChooseBookingView()
        {
            InitializeComponent();
        }

        public void UtilizeState(object state)
        {
            Booking selection = state as Booking;
            selectedBooking = selection.Facility;

            for (int i = 0; i <= 15; i++)
            {
                bookings.Add(new Booking() { Facility = selection.Facility, BookingTime = selection.BookingTime.AddHours(7 + i) });
            }

            BookableList.ItemsSource = bookings;
        }

        private void BookableList_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // not implemented 
            
            //cfmBookings.Add((Booking)BookableList.SelectedItem); 
        }

        private void Confirm_OnClick(object sender, RoutedEventArgs e)
        {
            //foreach (var bookings in bookings)
            //{
            //    foreach (var timings in cfmBookings)
            //    {
            //        if (bookings.BookingTime == timings.BookingTime)
            //        {
            //            using (_context)
            //            {
            //                _context.Bookings.Add(bookings);
            //                _context.SaveChanges();
            //            }
            //        }
            //    }
            //}
            var state = BookableList.SelectedItems;
            Switcher.Switch(new CartView(), state);
        }
    }
}
