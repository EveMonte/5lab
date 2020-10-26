﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5lab
{

    public interface IMovable
    {
        bool IsThereAnEngine();
        int Wheels { get; set; }
        string Driver();
    }
    public abstract class Vehicle
    {
        public int Wheels { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public abstract string Driver();

    }

    public class Car : Vehicle, IMovable
    {
        public Car()
        {
            int Power;
            Console.WriteLine("Введите мощность двигателя");
            Power = Convert.ToInt32(Console.ReadLine());
            Engine engine = new Engine(Power);
        }

        public override string Driver()
        {
            return "Водитель управляет автомобилем";
        }
        public bool IsThereAnEngine()
        {
            return true;
        }
        public override string ToString()
        {
            string Str = "_5lab.Car Override Method";
            return Str;
        }
        string IMovable.Driver()
        {
            return "Переопределенный метод интерфейса, вызванный в классе Car";
        }
    }
    
    public class Train : Vehicle, IMovable
    {
        public Train()
        {
            int Power;
            Console.WriteLine("Введите мощность двигателя");
            Power = Convert.ToInt32(Console.ReadLine());
            Engine engine = new Engine(Power);
        }

        public override string Driver()
        {
            return "Поездом управляет машинист";
        }

        string IMovable.Driver()
        {
            return "Переопределенный метод интерфейса, вызванный в классе Train";
        }
        public bool IsThereAnEngine()
        {
            return true;
        }
        public override string ToString()
        {
            string Str = "_5lab.Train Override Method";
            return Str;
        }
    }

    public class Wagon : Train, IMovable
    {
        public override string ToString()
        {
            string Str = "_5lab.Wagon Override Method";
            return Str;
        }
    }

    public class Express : Train, IMovable
    {
        public override string ToString()
        {
            string Str = "_5lab.Express Override Method";
            return Str;
        }
    }

    //sealed
    sealed class Engine
    {
        int Power;
        public Engine(int Power)
        {
            this.Power = Power;
        }
        public override string ToString()
        {
            string Str = "_5lab.Car Override Method";
            return Str;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Train train = new Train();
            Wagon wagon = new Wagon();
            Console.WriteLine(car.ToString());
            Console.WriteLine(car.GetHashCode());
            Console.WriteLine(car.Equals(car));
            Console.WriteLine("car is Car: " + (car is Car));
            Console.WriteLine("train is Train: " + (train is Train));
            Console.WriteLine("wagon is Vehicle: " + (wagon is Vehicle));
        }
    }
}
