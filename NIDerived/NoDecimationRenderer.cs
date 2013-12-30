using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NationalInstruments.Controls.Rendering;
using NationalInstruments.Controls.Data;
using System.Windows;

namespace NIGraph_SlowRenderData.NIDerived
{
    /// <summary>
    /// custom Renderer to be used in a PlotRendererGroup with a Visibile PlotRenderer to ensure no decimation is done by visible renderer
    /// ref: http://forums.ni.com/t5/Measurement-Studio-for-NET/strange-plots-on-graphs/m-p/2538782/highlight/true#M14583
    /// </summary>
    public sealed class NoDecimationRenderer : PlotRenderer
    {
        private static readonly DataRequirements _dataRequirements =
            new DataRequirements(DataCulling.PreserveLines, DataDecimation.None);

        public override SupportedRenderModes SupportedRenderModes
        {
            get { return SupportedRenderModes.VectorAndRaster; }
        }

        public override DataRequirements GetDataRequirements()
        {
            return _dataRequirements;
        }

        protected override Freezable CreateInstanceCore()
        {
            return new NoDecimationRenderer();
        }

        protected override void RenderGraphCore(PlotRenderArgs renderArgs) { }
        protected override void RenderLegendCore(LegendRenderArgs renderArgs) { }
    }
}
