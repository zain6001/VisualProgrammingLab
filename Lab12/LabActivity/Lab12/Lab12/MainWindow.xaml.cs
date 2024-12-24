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
using System.Windows.Threading;

namespace Lab12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Initialize a DispatcherTimer to update the Currenttimeproperty every second
            DispatcherTimer timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1) // Set the interval to 1 second
            };

            // Attach an event handler to update Currenttimeproperty with the current time
            timer.Tick += (s, e) => Currenttimeproperty = DateTime.Now;
            timer.Start(); // Start the timer
        }

        // CLR Wrapper for the Currenttimeproperty DependencyProperty
        public DateTime Currenttimeproperty
        {
            get { return (DateTime)GetValue(CurrenttimepropertyProperty); }
            set { SetValue(CurrenttimepropertyProperty, value); }
        }

        // Registering Currenttimeproperty as a DependencyProperty with callbacks
        public static readonly DependencyProperty CurrenttimepropertyProperty =
            DependencyProperty.Register(
                nameof(Currenttimeproperty), // Property name
                typeof(DateTime),            // Property type
                typeof(MainWindow),          // Owning type
                new PropertyMetadata(
                    DateTime.Now,            // Default value
                    OnCurrenttimeChanged,    // Property changed callback
                    CoerceCurrenttime),      // Coerce value callback
                ValidateCurrenttime);         // Validation callback

        // Property Changed Callback
        private static void OnCurrenttimeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Log changes to the console (Optional)
            var control = d as MainWindow;
            Console.WriteLine($"Currenttimeproperty changed from {e.OldValue} to {e.NewValue}");
        }

        // Coerce Value Callback
        private static object CoerceCurrenttime(DependencyObject d, object baseValue)
        {
            var currentTime = (DateTime)baseValue;

            // Adjust the value to ensure it's not in the future
            if (currentTime > DateTime.Now)
            {
                Console.WriteLine("Coerce: Adjusting future time to current time.");
                return DateTime.Now;
            }

            return currentTime;
        }

        // Validation Callback
        private static bool ValidateCurrenttime(object value)
        {
            var currentTime = (DateTime)value;

            // Ensure the year is not earlier than 2024
            if (currentTime.Year < 2024)
            {
                Console.WriteLine("Validation Failed: Date must not be before the year 2024.");
                return false;
            }

            return true;
        }
    }
}
