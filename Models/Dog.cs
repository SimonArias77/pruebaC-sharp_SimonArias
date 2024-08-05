using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_SimonArias.Models;

public class Dog : Animal
{
    // propiedades de la clase perro

    public bool BreedingStatus { get; internal set; } // estado reproductivo
    public string? Temperament { get; internal set; }
    public string? MicrochipNumber { get; internal set; }
    public string? BarkVolume { get; internal set; } // volumen de corteza?
    public string? CoatType { get; internal set; } // tipo de pelo

    // constructor de la clase perro
    public Dog(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg, bool breedingStatus, string temperament, string microchipNumber, string barkVolume, string coatType) : base(id, name, birthdate, breed, color, weightInKg)
    {

        BreedingStatus = breedingStatus;
        Temperament = temperament;
        MicrochipNumber = microchipNumber;
        BarkVolume = barkVolume;
        CoatType = coatType;
    }

    // lista o coleccion de perros
    public static List<Dog> Dogs { get; } = new List<Dog>();

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
