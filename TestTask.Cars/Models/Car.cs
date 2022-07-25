namespace TestTask.Cars.Models
{
    public abstract class Car
    {
        protected Car(decimal averageConsumption, decimal tankVolume, decimal currentTankVolume, decimal speed)
        {
            AverageConsumption = averageConsumption;
            TankVolume = tankVolume;
            CurrentTankVolume = currentTankVolume;
            Speed = speed;
        }

        public decimal AverageConsumption { get; init; }
        public decimal TankVolume { get; init; }
        public decimal CurrentTankVolume { get; set; }
        public decimal Speed { get; init; }


        public decimal GetTimeToCoverDistance(decimal distance)
        {
            return distance / Speed;
        }
        public decimal GetDistanceByFullTankVolume()
        {
            return GetDistance(TankVolume);
        }
        public decimal GetDistanceByCurrentTankVolume()
        {
            return GetDistance(CurrentTankVolume);
        }
        protected virtual decimal GetDistance(decimal Fuel)
        {
            return 100 *  Fuel / AverageConsumption;
        }

    }
}
