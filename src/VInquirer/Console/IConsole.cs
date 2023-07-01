
namespace VInquirer.Console;
public interface IConsole
{
    void WriteLine(string value);
    void Write(string value);
    string ReadLine();
    ConsoleKeyInfo ReadKey();
    ConsoleKeyInfo ReadKey(bool intercept);
    int CursorLeft { get; set; }
    int CursorTop { get; set; }
    int WindowWidth { get; set; }
    bool KeyAvailable { get; }
}
