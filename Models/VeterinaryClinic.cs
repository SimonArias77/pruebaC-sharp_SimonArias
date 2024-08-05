using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_SimonArias.Models;

public class VeterinaryClinic
{
    // propiedades de la clase VeterinaryClinic
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Dog> Dogs { get; set; }
    public List<Cat> Cats { get; set; }
    // constructor de la clase VeterinaryClinic
    public VeterinaryClinic(string name, string address, List<Dog> dogs, List<Cat> cats)
    {
        Name = name;
        Address = address;
        Dogs = new List<Dog>();
        Cats = new List<Cat>();
    }
    // método para guardar un nuevo perro
    public void SaveDog(Dog newDog)
    {
        Dogs.Add(newDog);
        Console.WriteLine("Perro guardado");
    }
    // método para guardar un nuevo gato
    public void SaveCat(Cat newCat)
    {
        Cats.Add(newCat);
        Console.WriteLine("Gato guardado");
    }
    // método para actualizar perro
    public void UpdateDog(Dog dog)
    {
        Console.WriteLine("Perro actualizado");
    }
    // método para actualizar gato
    public void UpdateCat(Cat cat)
    {
        Console.WriteLine("Gato actualizado");
    }
    // método para eliminar perro
    public void DeleteDog(int id)
    {
        Dogs.RemoveAt(id);
        Console.WriteLine("Perro eliminado");
    }
    // método para eliminar gato
    public void DeleteCat(int id)
    {
        Cats.RemoveAt(id);
        Console.WriteLine("Gato eliminado");
    }
    // método para mostrar todos los pacientes
    public void ShowAllPatients()
    {
        Console.WriteLine("Perros:");
        foreach (var dog in Dogs)
        {
            Console.WriteLine($"ID: {dog.GetId}, Nombre: {dog.GetName}");
        }
        Console.WriteLine("Gatos:");
        foreach (var cat in Cats)
        {
            Console.WriteLine($"ID: {cat.GetId}, Nombre: {cat.GetName}");
        }
    }
    // método para mostrar animales
    public void ShowAnimals(string type)
    {
        if (type == "dog")
        {
            Console.WriteLine("Perros:");
            foreach (var dog in Dogs)
            {
                Console.WriteLine($"ID: {dog.GetId}, Nombre: {dog.GetName}");
            }
        }
        else if (type == "cat")
        {
            Console.WriteLine("Gatos:");
            foreach (var cat in Cats)
            {
                Console.WriteLine($"ID: {cat.GetId}, Nombre: {cat.GetName}");
            }
        }
        else
        {
            Console.WriteLine("Tipo de animal no válido");
        }
    }
    // método para mostrar un paciente con id
    public void ShowPatient(int idPatient)
    {
        Dog? dogFound = Dogs.Find(dog => dog.GetId() == idPatient);
        Cat? catFound = Cats.Find(cat => cat.GetId() == idPatient);
        if (dogFound != null)
        {
            dogFound.ShowInformation();
        }
        else if (catFound != null)
        {
            catFound.ShowInformation();
        }
        else
        {
            Console.WriteLine("No se encontró el paciente");
        }
    }
}
