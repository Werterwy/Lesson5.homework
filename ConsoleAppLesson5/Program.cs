using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson5
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* 1.Перехватить исключение запроса к несуществующему веб ресурсу и вывести сообщение о
             * том, что произошла ошибка.Программа должна завершиться без ошибок.*/
            try
            {
                using (var client = new WebClient())
                {
                    string url = "https://example.com/nonexistent";
                    string result = client.DownloadString(url);
                    Console.WriteLine("Запрос выполнен успешно.");
                }
            }
            // Перехватываем исключение при ошибке HTTP-запроса
            catch (WebException ex)
            {
                
                Console.WriteLine("Произошла ошибка при запросе к веб-ресурсу: " + ex.Message);
            }
            // Обработка других исключений
            catch (Exception ex)
            {
                
                Console.WriteLine("Произошла неизвестная ошибка: " + ex.Message);
            }
            Console.WriteLine("");


            /*  2.Написать программу, которая обращается к элементам массива по индексу и выходит 
                 за его пределы. После обработки исключения вывести в финальном блоке сообщение о завершении обработки массива.*/
            try
            {
                int[] mass = { 1, 2, 3 };
                mass[3] = 5;


            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Произошла ошибка при обращении к элементам массива, который выходит за его пределы: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла неизвестная ошибка: " + ex.Message);

            }
          
            finally { Console.WriteLine("завершении обработки массива"); }
           


        }

    }
}
