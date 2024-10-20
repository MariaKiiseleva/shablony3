namespace sh_lab_3;

public interface IReader : IDisposable
{
    public string ReadLine(int number);
}