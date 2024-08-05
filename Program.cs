using PruebaC_sharp_SimonArias.Models;

void ShowMenu()
{
    Console.WriteLine(@$"1. Save Dog
    2. Save Cat
    3. Update Dog
    4. Update Cat
    5. Delete Dog
    6. Delete Cat
    7. Show All Patients
    8. Show Animals
    9. Show Patient
    0. Exit");

    int option;
    do
    {
        Console.Write("Choose an option: ");
        option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                SaveDog();
                break;
            case 2:
                SaveCat();
                break;
            case 3:
                UpdateDog();
                break;
            case 4:
                UpdateCat();
                break;
            case 5:
                DeleteDog();
                break;
            case 6:
                DeleteCat();
                break;
            case 7:
                ShowAllPatients();
                break;
            case 8:
                ShowAnimals();
                break;
            case 9:
                ShowPatient();
                break;
            case 0:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
    } while (true);
}

Dog SaveDog()
{
    Console.WriteLine("Enter dogś Id:");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter dog's name: ");
    string name = Console.ReadLine();
    Console.Write("Enter dog's birthdate (dd/MM/yyyy): ");
    string birthdateString = Console.ReadLine();
    DateOnly birthdate = DateOnly.Parse(birthdateString);
    Console.Write("Enter dog's breed: ");
    string breed = Console.ReadLine();
    Console.Write("Enter dog's color: ");
    string color = Console.ReadLine();
    Console.Write("Enter dog's weight (in kg): ");
    double weightInKg = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter dog's breeding status (true/false): ");
    bool breedingStatus = Convert.ToBoolean(Console.ReadLine());
    Console.Write("Enter dog's temperament: ");
    string temperament = Console.ReadLine();
    Console.WriteLine("Enter dog's microchip number:");
    string microchipNumber = Console.ReadLine();
    Console.Write("Enter dog's bark volume: ");
    string barkVolume = Console.ReadLine();
    Console.Write("Enter dog's coat type: ");
    string? coatType = Console.ReadLine();
    return new Dog(id, name, birthdate, breed, color, weightInKg, breedingStatus, temperament, microchipNumber, barkVolume, coatType);
}
Cat SaveCat()
{
    Console.WriteLine("Enter catś Id:");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter cat's name: ");
    string name = Console.ReadLine();
    Console.Write("Enter cat's birthdate (dd/MM/yyyy): ");
    string birthdateString = Console.ReadLine();
    DateOnly birthdate = DateOnly.Parse(birthdateString);
    Console.Write("Enter cat's breed: ");
    string breed = Console.ReadLine();
    Console.Write("Enter cat's color: ");
    string color = Console.ReadLine();
    Console.Write("Enter cat's weight (in kg): ");
    double weightInKg = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter cat's breeding status (true/false): ");
    bool breedingStatus = Convert.ToBoolean(Console.ReadLine());
    Console.Write("Enter cat's fur length: ");
    string? furLength = Console.ReadLine();
    return new Cat(id, name, birthdate, breed, color, weightInKg, breedingStatus, furLength);
}
void UpdateDog()
{
    Console.WriteLine("Enter dog's Id to update:");
    int id = Convert.ToInt32(Console.ReadLine());
    Dog? dogToUpdate = Dog.Dogs.Find(dog => dog.GetId() == id);
    if (dogToUpdate!= null)
    {
        Console.Write("Enter dog's new name: ");
        dogToUpdate.SetName(Console.ReadLine());
        Console.Write("Enter dog's new birthdate (dd/MM/yyyy): ");
        string newBirthdateString = Console.ReadLine();
        dogToUpdate.SetBirthdate(DateOnly.Parse(newBirthdateString));
        Console.Write("Enter dog's new breed: ");
        dogToUpdate.SetBreed(Console.ReadLine());
        Console.Write("Enter dog's new color: ");
        dogToUpdate.SetColor(Console.ReadLine());
        Console.Write("Enter dog's new weight (in kg): ");
        dogToUpdate.SetWeightInKg(Convert
    }
}
void UpdateCat()
{

}
void DeleteDog()
{

}
void DeleteCat()
{

}
void ShowAllPatients()
{
    Console.WriteLine("Dogs:");
    foreach (var dog in Dog.Dogs)
    {
        Console.WriteLine($"ID: {dog.GetId}, Nombre: {dog.GetName}");
    }
    Console.WriteLine("Cats:");
    foreach (var cat in Cat.Cats)
    {
        Console.WriteLine($"ID: {cat.GetId}, Nombre: {cat.GetName}");
    }
}
void ShowAnimals()
{
    Console.WriteLine("Dogs:");
    foreach (var dog in Dog.Dogs)
    {
        dog.ShowInformation();
    }
    Console.WriteLine("Cats:");
    foreach (var cat in Cat.Cats)
    {
        cat.ShowInformation();
    }
}
void ShowPatient()
{

}


ShowMenu();