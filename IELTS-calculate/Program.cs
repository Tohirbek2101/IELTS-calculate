using System;
using System.Reflection.Metadata;

namespace IELTS_calculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int shape = 1;
            Console.WriteLine("Assalomu alaykum! Dasturimizga hush kelibsiz.");
            do
            {
                Console.WriteLine("Ushbu dastur sizning IELTS imtihonidan olgan umumiy balingizni chiqarib beradi...");
                Console.WriteLine("So'ralgan ma'lumotlarni kiritishingizni so'rab qolamiz...");
               
                Console.Write("Listening ballingizni kiriting: ");
                double listening = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Reading ballingizni kiriting: ");
                double reading = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Writing ballingizni kiriting: ");
                double writing = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Speaking ballingizni kiriting: ");
                double speaking = Convert.ToDouble(Console.ReadLine());
                
                Process process = new Process();
                
                process.CalculateOveral(listening, reading, writing, speaking);
               
                Console.WriteLine($"\nSizning IELTS bo‘yicha umumiy balingiz: {process.result}");
                Console.WriteLine("Dasturdan foydalanilganingiz uchun rahmat!");
                
                Console.WriteLine("1. Dasturni davom ettirish");
                Console.WriteLine("0. Dasturdan chiqish");
                
                shape = Convert.ToInt32(Console.ReadLine());
            } while (shape != 0);
        }
    }
}