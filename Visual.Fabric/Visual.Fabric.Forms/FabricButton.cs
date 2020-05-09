using Xamarin.Forms;

namespace Visual.Fabric.Forms
{
    public static class FabricButton
    {
        public static readonly BindableProperty ButtonStyleProperty =
            BindableProperty.CreateAttached(
                "ButtonStyle",
                typeof(FabricButtonStyle),
                typeof(Button),
                FabricButtonStyle.PrimaryFilled);

        public static FabricButtonStyle GetButtonStyle(BindableObject view)
        {
            return (FabricButtonStyle)view.GetValue(ButtonStyleProperty);
        }

        public static void SetButtonStyle(BindableObject view, FabricButtonStyle value)
        {
            view.SetValue(ButtonStyleProperty, value);
        }
    }
}
