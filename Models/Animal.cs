using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_SimonArias.Models;

public abstract class Animal
{
    // propiedades comunes de la clase Animal
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Birthdate { get; set; }
    public string Breed { get; set; }
    public string Color { get; set; }
    public double WeightInKg { get; set; }

    //constructor de la clase Animal
    public Animal(int id, string name, DateTime birthdate, string breed, string color, double weightInKg)
    {
        Id = id;
        Name = name;
        Birthdate = birthdate;
        Breed = breed;
        Color = color;
        WeightInKg = weightInKg;
    }
    // métodos de la clase Animal
    public abstract void ShowInformation();
    public abstract void BasicReview();
    public int CalculateAgeInMonths()
    {
        return (int)((DateTime.Now - Birthdate).TotalDays / 30);
    }
}



