# Data_Base_SQLite_Example
Простой пример создания  Базы Данных
Алгорит базы данных:

1) Выбрать базу данных
2) Импорт пакета NuGet
Project - ManageNugetPackage
3) В поиске написать System.Data.SQLLite
4) Указать простарноство имен Syste.Data.SQlite
5) В идеале сделать отдельный класс для базы данных
6) далее
- string path = @"Data Source = test.db;" - путь к файлу
- создаем переменную var connect - new SQLliteConnection(); - создали объект для подключения базы данных
- connection.Open(); - открыли коннект с базой данных
 - ConsoleWriteline($"Создано подключение {connect}.ToString();})

- создадим запрос
- string name = "FRODO", age = "23";
- string querry = @"CREATE TABLE IF NOT EXISTS Person (
- id INTEGER PRIMARY KEY AUTOINCREMENT,
- name NVARCHAR,
- ahe INT);"

$"\nINSERT INTO Person(name, age) VALUES ('{name}');

-ConsoleWriteline(querry);
-var cmd = new SQLliteConnection(querry, connection);
- cmd.ExecuteNonQuerry();  - это метод, который используется для выполнения команды SQL, которая не возвращает никаких данных, таких как INSERT, UPDATE, DELETE и другие. Он возвращает количество строк, которые были затронуты выполнением команды. 
- cdm.ExecuteScalar(); - - это метод, который используется для выполнения команды SQL, которая возвращает единственное значение (например, количество строк в таблице или значение определенного столбца).
- cmd.ExecuteReader(); -  это метод, который используется для выполнения команды SQL, которая возвращает набор строк данных из базы данных.

- 7)connection.close(); - закрыли
