using System;
using System.Collections.Generic;
using System.Linq;
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

namespace NIGraph_SlowRenderData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NationalInstruments.Controls.Range<double> slowRange;
        private NationalInstruments.Controls.Range<double> fastRange; 

        public MainWindow()
        {
            InitializeComponent();

            #region Read data from CSV
            slowRange = new NationalInstruments.Controls.Range<double>(-30, 0);
            fastRange = new NationalInstruments.Controls.Range<double>(-50000, 50000);
            graph1.DataSource = NoisyData.GetMultiPlotDataFromCsv(@"resources\NoisyData.csv");
            #endregion

            #region use data from System.Windows.Shapes.Path experiments (originally based on Csv data)
            //slowRange = new NationalInstruments.Controls.Range<double>(50, 100);
            //fastRange = new NationalInstruments.Controls.Range<double>(-5000, 5000);
            //graph1.DataSource = NoisyData.GetMultiPlotData();
            #endregion use data from System.Windows.Shapes.Path experiments (originally based on Csv data)

            verticalAxis1.Range = fastRange;
        }

        /// <summary>
        /// Set Y Axis to show that same data can render faster when all data is visible on graph (not going off-screen)
        /// </summary>
        private void buttonFastRender_Click(object sender, RoutedEventArgs e)
        {
            verticalAxis1.Range = fastRange; //fast to render when noisy data doesn't go off-screen vertically
        }

        /// <summary>
        /// Set Y Axis back to initial slow range (where points are far off-screen above and below visible yAxis Range)
        /// </summary>
        private void buttonSlowRender_Click(object sender, RoutedEventArgs e)
        {
            verticalAxis1.Range = slowRange; //example range where noisy data goes off the top and bottom of screen
        }
    }
}
