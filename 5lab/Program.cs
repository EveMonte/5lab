using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5lab
{

    public interface IMovable
    {
        bool IsThereAnEngine();
    }
    public class Vehicle
    {
        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class Car : Vehicle, IMovable
    {
        public Car(int Power)
        {
            Engine engine = new Engine(Power);
        }
        public bool IsThereAnEngine()
        {
            return true;
        }
        public override string ToString()
        {
            string Str = "_5lab.Car Override";
            return Str;
        }
    }
    
    public class Train : Vehicle, IMovable
    {
        public bool IsThereAnEngine()
        {
            return true;
        }
    }

    public class Wagon : Train, IMovable
    {

    }

    public class Express : Train, IMovable
    {

    }

    sealed class Engine
    {
        int Power;
        public Engine(int Power)
        {
            this.Power = Power;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            Console.WriteLine(vehicle.ToString());
            Car car = new Car(200);
            Console.WriteLine(car.ToString());
        }
    }
}
