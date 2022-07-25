
using TestTask.Cars.Models;

List<Car> cars = new List<Car>()
{
 new PassengerCar(10m,30m,28m,90m,4,3),
 new Truck(30m,300m,280m,80,900m,600m),
};

foreach(var car in cars)
{
    ShowAllCalculations(car);
}


void ShowAllCalculations(Car car)
{
    Console.WriteLine(car.GetDistanceByCurrentTankVolume());
    Console.WriteLine(car.GetDistanceByFullTankVolume());
    Console.WriteLine(car.GetTimeToCoverDistance(800m));

}