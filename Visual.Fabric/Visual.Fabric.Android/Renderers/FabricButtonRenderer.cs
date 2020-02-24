using Xamarin.Forms;
using Visual.Fabric.Android.Renderers;
using Visual.Fabric.Forms;
using Android.Content;
using Android.Support.V7.Widget;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Button), typeof(FabricButtonRenderer), new[] { typeof(FabricVisual) })]

namespace Visual.Fabric.Android.Renderers
{
    public class FabricButtonRenderer : ButtonRenderer
    {
        public FabricButtonRenderer(Context context) : base(context)
        {
        }
    }
}
