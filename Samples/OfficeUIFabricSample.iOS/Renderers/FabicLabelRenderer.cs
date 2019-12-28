using System;
using FabricComponents;
using OfficeUIFabricSample;
using OfficeUIFabricSample.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Label), typeof(FabicLabelRenderer), new[] { typeof(FabricVisual) })]

namespace OfficeUIFabricSample.iOS.Renderers
{
    public class FabicLabelRenderer : LabelRenderer
    {
        protected override UILabel CreateNativeControl()
        {
            return new MSLabel(MSTextStyle.Headline, MSTextColorStyle.Error);
        }
    }
}
