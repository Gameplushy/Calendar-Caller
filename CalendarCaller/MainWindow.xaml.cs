using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CalendarCaller
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmitClassic_Click(object sender, RoutedEventArgs e)
        {
            tbRes.Text = TP1WS.Calendar.CreateCalendar(((ComboBoxItem)cbMonth.SelectedItem).Tag + "/" + tbYear.Text) ;
        }

        private void btnSubmitWithEvents_Click(object sender, RoutedEventArgs e)
        {
            tbRes.Text = TP1WS.Calendar.CreateCalendarWithSpecialDates(((ComboBoxItem)cbMonth.SelectedItem).Tag + "/" + tbYear.Text, tbEvents.Text.Split(",").ToList());
        }
    }
}
