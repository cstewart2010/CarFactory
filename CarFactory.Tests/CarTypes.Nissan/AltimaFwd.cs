using CarFactory.Abstractions;
using CarFactory.Enums;
using CarFactory.Tests.CarTypes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Tests.CarTypes.Nissan
{
    public class AltimaFwd : FwdCar
    {
        public override string? Make { get; } = Enums.Make.Nissan.ToString();
        public override string? Model { get; } = Enums.Model.Altima.ToString();
        public override string? Trim { get; }
        public override uint Year { get; }
        public override uint TopSpeed { get; }
        public override uint Mileage { get; }
        public override uint TankSize { get; }

        public AltimaFwd(
            uint year,
            uint topSpeed,
            uint mileage,
            uint tankSize,
            string trim)
        {
            Trim = trim;
            Year = year;
            TopSpeed = topSpeed;
            Mileage = mileage;
            TankSize = tankSize;
            Gas = tankSize;
        }
    }
}
