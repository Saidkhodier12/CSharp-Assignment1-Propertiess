using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Task1;
internal class Car
{
    public string Make {  get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int Mileage {  get; set; }
    public Car(string _make , string _model , int _year , int _mileage)
    {
        Make = _make; Model = _model; Year = _year; Mileage = _mileage;
    }
    public void Drive(int Distance)
    {
        if (Distance > 0)
        {
            Mileage += Distance;
            Console.WriteLine($"Mileage Now : {Mileage}");
        }
        else
        {
            Console.WriteLine("Distance Must Positive");
        }
    }
    public int Age
    {
        get
        {
            int CurrentYear = DateTime.Now.Year;
            return CurrentYear - Year;
        }
    }
}
