using CarFactory.Enums;
using CarFactory.Parts;

namespace CarFactory.Abstractions
{
    public interface ICar
    {
        string? Make { get; }
        string? Model { get; }
        string? Trim { get; }
        uint Year { get; }
        uint Mileage { get; }
        uint TankSize { get; }
        uint TopSpeed { get; }
        bool OilChangeNeeded { get; }
        bool TireChangeNeeded { get; }
        int Odometer { get; }
        int OdometerAtOilChange { get; }
        BaseTire? LeftFrontTire { get; }
        BaseTire? RightFrontTire { get; }
        BaseTire? LeftBackTire { get; }
        BaseTire? RightBackTire { get; }
        uint Gas { get; set; }
        uint Speed { get; set; }
        Color Color { get; set; }

        void Drive(double hours);
        void CheckCar();
    }
}
