using FabricComponents;
using UIKit;
using Visual.Fabric.Forms;
using Visual.Fabric.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Button), typeof(FabricButtonRenderer), new[] { typeof(FabricVisual) })]

namespace Visual.Fabric.iOS.Renderers
{
    public class FabricButtonRenderer : ButtonRenderer
    {
        protected override UIButton CreateNativeControl()
        {
            var style = MSButtonStyle.PrimaryFilled;
            return new MSButton(style);
        }
    }
}
