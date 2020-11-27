using AForge.Video.DirectShow;
using System;

namespace VideoProperties
{
    class Program
    {

        static void Main(string[] args)
        {
            var videoDevices = VideoDevices();
            Console.WriteLine("Local capture devices");
            foreach (FilterInfo device in videoDevices)
            {
                Console.WriteLine(device.Name);
            }
        }

        public static FilterInfoCollection VideoDevices()
        {
            // show device list
            // enumerate video devices
            var videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            return videoDevices;
        }
    }
}
