using CarFactory.Abstractions;
using CarFactory.Enums;

namespace CarFactory.Parts
{
    public class Tire : BaseTire
    {
        public Tire(TireType type)
        {
            Type = type;
            Quality = Quality.New;
        }

        public Tire(TireType type, Quality quality, int miles)
        {
            Type = type;
            Quality = quality;
            Miles = miles;
        }

        internal override void AddMiles(int miles)
        {
            Miles += miles;
        }

        public override void ReplaceBrake(Brake brake)
        {
            throw new NotImplementedException();
        }
    }

    public class TireWithBrake : BaseTire
    {
        public TireWithBrake(TireType type)
        {
            Type = type;
            Quality = Quality.New;
        }

        public TireWithBrake(TireType type, Brake brake)
        {
            Type = type;
            Brake = brake;
            Quality = Quality.New;
        }

        public TireWithBrake(TireType type, Brake brake, Quality quality, int miles)
        {
            Type = type;
            Brake = brake;
            Quality = quality;
            Miles = miles;
        }

        public Brake Brake { get; internal set; }

        public override void ReplaceBrake(Brake brake)
        {
            Brake = brake;
        }

        internal override void AddMiles(int miles)
        {
            Miles += miles;
            Brake.AddMiles(miles);
        }
    }
}
