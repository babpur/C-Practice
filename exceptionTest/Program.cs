using System;

namespace exceptionTest
{
    internal class Program
    {
        static void Main(string[] args){
            Console.Write("나눌 숫자를 입력하세요: ");
            int num = int.Parse(Console.ReadLine());

            try{
                Console.WriteLine(10 / num);
                
            } catch(Exception e) {
                Console.WriteLine("예외: " + e.Message);
                Console.ReadLine();
            }
        }
    }
}
