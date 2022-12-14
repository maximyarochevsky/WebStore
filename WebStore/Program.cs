using System;

namespace WebStore
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            // Загрузка информации из файла конфигурации
            // Создание переменной конфигурации

            var configuration = app.Configuration;

            //Переменная параметра

            var greetings = configuration["CustomGreetings"];

            app.MapGet("/", () => greetings);

            app.Run();

        }
    }
}

