using System.ComponentModel;
using FabricComponents;
using UIKit;
using Visual.Fabric.Forms;
using Visual.Fabric.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using FabricVisual = Visual.Fabric.Forms.FabricVisual;

[assembly: ExportRenderer(typeof(Button), typeof(FabricButtonRenderer), new[] { typeof(FabricVisual) })]

namespace Visual.Fabric.iOS
{
    public class FabricButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
                UpdateButtonStyle();
        }

        protected override UIButton CreateNativeControl()
        {
            var style = MSButtonStyle.PrimaryFilled;
            return new MSButton(style);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == FabricButton.ButtonStyleProperty.PropertyName)
                UpdateButtonStyle();
        }

        private void UpdateButtonStyle()
        {
            if (Control != null)
            {
                var style = FabricButton.GetButtonStyle(Element);
                MSButtonStyle newStyle = MSButtonStyle.PrimaryFilled;
                switch (style)
                {
                    case FabricButtonStyle.PrimaryFilled:
                        newStyle = MSButtonStyle.PrimaryFilled;
                        break;
                    case FabricButtonStyle.PrimaryOutLine:
                        newStyle = MSButtonStyle.PrimaryOutline;
                        break;
                    case FabricButtonStyle.SecondaryOutLine:
                        newStyle = MSButtonStyle.SecondaryOutline;
                        break;
                    case FabricButtonStyle.Borderless:
                        newStyle = MSButtonStyle.Borderless;
                        break;
                }
                ((MSButton)Control).Style = newStyle;
            }
        }
    }
}
