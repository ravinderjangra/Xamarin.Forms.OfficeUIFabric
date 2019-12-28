using Android.Content;
using Android.Support.V7.Widget;
using Android.Widget;
using OfficeUIFabricSample;
using OfficeUIFabricSample.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(Button), typeof(FabricButtonRenderer), new[] { typeof(FabricVisual) })]

namespace OfficeUIFabricSample.Droid.Renderers
{
    public class FabricButtonRenderer : ButtonRenderer
    {
        public FabricButtonRenderer(Context context) : base(context)
        {
        }

        protected override AppCompatButton CreateNativeControl()
        {
            //Todo: fix this widget is missing
            //return new Com.Microsoft.Officeuifabric.Widget.Button();
            return base.CreateNativeControl();
        }
    }
}
