using System;
using System.Collections.Generic;

class Car
{
    public string Brand;
    public string Model;
    public double FuelConsumption; // 100 km başına harcanan yakıt (litre)
    public double TotalDistance;   // Toplam mesafe (km)

    public Car(string brand, string model, double fuelConsumption, double totalDistance)
    {
        Brand = brand;
        Model = model;
        FuelConsumption = fuelConsumption;
        TotalDistance = totalDistance;
    }

    public double CalculateTotalFuelConsumption()
    {
        return (TotalDistance / 100) * FuelConsumption;
    }
}