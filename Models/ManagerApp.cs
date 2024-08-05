using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_SimonArias.Models;

public class ManagerApp
{
    //método crear nuevo perro
    public Dog CreateDog(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg, bool breedingStatus, string temperament, string microchipNumber, string barkVolume, string coatType)
    {
        return new Dog(id, name, birthdate, breed, color, weightInKg, breedingStatus, temperament, microchipNumber, barkVolume, coatType);
    }

    //método crear nuevo gato
    public Cat CreateCat(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg, bool breedingStatus, string? furLength)
    {
        return new Cat(id, name, birthdate, breed, color, weightInKg, breedingStatus, furLength);
    }

    // método mostrar encabezado de la página
    public void ShowHeader()
    {
        Console.WriteLine("Welcome to the Veterinary Clinic");
    }
    // método mostrar pie de página
    public void ShowFooter()
    {
        Console.WriteLine("Thank you for using our services");
    }
    // método mostrar separador entre encabezado y contenido
    public void ShowSeparator()
    {
        Console.WriteLine("--------------------");
    }

}
