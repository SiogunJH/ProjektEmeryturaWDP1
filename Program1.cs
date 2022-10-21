using System;
class Zadanie1
{
    static void Main1()
    {
        //Console.Write("Nazwisko: ");
        string surname = Console.ReadLine();
        //Console.Write("Wiek: ");
        int age = int.Parse(Console.ReadLine());
        //Console.Write("Wiek Emerytalny: ");
        int retirementAge = int.Parse(Console.ReadLine());

        string message = $"Witaj, {surname}!\n";
        if (age < 0 || retirementAge < 0)
        {
            message += "Wiek nie może być ujemny!";
        }
        else if (age < retirementAge)
        {
            message += $"Do emerytury brakuje Ci {retirementAge - age} lat!";
        }
        else
        {
            message += "Jesteś emerytem!";
        }

        Console.WriteLine(message);
    }
}