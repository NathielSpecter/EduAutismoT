using EduAutismo.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Toolkit.Uwp.UI.Animations;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EduAutismo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            background.Source = PathMusic.MusicOne;
            var view = ApplicationView.GetForCurrentView();
            view.TryEnterFullScreenMode();
            StatusBar();
            RotacionarSol.Begin();
            LeftCloud.Begin();
            middleCloud.Begin();
            bird.Begin();
        }

        private async void StatusBar()
        {
            var statusbar = "Windows.UI.ViewManagement.StatusBar";
            if (ApiInformation.IsTypePresent(statusbar))
            {
                await Windows.UI.ViewManagement.StatusBar.GetForCurrentView().HideAsync();
            }
        }
    }
}
