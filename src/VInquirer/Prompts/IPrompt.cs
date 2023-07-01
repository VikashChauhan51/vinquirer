namespace VInquirer.Prompts;
public interface IPrompt
{
    int[] Render();
    string[] GetQuestion();
    string Answer();
    void Ask();
    bool IsValidAnswer(string answer);
}
