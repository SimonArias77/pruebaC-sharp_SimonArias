using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_SimonArias.Models;

public class ManagerApp
{
    public Dog CreateDog()
    {
        return new Dog();
    }
    public Cat CreateCat()
    {
        return new Cat();
    }
    public void ShowHeader()
    {
        Console.WriteLine("Welcome to the Veterinary Clinic");
    }
    public void ShowFooter()
    {
        Console.WriteLine("Thank you for using our services");
    }
    public void ShowSeparator()
    {
        Console.WriteLine("--------------------");
    }

}
