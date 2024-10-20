namespace sh_lab_3;

public class Textreader : IReader
{
    public string ReadLine(int number)
    {
        Console.WriteLine("Открыт файл"); //отслеживание открытия файла
        var streamReader = new StreamReader("Users.txt");
        var line = streamReader.ReadLine();
        while (line is not null)
        {
            if (line.Split(';')[0] == number.ToString())
            {
                return line.Split(';')[1]; // возвращение нужного значения
            }

            line = streamReader.ReadLine();
        }

        streamReader.Close();
        throw new Exception("Пользователь неизвестен"); // ошибка если строка не найдена
    }

    public void Dispose()
    {
    }
}