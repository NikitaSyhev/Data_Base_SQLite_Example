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
- 7)connection.close(); - закрыли
