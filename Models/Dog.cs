using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_SimonArias.Models;

public class Dog : Animal
{
    // propiedades de la clase Perro
    public bool BreedingStatus { get; set; }
    public string Temperament { get; set; }
    public string MicrochipNumber { get; set; }
    public string BarkVolume { get; set; }
    public string CoatType { get; set; }

    // constructor de la clase Perro
    public Dog(int id, string name, DateTime birthdate, string breed, string color, double weightInKg,
               bool breedingStatus, string temperament, string microchipNumber, string barkVolume, string coatType)
        : base(id, name, birthdate, breed, color, weightInKg)
    {
        BreedingStatus = breedingStatus;
        Temperament = temperament;
        MicrochipNumber = microchipNumber;
        BarkVolume = barkVolume;
        CoatType = coatType;
    }
    //método para mostrar información de la clase Perro
    public override void ShowInformation()
    {
        Console.WriteLine($"Dog: {Name}, Breed: {Breed}, Age: {CalculateAgeInMonths()} months, Temperament: {Temperament}, MicrochipNumber: {MicrochipNumber}, barkVolume: {BarkVolume}");
    }

    // método para mostrar estado de reproducción de la clase Perro
    public void Breeding()
    {
        if (BreedingStatus)
        {
            Console.WriteLine($"{Name}'s breeding status: available for breeding");
        }
        else
        {
            Console.WriteLine($"{Name}'s breeding status: not available for breeding");
        }
    }
    // método para mostrar revisión básica de la clase Perro
    public override void BasicReview()
    {
        Console.WriteLine($"Dog {Name}");
    }

    // método para peluquería de la clase Perro
    public void Hairdress()
    {
        if (CoatType != "Short")
        {
            Console.WriteLine($"Giving {Name} a haircut");
        }
        else
        {
            Console.WriteLine($"{Name}'s coat is too short for a haircut");
        }
    }
}
