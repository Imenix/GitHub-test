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

        }

            

        }

        public int multiply(int input1, int input2)
        {
            int answer = input1 * input2;
                return answer;


        public int add(int a, int b) // Josefin
        {
            int answer = a + b;
            return answer;

        }
	    public int subtract ( int a, int b)  // Jonas
	    {
		     int result = a- b;
		    return result;
	    }
    }
}
