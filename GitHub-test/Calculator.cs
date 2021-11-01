using System;

namespace GitHub_test
{
    internal class Calculator
    {
        public Calculator()
        {

            run();

            
        }

        private void run()
        {
            Console.WriteLine("Ange ett tal: ");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange ett räknesätt: ");
            string inputCalc = Console.ReadLine();
            Console.WriteLine("Ange ett andra tal: ");
            int input2 = int.Parse(Console.ReadLine());

        }
	public int Subtract ( int a, int b)
	{
		int result = a- b;
		return result;


	}
    }
}
