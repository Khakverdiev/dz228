// Task 1
//int number = 0;

//Console.WriteLine("Введите число от 1 до 100: ");
//number = Convert.ToInt32(Console.ReadLine());

//if (number >= 1 && number <= 100)
//{
//    if (number % 3 == 0 && number % 5 == 0)
//    {
//        Console.WriteLine("Fizz Buzz");
//    }
//    if (number % 3 != 0 && number % 5 == 0) 
//    {
//        Console.WriteLine("Buzz");
//    }
//    if (number % 3 == 0 && number % 5 != 0)
//    {
//        Console.WriteLine("Fizz");
//    }
//    if (number % 3 != 0 && number % 5 != 0)
//    {
//        Console.WriteLine(number);
//    }
//}
//else
//{
//    Console.WriteLine("Error");
//}

// Task 2
//decimal number = 0.0m;

//Console.WriteLine("Введите температуру: ");
//number = Convert.ToDecimal(Console.ReadLine());

//Console.WriteLine("1.Цельсии");
//Console.WriteLine("2.Фаренгейт");
//byte choice = Convert.ToByte(Console.ReadLine());

//if (choice == 1)
//{
//    Console.WriteLine((number - 32) * 5 / 9);
//}
//else if (choice == 2)
//{
//    Console.Write(number * 9 / 5 + 32);
//}
//else
//{
//    Console.WriteLine("Error");
//}

// Task 3
//Console.WriteLine("Введите диапазон: ");
//int numb1 = Convert.ToInt32(Console.ReadLine());
//int numb2 = Convert.ToInt32(Console.ReadLine());

//for (int i = numb1; i <= numb2; i++)
//{
//    if (i % 2 == 0)
//        Console.WriteLine(i);
//}

//for (int i = numb2; i <= numb1; i++)
//{
//    if (i % 2 == 0)
//        Console.WriteLine(i);
//}

// Task 4
//Console.WriteLine("Введите число: ");
//int numb1 = Convert.ToInt32(Console.ReadLine());
//int numb2 = 0;

//for(; numb1 > 0;)
//{
//    numb2 = numb2 * 10 + numb1 % 10;
//    numb1 /= 10;
//}

//Console.WriteLine(numb2);

// Task 5
//Console.WriteLine("Введите диапазон: ");
//int digit = Convert.ToInt32(Console.ReadLine());

//int first = 1;
//Console.WriteLine(first);
//int second = 1;
//Console.WriteLine(second);
//int sum = 0;

//while(digit > sum)
//{
//    sum = first + second;
//    Console.WriteLine(sum);
//    first = second;
//    second = sum;
//}

// Task 6
//int A = 3;
//int B = 7;

//for (int i = A; i <= B; i++)
//{
//    for (int j = 0; j < i; j++)
//    {
//        Console.Write(i + " ");
//    }
//    Console.WriteLine();
//}

// Task 7
//Console.WriteLine("Введите длину линии: ");
//int len = Convert.ToInt32(Console.ReadLine());
//char symb = '+';
//Console.WriteLine("1. Вертикально");
//Console.WriteLine("2. Горизонтально");
//byte choice = Convert.ToByte(Console.ReadLine());

//if (choice == 1)
//{
//    for (int i = 0; i < len; i++)
//    {
//        Console.WriteLine(symb);
//    }
//}
//else if (choice == 2)
//{
//    for (int i = 0; i < len; i++)
//    {
//        Console.Write(symb);
//    }
//}
//else
//{
//    Console.WriteLine("Error");
//}
