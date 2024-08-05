using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_SimonArias.Models;

public class VeterinaryClinic
{
    // propiedades comunes de la clase VeterinaryClinic
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Dog> Dogs { get; set; }
    public List<Cat> Cats { get; set; }

    // constructor de la clase VeterinaryClinic
    public VeterinaryClinic(string name, string address)
    {
        Name = name;
        Address = address;
        Dogs = new List<Dog>();
        Cats = new List<Cat>();
    }

    // método para agregar un nuevo perro
    public void SaveDog(Dog newDog)
    {
        Dogs.Add(newDog);
    }

    // método para agregar un nuevo gato
    public void SaveCat(Cat newCat)
    {
        Cats.Add(newCat);
    }

    // método para mostrar pacientes
    public void ShowAllPatients()
    {
        Console.WriteLine("All Patients:");
        foreach (var dog in Dogs)
        {
            dog.BasicReview();
        }
        foreach (var cat in Cats)
        {
            cat.BasicReview();
        }
    }

    // método para actualizar información de un perro
    public void UpdateDog(string name, Dog updatedDog)
    {
        var dogToUpdate = Dogs.FirstOrDefault(d => d.Name == name);
        if (dogToUpdate != null)
        {
            int index = Dogs.IndexOf(dogToUpdate);
            Dogs[index] = updatedDog;
            Console.WriteLine("Dog updated successfully.");
        }
        else
        {
            Console.WriteLine("Dog not found.");
        }
    }

    // método para actualizar información de un gato
    public void UpdateCat(string name, Cat updatedCat)
    {
        var catToUpdate = Cats.FirstOrDefault(c => c.Name == name);
        if (catToUpdate != null)
        {
            int index = Cats.IndexOf(catToUpdate);
            Cats[index] = updatedCat;
            Console.WriteLine("Cat updated successfully.");
        }
        else
        {
            Console.WriteLine("Cat not found.");
        }
    }

    // método para eliminar un perro
    public void DeleteDog(string name)
    {
        var dogToDelete = Dogs.FirstOrDefault(d => d.Name == name);
        if (dogToDelete != null)
        {
            Dogs.Remove(dogToDelete);
            Console.WriteLine("Dog deleted successfully.");
        }
        else
        {
            Console.WriteLine("Dog not found.");
        }
    }

    // método para eliminar un gato
    public void DeleteCat(string name)
    {
        var catToDelete = Cats.FirstOrDefault(c => c.Name == name);
        if (catToDelete != null)
        {
            Cats.Remove(catToDelete);
            Console.WriteLine("Cat deleted successfully.");
        }
        else
        {
            Console.WriteLine("Cat not found.");
        }
    }

    // método para mostrar animales
    public void ShowAnimals(string type)
    {
        if (type.ToLower() == "dog")
        {
            Console.WriteLine("Dogs:");
            foreach (var dog in Dogs)
            {
                dog.ShowInformation();
            }
        }
        else if (type.ToLower() == "cat")
        {
            Console.WriteLine("Cats:");
            foreach (var cat in Cats)
            {
                cat.ShowInformation();
            }
        }
        else
        {
            Console.WriteLine("Invalid animal type.");
        }
    }

    // método para mostrar paciente específico
    public void ShowPatient(string patient)
    {
        var dog = Dogs.FirstOrDefault(d => d.Name == patient);
        if (dog != null)
        {
            dog.ShowInformation();
            return;
        }

        var cat = Cats.FirstOrDefault(c => c.Name == patient);
        if (cat != null)
        {
            cat.ShowInformation();
            return;
        }
        Console.WriteLine("Patient not found.");
    }
    // método para mostrar estado de reproducción de  perros y gatos
    public void ToBreeding(string patient)
    {
        var dog = Dogs.FirstOrDefault(d => d.Name == patient);
        if (dog != null)
        {
            dog.Breeding();
            return;
        }

        var cat = Cats.FirstOrDefault(c => c.Name == patient);
        if (cat != null)
        {
            cat.Breeding();
            return;
        }
        Console.WriteLine("Patient not found.");
    }

}