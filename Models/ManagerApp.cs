using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_SimonArias.Models;

public class ManagerApp
{
    // métodos de la clase ManagerApp para mostrar encabezado, pie de pagina y separadores
    public static void ShowHeader()
    {
        Console.WriteLine("       Veterinary Clinic App      ");
    }

    public static void ShowFooter()
    {
        Console.WriteLine("          End of Report           ");
    }

    public static void ShowSeparator()
    {
        Console.WriteLine("----------------------------------");
    }
}
