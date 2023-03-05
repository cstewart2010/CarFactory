using CarFactory.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Parts
{
    public class Brake
    {
        public Brake(BrakeType type)
        {
            Type = type;
        }

        public Brake(BrakeType type, int miles, Quality quality)
        {
            Miles = miles;
            Type = type;
            Quality = quality;
        }

        public BrakeType Type { get; set; }
        public Quality Quality { get; set; }
        public int Miles { get; private set; }

        public void CheckQuality()
        {
            Quality quality;
            if (Miles < 10000)
            {
                quality = Quality.New;
            }
            else if (Miles < 20000)
            {
                quality = Quality.LikeNew;
            }
            else if (Miles < 30000)
            {
                quality = Quality.Fair;
            }
            else if (Miles < 40000)
            {
                quality = Quality.Degrading;
            }
            else if (Miles < 50000)
            {
                quality = Quality.ReplacementNeededSoon;
            }
            else
            {
                quality = Quality.ReplacementNeededNow;
            }

            if (quality == Quality)
            {
                Console.WriteLine($"Brake Quality updated: {Quality} -> {quality}");
                Quality = quality;
            }
            else
            {
                Console.WriteLine($"Ain't nothing new: {Quality}");

            }
        }

        public void AddMiles(int miles)
        {
            Miles += miles;
        }
    }
}
