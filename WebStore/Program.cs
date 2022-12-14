using System;

namespace WebStore
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            // �������� ���������� �� ����� ������������
            // �������� ���������� ������������

            var configuration = app.Configuration;

            //���������� ���������

            var greetings = configuration["CustomGreetings"];

            app.MapGet("/", () => greetings);

            app.Run();

        }
    }
}

