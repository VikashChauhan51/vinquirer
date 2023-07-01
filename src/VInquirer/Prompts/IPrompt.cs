using VInquirer.Console;

namespace VInquirer.Prompts;
public interface IPrompt
{
    int[] Render();
    Parm[] GetQuestion();
    string Answer();
    void Ask();
    bool IsValidAnswer(string answer);
}
