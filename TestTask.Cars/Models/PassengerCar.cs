namespace TestTask.Cars.Models
{
    public class PassengerCar : Car
    {
        private const decimal PercentageReductionByPassenger = 0.06m;

        public PassengerCar(decimal averageConsumption,
            decimal tankVolume,
            decimal currentTankVolume,
            decimal speed, int maxPassengerCount, int passengerCount) : base(averageConsumption, tankVolume, currentTankVolume, speed)
        {
            AverageConsumption = averageConsumption;
            TankVolume = tankVolume;
            CurrentTankVolume = currentTankVolume;
            Speed = speed;
            MaxPassengerCount = maxPassengerCount;
            PassengerCount = passengerCount > maxPassengerCount? throw new ArgumentException("Количество пассажиров превышенно"): passengerCount;
        }

        public int MaxPassengerCount { get; init; }
        public int PassengerCount { get; set; }
        protected override decimal GetDistance(decimal Fuel)
        {

            return base.GetDistance(Fuel) * (1 - PercentageReductionByPassenger * PassengerCount);
        }
    }
}
