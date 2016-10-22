using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduAutismo.Helper
{
    public static class PathMusic
    {
        public static Uri MusicOne { get { return new Uri("ms-appx:///Assets/Sounds/firstSong.mp3"); } }
        public static Uri MusicTwo { get; set; }
    }
}
