using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite; //подключили через проект - Nu Get - в поиске System.data.SQLite

namespace Data_Base_SQLite_Example
{
    internal class Program
    {

        static void AddData(string name, int age)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=test.db; "); // открываем файл для БД
            connection.Open(); // открыли для записи

            //запрос на создание базы данных
            var querry = @"CREATE TABLE IF NOT EXIST Person( 
                       id INT,
                       name NVARCHAR,
                       age INT)";
            var cmd = new SQLiteCommand(querry, connection);
            //cmd.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("TAble created");

        }
        static void Main(string[] args)
        {
            AddData("Nikita", 12);
            Console.ReadLine();
        }
    }
}
