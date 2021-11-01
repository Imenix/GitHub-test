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

        public int add(int a, int b) // Josefin
        {
            int answer = a + b;
            return answer;
        }
	public int Subtract ( int a, int b)  // Jonas
	{
		int result = a- b;
		return result;
	}
    }
}
