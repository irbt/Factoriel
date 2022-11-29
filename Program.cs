// Given a non-negative integer, write a method that returns factorial of a number.

namespace Program{
    class FactorialTask{
        public static void Main(string [] args){
            Console.Clear();
            static long Factorial(int number){
                
                  return  number ==0 || number==1 ? 1 : number * Factorial(number-1);
                 
            }
        //Console.WriteLine (Factorial(4));// → 24
        //Console.WriteLine (Factorial(7));// → 5040
        Console.WriteLine(Factorial(5));  // 120
            Console.WriteLine(Factorial(9));  // 1
            Console.WriteLine(Factorial(14)); // 87178291200
            Console.WriteLine(Factorial(0));  // 1
            Console.WriteLine(Factorial(20)); // 2432902008176640000
        }
    }
}