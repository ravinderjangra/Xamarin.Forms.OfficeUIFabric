using System.ComponentModel;
using OfficeUIFabricSample.ControlExamples;
using Xamarin.Forms;

namespace OfficeUIFabricSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ShowButtonExamples.Clicked += (s, e) =>
            {
                Navigation.PushAsync(new ButtonExamples());
            };

            ShowLabelExamples.Clicked += (s, e) =>
            {
                Navigation.PushAsync(new LabelExamples());
            };
        }
    }
}
