using CarFactory.Abstractions;
using CarFactory.Enums;
using CarFactory.Parts;

namespace CarFactory.Services
{
    public static class TireShop
    {
        public static void ReplaceLeftFrontWithNewTireWithBrake(BaseCar car, TireType type)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car));
            }

            car.ReplaceTireWithBrake(new TireWithBrake(type), TirePlacement.LeftFront);
        }

        public static void ReplaceLeftFrontWithNewTire(BaseCar car, TireType type)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car));
            }

            car.ReplaceTire(new Tire(type), TirePlacement.LeftFront);
        }

        public static void ReplaceRightFrontWithNewTireWithBrake(BaseCar car, TireType type)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car));
            }

            car.ReplaceTireWithBrake(new TireWithBrake(type), TirePlacement.RightFront);
        }

        public static void ReplaceRightFrontWithNewTire(BaseCar car, TireType type)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car));
            }

            car.ReplaceTire(new Tire(type), TirePlacement.RightFront);
        }

        public static void ReplaceLeftBackWithNewTireWithBrake(BaseCar car, TireType type)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car));
            }

            car.ReplaceTireWithBrake(new TireWithBrake(type), TirePlacement.LeftBack);
        }

        public static void ReplaceLeftBackWithNewTire(BaseCar car, TireType type)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car));
            }

            car.ReplaceTire(new Tire(type), TirePlacement.LeftBack);
        }

        public static void ReplaceRightBackWithNewTireWithBrake(BaseCar car, TireType type)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car));
            }

            car.ReplaceTireWithBrake(new TireWithBrake(type), TirePlacement.RightBack);
        }

        public static void ReplaceRightBackWithNewTire(BaseCar car, TireType type)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car));
            }

            car.ReplaceTire(new Tire(type), TirePlacement.RightBack);
        }
    }
}
