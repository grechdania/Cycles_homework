// FIRST TASK:

//Console.WriteLine("Enter the ammount of workers");
//int workers = Int32.Parse(Console.ReadLine());
//int worker_sallary;
//int total = 0;
//int avarage;

//for (int i = 1; i != workers + 1; i++)
//{
//    Console.WriteLine($"Enter the sallary of worker number {i}");
//    worker_sallary = Int32.Parse(Console.ReadLine());
//    total = total + worker_sallary;

//}

//avarage = total / workers;
//Console.WriteLine($"Avarage sallary is {avarage}");






// SECOND TASK:

//Console.WriteLine("Enter the length of one line of stars");
//int length = Int32.Parse(Console.ReadLine());
//Console.WriteLine("Enter the ammount lines");
//int lines = Int32.Parse(Console.ReadLine());

//for (int i = 0; i <= lines; i++)
//{
//   for(int j = 0; j <= length; j++)
//    {
//        Console.Write("*");
//    }

//   Console.Write("\n");
//}






//THIRD TASK

//Console.WriteLine("Enter the maximum number");
//int max = Int32.Parse(Console.ReadLine());

//if (max == 3)
//{
//    Console.WriteLine("2, 3");
//}   
//else if (max == 2)
//{
//    Console.WriteLine("2");
//}
//else
//{
//    Console.Write("2, 3, ");

//    for (int i = 2; i <= max; i++)
//    {

//        bool prime = true;

//        for (int j = 2; j <= i / 2; j--)
//        {
//            if (i % j == 0)
//            {
//                prime = false;
//                break;
//            }
//            if (prime == true)
//            {
//                    Console.Write($"{i}, ");
//            }
//        }

//    }
//}





//FORTH TASK

//using static System.Runtime.InteropServices.JavaScript.JSType;

//Console.WriteLine("Enter your password");
//string password = Console.ReadLine();
//bool contains_special = false;



//for (int i = 0; i < password.Length; i++)        
//    {
//     switch (password[i])
//        {
//            case '!':
//                contains_special = true;
//                break;
//            case '#':
//                contains_special = true;
//                break;
//            case '@':
//                contains_special = true;
//                break;
//        }
//    }
//if (!int.TryParse(password, out int number))
//{
//    Console.WriteLine("The password does not contain numbers");
//    return;
//}
//if (contains_special == false)
//{
//    Console.WriteLine("The password does not contain special symbols");
//    return;
//}
//if (password.Length < 8)
//{
//    Console.WriteLine("password is too short");
//    return;
//}

//Console.WriteLine("Your password is alright");




//FIFITH TASK

//--------------------------




//SIXTH TASK

//Console.WriteLine("Enter the ammount of hours worked this day");
//int hours = Int32.Parse(Console.ReadLine());

//if (hours > 24)
//{
//    Console.WriteLine("The ammount of hours worked per day can not be more than 24";
//}

//Console.WriteLine("Enter the hourly wage in $");
//int wage = Int32.Parse(Console.ReadLine());

//int sum = hours * wage;
//Console.WriteLine($"Maney received this working day: {sum}$");




//SEVENTH TASK

//using System.Diagnostics.CodeAnalysis;

//Console.WriteLine("Enter your number");
//int number = Int32.Parse(Console.ReadLine());

//for (int i = 1; i <= 10; i++)
//{
//    int sum = number * i;
//    Console.WriteLine($"{number} x {i} = {sum}");
//}




//EIGTHS TASK

Console.WriteLine("Enter the number");
int number = Int32.Parse(Console.ReadLine());
if (number == 0 || number == 1)
{
    Console.WriteLine($"{number} is not a prime number");
    return;
}
else
{
    for (int i = 2; i <= number / 2; i++)
    {
        if (number % i == 0)
        {
            Console.WriteLine("${number} is not a prime number");
            return;
        }

    }
    Console.WriteLine($"{number} is a prime number");
}

