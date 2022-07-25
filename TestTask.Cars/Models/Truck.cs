namespace TestTask.Cars.Models
{
    public class Truck : Car
    {
        public decimal MaxLoadCapacity { get; init; }
        private const decimal PercentageReductionByLoadCapacity = 0.04m;
        private const decimal QuantitForPercentage = 200m;

        public Truck(decimal averageConsumption,
            decimal tankVolume,
            decimal currentTankVolume,
            decimal speed,
            decimal maxLoadCapacity,
            decimal currentLoadCopacity) : base(averageConsumption, tankVolume, currentTankVolume, speed)
        {
            AverageConsumption = averageConsumption;
            TankVolume = tankVolume;
            CurrentTankVolume = currentTankVolume;
            Speed = speed;
            MaxLoadCapacity = maxLoadCapacity;
            CurrentLoadCopacity = currentLoadCopacity > maxLoadCapacity ? throw new ArgumentException("Грузоподъемность превышена") : currentLoadCopacity;

        }

        public decimal CurrentLoadCopacity { get; set; }
        protected override decimal GetDistance(decimal Fuel)
        {
            return base.GetDistance(Fuel) / (1 - CurrentLoadCopacity * (PercentageReductionByLoadCapacity / QuantitForPercentage));
        }

    }
}
