using CarFactory.Enums;
using CarFactory.Parts;

namespace CarFactory.Abstractions
{
    public abstract class BaseCar : ICar
    {
        private uint _gas;
        private uint _speed;

        public abstract string? Make { get; }
        public abstract string? Model { get; }
        public abstract string? Trim { get; }
        public abstract uint Year { get; }
        public abstract uint Mileage { get; }
        public abstract uint TankSize { get; }
        public abstract uint TopSpeed { get; }
        internal abstract TransmissionLayout TransmissionLayout { get; }
        public bool OilChangeNeeded { get; protected set; }
        public bool TireChangeNeeded { get; protected set; }
        public int Odometer { get; protected set; }
        public int OdometerAtOilChange { get; protected set; }
        public abstract BaseTire? LeftFrontTire { get; protected set; }
        public abstract BaseTire? RightFrontTire { get; protected set; }
        public abstract BaseTire? LeftBackTire { get; protected set; }
        public abstract BaseTire? RightBackTire { get; protected set; }
        public uint Gas
        {
            get
            {
                return _gas;
            }
            set
            {
                if (value > TankSize)
                {
                    _gas = TankSize;
                }
                else
                {
                    _gas = value;
                }
            }
        }
        public uint Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                if (value > TopSpeed)
                {
                    _speed = TopSpeed;
                }
                else
                {
                    _speed = value;
                }
            }
        }

        public Color Color { get; set; }

        public abstract void Drive(double hours);

        public abstract void CheckCar();

        internal abstract void ReplaceTireWithBrake(TireWithBrake newTire, TirePlacement placement);

        internal abstract void ReplaceTire(Tire newTire, TirePlacement placement);

        public void ChangeOil()
        {
            OdometerAtOilChange = Odometer;
        }

        protected static bool CheckTire(BaseTire? tire, string position)
        {
            if (tire != null)
            {
                Console.WriteLine($"Checking {position}");
                return tire.CheckQuality();
            }
            else
            {
                Console.WriteLine($"Missing the {position}");
                return true;
            }
        }
    }
}
