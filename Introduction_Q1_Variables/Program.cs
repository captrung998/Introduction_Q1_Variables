using System;

class Program
{

    static void Main(string[] args)
    {
        // Part 1: Create variables of different types, assign values to them, and print them to the console
        // Hint: Use the Console.WriteLine() method to print the string to the console.
        // Create variables of different types and assign values to them using a consistent naming convention.
        // Use the following variable types: int, double, string, bool, char, byte, long, decimal, float.

        int enemy_health = 100;
        double game_currency = 2500.50;
        string player_name = "John Doe";
        bool isalive = true;
        char patrol_state = 'S';
        byte player_age = 25;
        long score = 1000000000;
        decimal price = 100.50m;
        float speed = 100.50f;
        Console.WriteLine("enemy_health" + enemy_health + "\n" +
            "\ngame_currency " + game_currency +
            "\nplayer_name " + player_name +
            "\nisalive " + isalive +
            "\npatrol_state " + patrol_state +
            "\nplayer_age " + player_age +
            "\nscore " + score +
            "\nprice " + price +
            "\nspeed " + speed);
        // Part 17: Declaration of Constants
        // Write a C# program to declare a constant integer variable representing the value of Pi.
        // Hint: Use the const keyword to declare the constant.
        // Test data: const double Pi = 3.14159;
        const double Pi = 3.14159;
        Console.WriteLine("The value of Pi is: " + Pi);
        // Part 18: Declaration of Constants
        // Write a C# program to declare a constant string variable representing the name of a company.
        // Hint: Use the const keyword to declare the constant.
        // Test data: const string CompanyName = "ABC Corporation";
        const string CompanyName = "ABC Corporation";
        Console.WriteLine("The name of the company is: " + CompanyName);

        // Part 19: Declaration of Constants
        // Write a C# program to declare a constant integer variable representing the maximum number of retries for a network request.
        // Hint: Use the const keyword to declare the constant.
        // Test data: const int MaxRetries = 3;
        const int MaxRetries = 3;
        Console.WriteLine("The maximum number of retries is: " + MaxRetries);


        // Part 20: Declaration of Constants
        // Write a C# program to declare a constant double variable representing the acceleration due to gravity.
        // Hint: Use the const keyword to declare the constant.
        // Test data: const double Gravity = 9.8;
        const double Gravity = 9.8;
        Console.WriteLine("The acceleration due to gravity is: " + Gravity);

        // Part 21: Declaration of Constants
        // Write a C# program to declare a constant integer variable representing the number of months in a year.
        // Hint: Use the const keyword to declare the constant.
        // Test data: const int MonthsInYear = 12;
        const int MonthsInYear = 12;
        Console.WriteLine("The number of months in a year is: " + MonthsInYear);
    }
}





