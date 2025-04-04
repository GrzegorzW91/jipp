﻿namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pierwszy program - rozgrzewka

            //Zadanie1

             //Console.WriteLine("Podaj swoje imię:");
             //var name = Console.ReadLine();
             //Console.WriteLine("Hello " + name);

            //Zadanie2

             int result = 5 + 9;

            {
                //Operatory
                //Zadanie1
                int number = 10;
                float money = 99.99f;
                string text = "Hello, world!";
                bool isLogged = true;
                char myChar = 'A';
                decimal price = 199.99m;

                
                Console.WriteLine("Number: " + number);
                Console.WriteLine("Money: " + money);
                Console.WriteLine("Text: " + text);
                Console.WriteLine("Is Logged: " + isLogged);
                Console.WriteLine("My Char: " + myChar);
                Console.WriteLine("Price: " + price);

                //Zadanie2
                string myAge = "Age:33 ";
                int wifeAge = 18;

              
                string resultage = myAge + wifeAge;

               
                Console.WriteLine("Result: " + resultage);


                //Wnioski:
                //C# nie pozwala na bezpośrednie dodawanie zmiennej string i int w sensie matematycznym.
                //W tym przypadku następuje konkatenacja (łączenie) wartości, a nie matematyczne dodawanie.

                // Zadanie3
                bool isTrue = true;
                bool isFalse = false;
                bool isReallyTrue = true;

                bool and = isTrue && isFalse;
                bool or = isTrue || isReallyTrue;
                bool negative = !isFalse;

                
                Console.WriteLine("AND: " + and);
                Console.WriteLine("OR: " + or);
                Console.WriteLine("NEGATIVE: " + negative);

                // Zadanie4 
                int a = 5;
                int b = 12;

                int add = a + b;
                int sub = a - b;
                int div = a / b;
                int mul = a * b;
                int mod = a % b;

               
                Console.WriteLine("ADD: " + add);
                Console.WriteLine("SUB: " + sub);
                Console.WriteLine("DIV: " + div);
                Console.WriteLine("MUL: " + mul);
                Console.WriteLine("MOD: " + mod);

                // Zadanie5
                string aText = "Ala ";
                string bText = "ma ";
                string cText = "kota.";

                string resultText = aText + bText + cText;

                // Wyświetlenie wyniku
                Console.WriteLine("Result: " + resultText);

                // Spostrzeżenia:
                // Wynik operacji to "Ala ma kota." ponieważ operacja + dla stringów łączy je w jeden ciąg znaków.
                // Warto dodać spacje na końcu pierwszych dwóch stringów, aby wynik wyglądał poprawnie.

                //Instrukcje sterujące i pętle

                //Zadanie1
                
                int n1 = 10;
                int n2 = 20;

                if (n1 > n2)
                {
                    Console.WriteLine($"{n1} jest większe od {n2}");
                }
                else if (n1 < n2)
                {
                    Console.WriteLine($"{n2} jest większe od {n1}");
                }
                else
                {
                    Console.WriteLine($"{n1} jest równe {n2}");
                }

                // Zadanie2
                
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("C#");
                }

                
                int count = 0;
                while (count < 10)
                {
                    Console.WriteLine("C#");
                    count++;
                }

                // Zadanie3
                int n = 10;
                for (int i = 0; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"{i} - Parzysta");
                    }
                    else
                    {
                        Console.WriteLine($"{i} - Nieparzysta");
                    }
                }
                // Zadanie4
                int gN = 5; 
                for (int i = 1; i <= gN; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                int gn = 3;
                for (int i = 1; i <= gn; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }

                // Zadanie5
                int exam = 88;

                if (exam < 0 || exam > 100)
                {
                    Console.WriteLine("Wartość poza zakresem.");
                }
                else if (exam <= 39)
                {
                    Console.WriteLine("Ocena Niedostateczna");
                }
                else if (exam <= 54)
                {
                    Console.WriteLine("Ocena Dopuszczająca");
                }
                else if (exam <= 69)
                {
                    Console.WriteLine("Ocena Dostateczna");
                }
                else if (exam <= 84)
                {
                    Console.WriteLine("Ocena Dobra");
                }
                else if (exam <= 98)
                {
                    Console.WriteLine("Ocena Bardzo Dobra");
                }
                else
                {
                    Console.WriteLine("Ocena Celująca");
                }
                //Kolekcje
                // Zadanie1 
                string[] colors = { "Niebieski", "Zielony", "Żółty", "Czerwony" };
                Console.WriteLine($"Mój pierwszy kolor to: {colors[0]}");
                Console.WriteLine($"Mój ostatni kolor to: {colors[colors.Length - 1]}");

                // Zadanie 2 
                int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                Console.WriteLine("\n--- Pętla for ---");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine($"Liczba: {numbers[i]}");
                }

                Console.WriteLine("\n--- Pętla foreach ---");
                foreach (int number2 in numbers)
                {
                    Console.WriteLine($"Liczba: {number2}");
                }

                Console.WriteLine("\n--- Pętla while ---");
                int index = 0;
                while (index < numbers.Length)
                {
                    Console.WriteLine($"Liczba: {numbers[index]}");
                    index++;
                }
                // Zadanie 3 
                List<string> fruits = new List<string> { "Pomidor", "Jabłko", "Marchewka", "Banana" };
                Console.WriteLine("\nLista owoców przed usunięciem:");
                Console.WriteLine(string.Join(", ", fruits));

                // Usuwanie pierwszego i ostatniego elementu
                fruits.RemoveAt(0); // usuwa "Pomidor"
                fruits.RemoveAt(fruits.Count - 1); // usuwa ostatni element ("Banana")

                Console.WriteLine("\nLista owoców po usunięciu:");
                Console.WriteLine(string.Join(", ", fruits));
            }

        }
    }
}