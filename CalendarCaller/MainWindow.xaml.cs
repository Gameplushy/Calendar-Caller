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

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            tbRes.Text = TP1WS.Calendar.CreateCalendar(((ComboBoxItem)cbMonth.SelectedItem).Tag + "/" + tbYear.Text) ;
        }
    }
}
