using System;

namespace String_Arrayinde_string_in_movcudlugunun_yoxlanilmasi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = { "Asus", "Hp", "DELL", "Acer" };
            string a = Console.ReadLine();
            for (int i = 0; i < strArr.Length; i++)
            {  if( strArr[i] == a)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
