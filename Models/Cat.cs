using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_SimonArias.Models;

public class Cat: Animal
{
    // propiedades de la clase gato
  
    public bool BreedingStatus { get; internal set; } // estado reproductivo
    public string? FurLength { get; internal set; } // longitud pelaje

    // constructor de la clase gato
    public Cat(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg, bool breedingStatus, string? furLength) : base( id,  name,  birthdate,  breed,  color,  weightInKg)
    {
        
        BreedingStatus = breedingStatus;
        FurLength = furLength;
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
