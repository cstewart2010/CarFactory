using CarFactory.Enums;
using CarFactory.Parts;

namespace CarFactory.Abstractions
{
    public abstract class BaseTire
    {
        public TireType Type { get; protected set; }
        public int Size { get; protected set; }
        public Quality Quality { get; protected set; }
        public int Miles { get; protected set; }

        public abstract void ReplaceBrake(Brake brake);
        internal abstract void AddMiles(int miles);

        public bool CheckQuality()
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
                Console.WriteLine($"Tire Quality updated: {Quality} -> {quality}");
                Quality = quality;
            }
            else
            {
                Console.WriteLine($"Ain't nothing new: {Quality}");
            }

            return (int)Quality < 3;
        }
    }
}
