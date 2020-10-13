using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace U25
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void MyCalendarView_SelectedDatesChanged(CalendarView sender, CalendarViewSelectedDatesChangedEventArgs args)
        {
            var selectDates = sender.SelectedDates
                .Select(p => p.Date.Month.ToString() + "/" + p.Date.Day.ToString())
                .ToArray();

            var values = string.Join(", ", selectDates);
            CalendarViewResultTextBlock.Text = values;
        }

        private void InnerFlyoutButton_Click(object sender, RoutedEventArgs e)
        {
            MyFlyout.Hide();
        }

        private string[] selectionItems = new string[]
            {"Ferdinand","Frank","Frida","Nigel","Tag","Tanya","Tanner","Todd"};

        private void MyAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            var autoSuggestBox = (AutoSuggestBox)sender;
            var filtered = selectionItems
                .Where(p => p.StartsWith(autoSuggestBox.Text))
                .ToArray();

            autoSuggestBox.ItemsSource = filtered;
        }
    }
}
