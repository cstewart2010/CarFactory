using CarFactory.Enums;
using CarFactory.Parts;
using CarFactory.Services;
using CarFactory.Tests.CarTypes.Nissan;

namespace CarFactory.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CheckNewCar()
        {
            var nissanAltimaSvFwd2021 = new AltimaFwd(2021, 120, 30, 18, "SV");
            Assert.IsType<TireWithBrake>(nissanAltimaSvFwd2021.LeftFrontTire);
            Assert.IsType<TireWithBrake>(nissanAltimaSvFwd2021.RightFrontTire);
            Assert.IsType<Tire>(nissanAltimaSvFwd2021.LeftBackTire);
            Assert.IsType<Tire>(nissanAltimaSvFwd2021.RightBackTire);
            Assert.Equal(Quality.New, nissanAltimaSvFwd2021.LeftBackTire.Quality);
            Assert.Equal(Quality.New, nissanAltimaSvFwd2021.RightFrontTire.Quality);
            Assert.Equal(Quality.New, nissanAltimaSvFwd2021.LeftBackTire.Quality);
            Assert.Equal(Quality.New, nissanAltimaSvFwd2021.RightBackTire.Quality);
            Assert.False(nissanAltimaSvFwd2021.OilChangeNeeded);
            Assert.False(nissanAltimaSvFwd2021.TireChangeNeeded);
            Assert.Equal(0, nissanAltimaSvFwd2021.Odometer);
        }

        [Fact]
        public void CheckTireShop()
        {
            var nissanAltimaSvFwd2021 = new AltimaFwd(2021, 120, 30, 18, "SV");
            Assert.Equal(TireType.Regular, nissanAltimaSvFwd2021.LeftFrontTire.Type);
            Assert.Equal(TireType.Regular, nissanAltimaSvFwd2021.RightFrontTire.Type);
            Assert.Equal(TireType.Regular, nissanAltimaSvFwd2021.LeftBackTire.Type);
            Assert.Equal(TireType.Regular, nissanAltimaSvFwd2021.RightBackTire.Type);

            TireShop.ReplaceLeftFrontWithNewTireWithBrake(nissanAltimaSvFwd2021, TireType.RunFlat);
            Assert.Equal(TireType.RunFlat, nissanAltimaSvFwd2021.LeftFrontTire.Type);
            Assert.Equal(TireType.Regular, nissanAltimaSvFwd2021.RightFrontTire.Type);
            Assert.Equal(TireType.Regular, nissanAltimaSvFwd2021.LeftBackTire.Type);
            Assert.Equal(TireType.Regular, nissanAltimaSvFwd2021.RightBackTire.Type);
        }
    }
}