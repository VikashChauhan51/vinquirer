namespace VInquirer.Console;
public interface IScreenManager
{
    int[,] RenderMultipleMessages(string[] messages);
    int[] Render(string[] content, string[] bottomContent);
    void Clean(int initialPos, int endPos);
    string ReadLine();
    void Newline();
    IInputObservable GetInputObservable();
}
