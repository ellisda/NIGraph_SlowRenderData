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
        public MainWindow()
        {
            InitializeComponent();

            graph1.DataSource = NoisyData.GetMultiPlotData();
            verticalAxis1.Range = new NationalInstruments.Controls.Range<double>(50, 100); //example range where noisy data goes off the top and bottom of screen
        }

        /// <summary>
        /// Set Y Axis to show that same data can render faster when all data is visible on graph (not going off-screen)
        /// </summary>
        private void buttonFastRender_Click(object sender, RoutedEventArgs e)
        {
            verticalAxis1.Range = new NationalInstruments.Controls.Range<double>(-5000, 5000); //fast to render when noisy data doesn't go off-screen vertically
        }

        /// <summary>
        /// Set Y Axis back to initial slow range (where points are far off-screen above and below visible yAxis Range)
        /// </summary>
        private void buttonSlowRender_Click(object sender, RoutedEventArgs e)
        {
            verticalAxis1.Range = new NationalInstruments.Controls.Range<double>(50, 100); //example range where noisy data goes off the top and bottom of screen
        }
    }
}
