using Xamarin.Forms;
using Visual.Fabric.Android.Renderers;
using Visual.Fabric.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Content;
using FabricButton = OfficeUIFabric.Android;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Button), typeof(FabricButtonRenderer), new[] { typeof(FabricVisual) })]

namespace Visual.Fabric.Android.Renderers
{
    public class FabricButtonRenderer : ButtonRenderer
    {
        public FabricButtonRenderer(Context context) : base (context)
        {
        }

        protected override global::Android.Widget.Button CreateNativeControl()
        {
            var t = new FabricButton.Button(Context);
            return t;
        }
    }
}
