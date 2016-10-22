using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace EduAutismo.Helper
{
    public  class BackgroundMusic
    {
        public void BackgroundMusics(Uri path)
        {
            var mediaElement = new MediaElement();
            mediaElement.Source = path;
            mediaElement.AutoPlay = true;
            mediaElement.AreTransportControlsEnabled = false;
            mediaElement.IsLooping = true;
        }
    }
}
