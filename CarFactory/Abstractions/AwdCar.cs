using CarFactory.Enums;
using CarFactory.Parts;

namespace CarFactory.Abstractions
{
    public abstract class AwdCar : BaseCar
    {
        private TireWithBrake _leftFront = new TireWithBrake(TireType.Regular);
        private TireWithBrake _rightFront = new TireWithBrake(TireType.Regular);
        private TireWithBrake _leftBack = new TireWithBrake(TireType.Regular);
        private TireWithBrake _rightback = new TireWithBrake(TireType.Regular);

        public override BaseTire? LeftFrontTire
        {
            get
            {
                return _leftFront;
            }
            protected set
            {
                if (value is not TireWithBrake tire)
                {
                    throw new InvalidOperationException();
                }

                _leftFront = tire;
            }
        }
        public override BaseTire? RightFrontTire
        {
            get
            {
                return _rightFront;
            }
            protected set
            {
                if (value is not TireWithBrake tire)
                {
                    throw new InvalidOperationException();
                }

                _rightFront = tire;
            }
        }
        public override BaseTire? LeftBackTire
        {
            get
            {
                return _leftBack;
            }
            protected set
            {
                if (value is not TireWithBrake tire)
                {
                    throw new InvalidOperationException();
                }

                _leftBack = tire;
            }
        }
        public override BaseTire? RightBackTire
        {
            get
            {
                return _rightback;
            }
            protected set
            {
                if (value is not TireWithBrake tire)
                {
                    throw new InvalidOperationException();
                }

                _rightback = tire;
            }
        }

        internal override TransmissionLayout TransmissionLayout { get; } = TransmissionLayout.AllWheelDrive;

        public override void Drive(double hours)
        {
            if (hours <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(hours), $"You can't drive for {hours} hours");
            }
            if (OilChangeNeeded)
            {
                hours -= 0.5;
            }
            if (TireChangeNeeded)
            {
                hours -= 0.5;
            }

            var miles = (int)(Mileage * hours);
            var gasUsed = (int)(miles / Mileage);
            if (hours <= 0 || gasUsed > Gas)
            {
                throw new Exception("You don't have enough gas to do this.");
            }
            _leftFront.AddMiles(miles);
            _rightFront.AddMiles(miles);
            _leftBack.AddMiles(miles);
            _rightback.AddMiles(miles);
            Odometer += miles;
        }

        public override void CheckCar()
        {
            TireChangeNeeded = CheckTire(_leftFront, nameof(LeftFrontTire))
                | CheckTire(_rightFront, nameof(RightFrontTire))
                | CheckTire(_leftBack, nameof(LeftBackTire))
                | CheckTire(_rightback, nameof(RightBackTire));
            OilChangeNeeded = Odometer - OdometerAtOilChange > 5000;
        }

        internal override void ReplaceTireWithBrake(TireWithBrake newTire, TirePlacement placement)
        {
            if (newTire == null)
            {
                throw new ArgumentNullException(nameof(newTire));
            }

            switch (placement)
            {
                case TirePlacement.LeftFront:
                    if (newTire.Size != _leftFront.Size)
                    {
                        throw new Exception("Invalid tire size");
                    }
                    newTire.ReplaceBrake(_leftFront.Brake);
                    LeftFrontTire = newTire;
                    break;
                case TirePlacement.RightFront:
                    if (newTire.Size != _rightFront.Size)
                    {
                        throw new Exception("Invalid tire size");
                    }
                    newTire.ReplaceBrake(_rightFront.Brake);
                    RightFrontTire = newTire;
                    break;
                case TirePlacement.LeftBack:
                    if (newTire.Size != _leftBack.Size)
                    {
                        throw new Exception("Invalid tire size");
                    }
                    newTire.ReplaceBrake(_leftBack.Brake);
                    LeftBackTire = newTire;
                    break;
                case TirePlacement.RightBack:
                    if (newTire.Size != _rightback.Size)
                    {
                        throw new Exception("Invalid tire size");
                    }
                    newTire.ReplaceBrake(_rightback.Brake);
                    RightBackTire = newTire;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(placement));
            }
        }

        internal override void ReplaceTire(Tire newTire, TirePlacement placement)
        {
            throw new NotImplementedException();
        }
    }
}
