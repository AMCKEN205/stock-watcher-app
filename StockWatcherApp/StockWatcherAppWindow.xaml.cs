using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace StockWatcherApp
{
    /// <summary>
    /// Interaction logic for StockWatcherAppWindow.xaml. Designed as "thinly" as possible, to ensure
    /// the majority of UI logic is being handled by the XAML design code.
    /// </summary>
    public partial class StockWatcherAppWindow : Window
    {
        /// <summary>
        /// Base constructor. Only used to initalise the XAML design code in StockWatcherAppWindow.xaml.cs.
        /// </summary>
        public StockWatcherAppWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the minimum and maximum height of the StockSummaryView panel within the main application window.
        /// The StockSummaryView panel should only ever have a height value of
        /// between the defined percentage values. The percentage value range is inclusive. 
        /// </summary>
        private void HandleStockSummaryViewHeightBoundariesSet()
        {
            const double twentyFivePercent = 0.25;
            const double thirtyFivePercent = 0.35;
            
            // ActualHeight always gets the current *rendered* size of the window,
            // while height only gets it's set height value.
            // On window maximise the windows height value is not reset, so we need to based our
            // StockSummaryView panels max and min heights on the windows rendered size.
            StockSummaryView.MinHeight = ActualHeight * twentyFivePercent;
            StockSummaryView.MaxHeight = ActualHeight * thirtyFivePercent;
        }

        /// <summary>
        /// Handles the addition of a new holding requested by the user.
        /// Sets up the IndividualStocksGridView to be in a state that allows it to retrieve
        /// and accept new holding information being entered.
        /// </summary>
        private void HandleNewHoldingRequested()
        {
            
        }

        /// <summary>
        /// Handles the user resizing the window through clicking and dragging of the window sides.
        /// </summary>
        /// <remarks>
        /// Parameters passed are the standard event parameters for window size change events, and in this case
        /// aren't directly used by the event handling method.
        /// </remarks>
        private void OnWindowSizeChanged(object sender, SizeChangedEventArgs e)
        {
            HandleStockSummaryViewHeightBoundariesSet();
        }

        /// <summary>
        /// Handles the user maximising the window through clicking the standard window maximise button (top right square).
        /// </summary>
        /// <remarks>
        /// Parameters passed are the standard generic event parameters, and in this case aren't directly used by the
        /// event handling method.
        /// </remarks>
        private void OnWindowStateChanged(object sender, EventArgs e)
        {
            HandleStockSummaryViewHeightBoundariesSet();
        }

        /// <summary>
        /// Handles the user clicking the new holding button, which requests the UI to take in new holding information.
        /// </summary>
        /// <remarks>
        /// Parameters passed are the generic button press event parameters, and in this case aren't directly used by the
        /// even handling method.
        /// </remarks>
        private void NewHoldingButtonOnClick(object sender, RoutedEventArgs e)
        {
            //TODO: LAYOUT INDIVIDUAL STOCKS VIEW WITH VERTICAL LIST VIEW
        }
    }
}
