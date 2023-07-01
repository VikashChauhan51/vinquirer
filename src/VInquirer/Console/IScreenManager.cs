namespace VInquirer.Console;
public interface IScreenManager
{
    int[,] RenderMultipleMessages(Parm[] messages);
    int[] Render(Parm[] content, Parm[] bottomContent);
    void Clean(int initialPos, int endPos);
    string ReadLine();
    void Newline();
    IInputObservable GetInputObservable();
}
