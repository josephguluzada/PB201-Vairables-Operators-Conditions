namespace PB201VariablesOperatorsDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment
            //Console.WriteLine(10);

            //int number = 10;

            //Console.WriteLine(number); // 10

            //number = 20;

            //Console.WriteLine(number); //20

            //int number2 = number;

            //Console.WriteLine("Number2: " + number2);

            //int number = 5;

            //number += 5;   //number = number + 5;

            //int number2 = 20;
            //number2 /= 5; //number2 = number2 / 5;

            //Console.WriteLine(number2);

            //var result = 4000 % 7000;


            //Console.WriteLine(result);
            #endregion

            #region Arithmetic 

            //int number1 = 5;

            //int number2 = 6;

            //int sum = number1 + number2; //18
            //sum = number1 - number2; // -1
            ////sum = number1/number2;
            //sum = number1*number2;
            //sum = number1%number2;

            //Console.WriteLine(sum);

            //int number3 = 10;

            //Console.WriteLine(number3--); // number+=1 // number = number + 1
            //Console.WriteLine(--number3);
            //number3 -= 7;
            //Console.WriteLine("final result: " + number3);

            #endregion

            #region Comparison

            //int number1 = 55;
            //int number2 = 6;
            //var result = number1> number2;
            //result = number1 < number2;
            //result = number1 <= number2;
            //result = number1 >= number2;
            //result = number1 != number2;
            //result = number1 == number2;
            //Console.WriteLine(result);

            #endregion

            #region Logical

            //int number1 = 5;
            //int number2 = 6;

            //var result = !(number1 < number2  && number1 <= number2);
            //result = number1 == number2 || number1 < number2;

            //Console.WriteLine(result);
            #endregion

            #region Naming Conventions
            //int myNumberIsOdd = 99; // camelCase
            //int salam_millet = 0; // snake_case
            //int MyNumberIsEven = 2; // PascalCase
            #endregion

            //int humanAge = 19;

            //if(humanAge > 18)
            //{
            //    Console.WriteLine("Krediti aldiniz!");
            //}
            //else if(humanAge == 18)
            //{
            //    Console.WriteLine("HBD*** Krediti aldiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Get yasini tamamla gelersen!");
            //}


            //var number = 98;

            //if(number % 2 == 0)
            //{
            //    Console.WriteLine($"{number} is even");
            //}
            //else
            //{
            //    Console.WriteLine(number + " is odd");
            //}

            for(int i  = 1; i <=100; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i+" is cut");
                }
                else
                {
                    Console.WriteLine($"{i} is tek");
                }
            }



        }
    }
}
