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
    /// Interaction logic for SearchFacilityScreen.xaml
    /// </summary>
    public partial class SearchFacilityScreen : UserControl, ISwitchable
    {
        private readonly AgileDbContext _context = new AgileDbContext();
        public static DateTime EndDate => DateTime.Today.AddDays(7);
                    
        public SearchFacilityScreen()
        {
            InitializeComponent();
            DateSelector.DisplayDateEnd = EndDate;
        }

        public void UtilizeState(object state)
        {
            
            throw new NotImplementedException();
        }

        private void SearchButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                SearchResults.ItemsSource = from venues in _context.Venues
                                            where venues.Name == VenueSelector.SelectedItem.ToString()
                                            select venues;
            }
            catch (NullReferenceException)
            {
                //await Switcher.pageSwitcher.ShowMessageAsync("Error", "Please select an activity or a venue");
                MessageBox.Show("Please select an activity or a venue.");
            }
        }

        private void ActivitySelector_OnLoaded(object sender, RoutedEventArgs e)
        {
            //List<string> activityList = new List<string>();
            //foreach (var facility in facilities)
            //{
            //    if (!activities.Contains(facility.Activity))
            //    {
            //        activityList.Add(facility.Activity.ActivityName);
            //    }
            //}

            ActivitySelector.ItemsSource = from Facilties in _context.Facilities
                                           select Facilties.Activity.ActivityName;
        }

        private void ActivitySelector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            VenueSelector.ItemsSource = null;
            string selected = ActivitySelector.SelectedItem.ToString();

            VenueSelector.ItemsSource = from Facilties in _context.Facilities
                                        where Facilties.Activity.ActivityName == selected
                                        select Facilties.Venue.Name;
        }

        private void VenueSelector_OnLoaded(object sender, RoutedEventArgs e)
        {
            //List<string> venueList = new List<string>();
            //foreach (var venues in facilities)
            //{
            //    if (!venueList.Contains(venues.Name))
            //    {
            //        venueList.Add(venues.Name);
            //    }
            //}
            VenueSelector.ItemsSource = from Venues in _context.Venues
                                        select Venues.Name;
        }

        private void VenueSelector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Not implemented 
        }

        private void SearchResults_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
