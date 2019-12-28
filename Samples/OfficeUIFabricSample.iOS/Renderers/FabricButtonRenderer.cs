using FabricComponents;
using OfficeUIFabricSample;
using OfficeUIFabricSample.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Button), typeof(FabricButtonRenderer), new[] { typeof(FabricVisual) })]

namespace OfficeUIFabricSample.iOS.Renderers
{
    public class FabricButtonRenderer : ButtonRenderer
    {
        protected override UIButton CreateNativeControl()
        {
            var style = new MSButtonStyle();
            return new MSButton(style);
        }
    }
}
