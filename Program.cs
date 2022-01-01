using System ;
namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            // 1den baslayarak consoledan girilen sayiya kadar (sayi dahil) ortalama hesaplayip console a yazdiran program
            Console.WriteLine("Lutfen bir sayi giriniz");
            int number = int.Parse(Console.ReadLine()) ;
            int _counter = 1;
            int sum = 0 ;
            while (_counter <= number)
                {
                    sum+= _counter ;
                    _counter++;

                }
            Console.WriteLine(sum/number) ;

            // 'a' dan 'z' ye kadar tum harfleri consolea yazdir.
            char character = 'a' ;
            while( character < 'z')
                {
                    Console.WriteLine(character) ;
                    character ++ ;

                }   
            Console.WriteLine("****Foreach****") ;
            string [] arabalar = {"BMW" , "Ford" , "Toyota", "Nissan"} ;
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba) ;
            }
                }
    }

}