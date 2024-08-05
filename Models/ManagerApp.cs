using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_SimonArias.Models;

public class ManagerApp
{
    //método crear nuevo perro
    public Dog CreateDog()
    {
        return new Dog();
    }
    //método crear nuevo gato
    public Cat CreateCat()
    {
        return new Cat();
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
