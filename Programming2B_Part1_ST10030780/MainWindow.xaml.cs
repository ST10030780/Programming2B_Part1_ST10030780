using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Programming2B_Part1_ST10030780
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

        public object HoursWorkedInput { get; private set; }
        public object LecturerNameInput { get; private set; }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            string lecturerName = LecturerNameInput.Text;
            if (decimal.TryParse(HoursWorkedInput.Text, out decimal hoursWorked))
            {
                // Here you would typically save the claim in the database or data structure.
                MessageBox.Show($"Claim submitted for {lecturerName} with {hoursWorked} hours worked.", "Claim Submitted");
            }
            else
            {
                MessageBox.Show("Please enter valid hours worked.", "Input Error");
            }
        }
    }
}
    }
}