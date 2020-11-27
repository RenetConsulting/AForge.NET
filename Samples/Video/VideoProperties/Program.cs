using AForge.Video.DirectShow;
using System;

namespace VideoProperties
{
    class Program
    {

        static void Main(string[] args)
        {
            var videoDevices = VideoDevices();
            Console.WriteLine("Local video devices");
            if (videoDevices.Count == 0)
            {
                Console.WriteLine("No local video devices");
            }
            else
            {
                foreach (FilterInfo device in videoDevices)
                {
                    Console.WriteLine(device.Name);
                }
            }

            var audioDevices = AudioDevices();
            Console.WriteLine("Local audio devices");
            if (audioDevices.Count == 0)
            {
                Console.WriteLine("No local audio devices");
            }
            else
            {
                foreach (FilterInfo device in audioDevices)
                {
                    Console.WriteLine(device.Name);
                }
            }

        }

        public static FilterInfoCollection VideoDevices()
        {
            // show device list
            // enumerate video devices
            var videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            return videoDevices;
        }

        public static FilterInfoCollection AudioDevices()
        {
            // show device list
            // enumerate video devices
            var audioDevices = new FilterInfoCollection(FilterCategory.AudioInputDevice);

            return audioDevices;
        }

    }
}
