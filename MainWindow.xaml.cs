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
    }
}
