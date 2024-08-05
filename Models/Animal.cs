using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_SimonArias.Models;

public class Animal
{
    // propiedades de la clase Animal
    protected int Id { get; set; }
    protected string? Name { get; set; }
    protected DateOnly Birthdate { get; set; }
    protected string? Breed { get; set; } // raza
    protected string? Color { get; set; }
    protected double WeightInKg { get; set; }
    // se crean métodos para quitar encapsulamiento de id y de name
    public int GetId()
    {
        return Id;
    }
    public string? GetName()
    {
        return Name;
    }
    // se crean metodos para quitar encapsulamiento de birthdate, breed, color, weightInKg
    public DateOnly GetBirthdate()
    {
        return Birthdate;
    }
    public string? GetBreed()
    {
        return Breed;
    }
    public string? GetColor()
    {
        return Color;
    }
    public double GetWeightInKg()
    {
        return WeightInKg;
    }
    // constructor de la clase Animal
    public Animal(int id, string name, DateOnly birthdate, string? breed, string? color, double weightInKg)
    {
        Id = id;
        Name = name;
        Birthdate = birthdate;
        Breed = breed;
        Color = color;
        WeightInKg = weightInKg;
    }

    // lista o coleccion de animales
    public static List<Animal> Animals { get; } = new List<Animal>();
    // método para agregar animal a la lista
    public static void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
    }
    // método para eliminar animal de la lista
    public static void DeleteAnimal(int id)
    {
        Animals.RemoveAt(id);
    }
    // método mostrar información
    public void ShowInformation()
    {
        Console.WriteLine($"ID: {Id}, Nombre: {Name}, Fecha de nacimiento: {Birthdate}, Raza: {Breed}, Color: {Color}, Peso: {WeightInKg} kg");
    }
    // método Basic Review (revisión básica)
    protected void BasicReview()
    {
        Console.WriteLine("Revisión básica:");
        Console.WriteLine($"ID: {Id}, Nombre: {Name}, Fecha de nacimiento: {Birthdate}");
    }
    // método calcular edad en meses
    protected int CalculateAgeInMonths(DateOnly today)
    {
        var age = today.Year - Birthdate.Year;
        if (today.Month < Birthdate.Month || (today.Month == Birthdate.Month && today.Day < Birthdate.Day))
        {
            age--;
        }
        return age * 12 + today.Month - Birthdate.Month;
    }

}
