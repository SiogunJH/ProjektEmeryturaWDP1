﻿using System;
class Zadanie2
{
    static void Main2()
    {
        //Console.Write("Nazwisko: ");
        string surname = Console.ReadLine();
        //Console.Write("Wiek: ");
        int age = int.Parse(Console.ReadLine());
        //Console.Write("Wiek Emerytalny: ");
        int retirementAge = int.Parse(Console.ReadLine());

        string message = $"Witaj, {surname}!\n";
        if (age < 0 || retirementAge < 0)
            message += "Wiek nie może być ujemny!";
        else if (age < retirementAge)
        {
            if (retirementAge - age == 1)
                message += $"Do emerytury brakuje Ci {retirementAge - age} rok!";
            else if ((retirementAge - age) % 10 >= 2 && (retirementAge - age) % 10 <= 4)
                message += $"Do emerytury brakuje Ci {retirementAge - age} lata!";
            else
                message += $"Do emerytury brakuje Ci {retirementAge - age} lat!";
        }
        else
            message += "Jesteś emerytem!";

        Console.WriteLine(message);
    }
}