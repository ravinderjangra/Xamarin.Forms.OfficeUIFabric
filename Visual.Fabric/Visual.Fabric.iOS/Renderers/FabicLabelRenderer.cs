using FabricComponents;
using UIKit;
using Visual.Fabric.Forms;
using Visual.Fabric.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Label), typeof(FabicLabelRenderer), new[] { typeof(FabricVisual) })]

namespace Visual.Fabric.iOS.Renderers
{
    public class FabicLabelRenderer : LabelRenderer
    {
        protected override UILabel CreateNativeControl()
        {
            return new MSLabel(MSTextStyle.Headline, MSTextColorStyle.Error);
        }
    }
}
