using System;
using System.Net;
using System.Runtime.Serialization;

namespace ConsoleApp1
{
    class ImDown
    {

        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string url;
            string filescape = @"C:\\ImageImDown\\Im";
            string name;

            Console.WriteLine("ВНИМАТЕЛЬНО: создай на диске 'C' папку с именем 'ImageImDown'. Все изображения будут сохраняться в данной папке. Не повторяй названия изображений.");
            Console.WriteLine("Ссылка на твою папку должна выглядеть так: 'C:'\'ImageImDown' ");



            do
            {

                Console.WriteLine("Укажи имя файла");

                name = Console.ReadLine();
                string namefile = name + ".png";



                url = "https://picsum.photos/200/300";


                {
                    client.DownloadFile(url, filescape + namefile);
                }

                Console.WriteLine("Что бы скачать еще одно изображение - дай новое, уникальное имя:");


            } while (true);




        }
    }
}
