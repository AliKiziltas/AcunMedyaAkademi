class Program
{
    static void Main()
    {
        List<Car> cars = new List<Car>
        {
            new Car("Toyota", "Corolla", 6.5, 5000),
            new Car("BMW", "X5", 9.0, 5000),
            new Car("Mercedes", "C200", 8.4, 5000)
        };

        foreach (var car in cars)
        {
            Console.WriteLine("Marka: " + car.Brand + "Model: " + car.Model + " 100 km'de Yaktığı Yakıt: " + car.FuelConsumption + " litre"+
     "Toplam Yakıt Tüketimi: " + car.CalculateTotalFuelConsumption() + " litre");
        }
    }
}
