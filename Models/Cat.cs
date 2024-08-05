using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_SimonArias.Models;

public class Cat : Animal
{
    //propiedades de la clase Gato
    public bool BreedingStatus { get; set; }
    public string FurLength { get; set; }

    // constructor de la clase Gato
    public Cat(int id, string name, DateTime birthdate, string breed, string color, double weightInKg,
               bool breedingStatus, string furLength)
        : base(id, name, birthdate, breed, color, weightInKg)
    {
        BreedingStatus = breedingStatus;
        FurLength = furLength;
    }
    // método para mostrar informacion de la clase Gato
    public override void ShowInformation()
    {
        Console.WriteLine($"Cat: {Name}, Breed: {Breed}, Age: {CalculateAgeInMonths()} months, ");
    }

    // método para mostrar revisión básica de la clase Gato
    public override void BasicReview()
    {
        Console.WriteLine($"Cat {Name}");
    }

    // método para Peluquería
    public void Hairdress()
    {
        if (FurLength != "None")
        {
            Console.WriteLine($"Grooming {Name}'s fur");
        }
        else
        {
            Console.WriteLine($"{Name} has no fur to groom");
        }
    }

    // método para el estado de la reproducción
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
}