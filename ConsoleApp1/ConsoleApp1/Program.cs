namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pierwszy program - rozgrzewka

            //zadanie 1

             Console.WriteLine("Podaj swoje imię:");
             var name = Console.ReadLine();
             Console.WriteLine("Hello " + name);

            //zadanie 2

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

                // Zadanie 4 - Operacje matematyczne
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
            }
        }
    }
}