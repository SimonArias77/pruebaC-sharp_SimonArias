using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_SimonArias.Models;

public class Dog
{
    // propiedades de la clase perro
    public object? Id { get; internal set; }
    public object? Name { get; internal set; }
    public bool BreedingStatus { get; internal set; }
    public string? Temperament { get; internal set; }
    public string? MicrochipNumber { get; internal set; }
    public string? BarkVolume { get; internal set; }
    public string? CoatType { get; internal set; }
    // constructor de la clase perro
    public Dog(object? id, object? name, bool breedingStatus, string? temperament, string? microchipNumber, string? barkVolume, string? coatType)
    {
        Id = id;
        Name = name;
        BreedingStatus = breedingStatus;
        Temperament = temperament;
        MicrochipNumber = microchipNumber;
        BarkVolume = barkVolume;
        CoatType = coatType;
    }

    public Dog()
    {
    }

    // método castrar animal
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
