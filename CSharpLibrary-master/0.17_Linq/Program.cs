﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UsedCar> usedCars = new List<UsedCar>
            {
                new UsedCar() { VIN = "A1", Make = "Hyundai", Model = "Elantra", Price = 5000, Year = 2009 },
                new UsedCar() { VIN = "B1", Make = "Hyundai", Model = "Accent", Price = 3000, Year = 2004 },
                new UsedCar() { VIN = "C3", Make = "Ford", Model = "Tarus", Price = 7000, Year = 2010 },
                new UsedCar() { VIN = "D4", Make = "Ford", Model = "Escape", Price = 15000, Year = 2014 },
                new UsedCar() { VIN = "E5", Make = "BMW", Model = "55i", Price = 15000, Year = 2015 },
                new UsedCar() { VIN = "Z5", Make = "BMW", Model = "55i", Price = 9000, Year = 2002 },
                new UsedCar() { VIN = "U10", Make = "Toyota", Model = "4Runner", Price = 6500, Year = 2002 },
                new UsedCar() { VIN = "T2", Make = "Toyota", Model = "Camry", Price = 8700, Year = 2011 },
            };

            var bmws = from car in usedCars
                       where car.Make == "BMW"
                       select car;
            foreach (var bmw in bmws)
            {
                Console.WriteLine("The {0} {1} is a nice used car that costs: {2:C}", bmw.Year, bmw.Model, bmw.Price);
            }
            var price = from car in usedCars
                       where car.Price < 10000
                       select car;
            foreach (var price in Price)
            {
                Console.WriteLine("This {0} {1} is at a cheap price for {2:C}", price.Year, price.Model, bmws.Price);
            }
            Console.ReadLine();
            Console.WriteLine("==========");

        }
    
    class UsedCar
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public int Year { get; set; }


    }
    




}
