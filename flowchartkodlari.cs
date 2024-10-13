namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmis ededin faktorialini tapin.
            int number = 5;
            int hasil = 1;

            for (int i =1;i <=number;)
            {
                hasil *= i;
                i++;
            }

            Console.WriteLine("faktoriali  " + hasil);


            //Verilmiş 278 ədədinin rəqəmləri cəmini tapın (2+7+8 <-- bunu tapan alqoritm yazmalısınız).
            int number1 = 278;
            int sum = 0;

            while (number1 > 0)
            {
                sum += number1 % 10;
                number1 /= 10;
            }
            Console.WriteLine("reqemleri cemi  " + sum );


            //Verilmis ededin reqemlerinin hasilini tapin.
            int number2 = 254;
            int hasil2 = 1;

            while ( number2>0)
            {
                hasil2 *= number2 % 10;
                number2 /= 10;
            }
            Console.WriteLine("reqemleri hasili  " + hasil2);





        }
    }
}
