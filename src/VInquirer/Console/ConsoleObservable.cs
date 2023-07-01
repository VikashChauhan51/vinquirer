
using System.Reactive.Concurrency;
using System.Reactive.Linq;

namespace VInquirer.Console;
public class ConsoleObservable : IInputObservable
{
    public static ConsoleKey[] DigitsKeys = new ConsoleKey[]{ ConsoleKey.D0,
                                                                ConsoleKey.D1,
                                                                ConsoleKey.D2,
                                                                ConsoleKey.D3,
                                                                ConsoleKey.D4,
                                                                ConsoleKey.D5,
                                                                ConsoleKey.D6,
                                                                ConsoleKey.D7,
                                                                ConsoleKey.D8,
                                                                ConsoleKey.D9 };

    private readonly IConsole console;
    private IScheduler scheduler;
    private IObservable<ConsoleKeyInfo> input;
    private IEnumerable<ConsoleKeyInfo> ConsoleInput
    {
        get
        {
            while (true)
            {
                yield return console.ReadKey(false);
            }
        }
    }
    private IEnumerable<ConsoleKeyInfo> ConsoleInputIntercept
    {
        get
        {
            while (true)
            {
                yield return console.ReadKey(true);
            }
        }
    }
    public ConsoleObservable(IConsole console, IScheduler scheduler = null)
    {
        this.console = console;
        this.scheduler = scheduler ?? CurrentThreadScheduler.Instance;
        input = ConsoleInput.ToObservable(this.scheduler)
                            .Do(ImplementKeysBehaviours)
                            .Publish()
                            .RefCount();
    }

    public IObservable<ConsoleKeyInfo> GetEnterObservable()
    {
        return input.Where(x => x.Key == ConsoleKey.Enter);
    }

    public IObservable<string> GetLineObservable()
    {
        return input.TakeUntil(GetEnterObservable())
                    .Where(IsNormalKey)
                    .Aggregate("", BuildLine);
    }

    public IObservable<ConsoleKeyInfo> TakeUntilEnter()
    {
        return input.TakeUntil(GetEnterObservable());
    }

    private string BuildLine(string content, ConsoleKeyInfo newKey)
    {
        if (newKey.Key == ConsoleKey.Backspace)
            return content == "" ? content : content.Remove(content.Length - 1);

        return content + newKey.KeyChar;
    }

    public IObservable<ConsoleKeyInfo> KeyPress()
    {
        return input;
    }

    public bool IsNormalKey(ConsoleKeyInfo key)
    {
        var hasShift = key.Modifiers.HasFlag(ConsoleModifiers.Shift);
        if (!hasShift) return true;

        return !isDigit(key.Key);
    }

    private void ImplementKeysBehaviours(ConsoleKeyInfo cki)
    {
        var key = cki.Key;
        switch (key)
        {
            case ConsoleKey.Backspace:
                console.Write(" \b");
                break;
        };
        var hasShift = cki.Modifiers.HasFlag(ConsoleModifiers.Shift);
        if (hasShift && isDigit(key)) console.Write("\b");
    }

    public void Intercept(bool intercept)
    {
        var inputToUse = intercept ? ConsoleInputIntercept : ConsoleInput;
        input = inputToUse.ToObservable(scheduler)
                          .Do(ImplementKeysBehaviours)
                          .Publish()
                          .RefCount();
    }

    public static bool isDigit(ConsoleKey key)
    {
        return DigitsKeys.Contains(key);
    }
}
