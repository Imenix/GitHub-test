using System;

namespace GitHub_test
{
    internal class Calculator
    {
        public Calculator()
        {
            run();
        }

        public void run()
        {
            Console.WriteLine("Ange ett tal: ");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange ett räknesätt: ");
            string inputCalc = Console.ReadLine();
            Console.WriteLine("Ange ett andra tal: ");
            int input2 = int.Parse(Console.ReadLine());
	    int result;

            switch (inputCalc) // Switchar inputCalc
            {
                case "+" : 
                    result=add(input1, input2);
		    Console.WriteLine(result);
                    break;
                   case "-" : 
                    result=Subtract(input1, input2);
                    break;

                case "/" : 
                    result=Divide(input1, input2);
		    Console.WriteLine(result);
                    break;
                   case "*" : 
                    result=multiply(input1, input2);
		    Console.WriteLine(result);
                    break;


                default:
                    break;
            }
        }

        public int multiply(int input1, int input2)
        {
            int answer = input1 * input2;
            return answer;

        }
        public int add(int a, int b) // Josefin
        {
            int answer = a + b;
            return answer;

        }
        public int Subtract(int a, int b)  // Jonas
        {
            int result = a - b;
            return result;
        }

        public double powerOf(int a, int b)  // Josefin
        {
            double answer = Math.Pow(a, b);
            return answer;
        }
        public int Divide(int a, int b)  // Jonas
        {
            int result = a / b;
            return result;
        }
        //hej
    }
}
