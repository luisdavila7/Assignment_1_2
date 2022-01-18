using System;

namespace Assignment_1_2
{
    internal class Program
    {
        static void numberCalculator()
        {
            int option;
            double number1, number2;

            Console.WriteLine("Number Calculator");
            Console.Write("Insert a Number 1: ");
            number1 = double.Parse(Console.ReadLine());
            Console.Write("Insert a Number 2: ");
            number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("|--Menu Operations--|");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Division");
            Console.WriteLine("4. Multiplication");
            Console.WriteLine("5. Residual");
            Console.WriteLine("6. Pow");
            Console.WriteLine("7. Square Root");
            Console.WriteLine("8. Exit");

            do
            {
                Console.WriteLine("Select the Operation that you want: ");
                option = int.Parse(Console.ReadLine());
            } while (option != 1 && option != 2 && option != 3 && option != 4 && option != 5 && option != 6 && option != 7 && option != 8);

            switch (option)
            {
                case 1:
                    Console.WriteLine("The result of the Addition is: {0}", (number1+number2).ToString("F2"));
                    break;
                case 2:
                    Console.WriteLine("The result of the Subtraction is: {0}", (number1-number2).ToString("F2"));
                    break;
                case 3:
                    Console.WriteLine("The result of the Division is: {0}", (number1/number2).ToString("F2"));
                    break;
                case 4:
                    Console.WriteLine("The result of the Multiplication is: {0}", (number1*number2).ToString("F2"));
                    break;
                case 5:
                    Console.WriteLine("The result of the Residual is: {0}", (number1%number2).ToString("F2"));
                    break;
                case 6:
                    Console.WriteLine("The result of the Pow is: {0}", (Math.Pow(number1,number2)).ToString("F2"));
                    break;
                case 7:
                    Console.WriteLine("The result of the Square Root for the values: {0}, {1} are: {2}, {3}", number1, number2, Math.Sqrt(number1).ToString("F2"), Math.Sqrt(number2).ToString("F2"));
                    break;
                case 8:
                    Console.WriteLine("Exiting the aplication");
                    break;
                default:
                    Console.WriteLine("Exiting the aplication");
                    break;
            }
            
        }

        static void matrixCalculator()
        {



            /*         int[,] matrix1 = new int[3,3];
                       int[,] matrix2 = new int[3,3];
                       int[,] matrix3 = new int[3,3];

                       for (int i = 0; i < 3; i++)
                       {
                           Console.WriteLine("Matrix Calculator");
                           Console.Write("Insert a Row {i} (please separated by space): ");
                           string string_matrix1 = Console.ReadLine();
                           string[] word1 = string_matrix1.Split(" ");

                           matrix1[i,0] = int.Parse(word1[0]);
                           matrix1[i,1] = int.Parse(word1[1]);
                           matrix1[i,2] = int.Parse(word1[2]);

                       }*/

            for(int i = 0; i < 3; i++){

                Console.Write("Insert a Row {0} (please separated by space): ");
                string[] Matrix1 = (Console.ReadLine().Split(' '));

                double 



            }



            Console.Write("Insert a Row 2 (please separated by space): ");
            string[] row2 = (Console.ReadLine().Split(' '));

            Console.Write("Insert a Row number 3 (please separated by space): ");
            string[] row3 = (Console.ReadLine().Split(' '));
            Console.WriteLine("{0}, {1}, {2}", row3);


            Convert.ToInt32(row2);
            Convert.ToInt32(row3);

            // Console.WriteLine("{0}, {1}", Convert.ToInt32(row1[0]* row2[0]));

        }

        static void Main(string[] args)
        {
            int option;

            Console.WriteLine("Application Calculator");
            Console.WriteLine("|--------Menu--------|");
            Console.WriteLine("1. Number Calculator");
            Console.WriteLine("2. Matrix Calculator");
            Console.WriteLine("3. Exit");

            do
            {

                Console.WriteLine("Select a option: ");
                option = int.Parse(Console.ReadLine());

            } while (option != 1 && option != 2 && option != 3);

            switch (option)
            {
                case 1:
                    numberCalculator();
                    break;
                case 2:
                    matrixCalculator();
                    break;
                case 3:
                    Console.WriteLine("Hasta la vista!!");
                    break;


            }

        }
    }
}
