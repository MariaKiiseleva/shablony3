namespace sh_lab_3;

public class Reader : IReader
{
    private Textreader? Textreader { get; set; } // считыватель данных из файла
    private Dictionary<string, string> Users { get; set; } // словарь для кеша

    public Reader()
    {
        Users = new Dictionary<string, string>();
    }

    public string ReadLine(int number)
    {
        // считывание данных из кеша
        var result = Users.ContainsKey(number.ToString()) ? Users[number.ToString()] : null;
        if (result is not null) return result;

        // если данных не обнаружено, то обращаемся к файлу
        Textreader ??= new Textreader();

        result = Textreader.ReadLine(number);
        Users.Add(number.ToString(), result);

        return result; 
    }

    public void Dispose()
    {
        Textreader?.Dispose();
    }
}