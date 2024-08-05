using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_SimonArias.Models;

public class Cat
{
    // propiedades de la clase gato
    public object? Id { get; internal set; }
    public object? Name { get; internal set; }
    public bool BreedingStatus { get; internal set; } // estado reproductivo
    public string? FurLength { get; internal set; } // longitud pelaje

    // constructor de la clase gato
    public Cat(object? id, object? name, bool breedingStatus, string? furLength)
    {
        Id = id;
        Name = name;
        BreedingStatus = breedingStatus;
        FurLength = furLength;
    }
    public Cat()
    {
    }
    // método para castrar animal
    public void CastrateAnimal()
    {
        Console.WriteLine("Animal castrado");
    }
    // método peluquería
    public void Hairdress()
    {
        Console.WriteLine("Peluquería realizada");
    }
}
