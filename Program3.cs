using System;
class Zadanie3
{
    static void Main3()
    {

        //Wczytanie danych i przekształcenie ich
        string inputData = Console.ReadLine();
        string surname = inputData.Split(' ')[0];
        int age = int.Parse(inputData.Split(' ')[1]);
        int retirementAge = int.Parse(inputData.Split(' ')[2]);

        //Wyświetlanie rezultatów
        string message = $"Witaj {surname}! ";
        if (age < 0 || retirementAge < 0)
            message = "Wiek nie może być ujemny!";
        else if (age < retirementAge)
        {
            if (retirementAge - age == 1)
                message += $"Do emerytury brakuje Ci {retirementAge - age} rok!";
            else if ((retirementAge - age) % 10 >= 2 && (retirementAge - age) % 10 <= 4 && (retirementAge - age) / 10 != 1)
                message += $"Do emerytury brakuje Ci {retirementAge - age} lata!";
            else
                message += $"Do emerytury brakuje Ci {retirementAge - age} lat!";
        }
        else
            message = $"Witaj emerycie {surname}!";

        Console.WriteLine(message);

    }
}