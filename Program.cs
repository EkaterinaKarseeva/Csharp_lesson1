//Console.WriteLine("Hello, World!");

//int value = 100;
//Console.WriteLine(value);

//double d = 5.55;
//char c = '!';
//bool b = true;
//Console.WriteLine(d);
//Console.WriteLine(c);
//Console.WriteLine(b);

int i1 = 5;
int i2 = 6;
int sum = i1 + i2;
//Console.WriteLine(sum);

//long l1 = 6;
//long sum2 = l1 + i1;
//Console.WriteLine(sum2);

//double d1 = 5.5;
//double sum3 = d1 + i1;

//int product1 = i1 * i2;
//long product2 = l1 * i1;
//double product3 = i1 * d1;
//Console.WriteLine(product1);
//Console.WriteLine(product2);
//Console.WriteLine(product3);

//int n = 693;

//int firstdigit = n / 100;
//int thirddigit = n % 10;

//int answer = firstdigit * 10 + thirddigit;

//Console.WriteLine($"{firstdigit} {thirddigit}");

//int number = 123;
//int n1 = number % 100;
//int n2 = n1 / 10;
//int n3 = number % 10;

//Console.WriteLine(n2);
//Console.WriteLine(n3);

 
        Console.WriteLine("Введите число для проверки:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (number % 7 == 0 && number % 23 == 0)
            {
                Console.WriteLine($"{number} кратно одновременно 7 и 23");
            }
            else
            {
                Console.WriteLine($"{number} не кратно одновременно 7 и 23");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
        }
    