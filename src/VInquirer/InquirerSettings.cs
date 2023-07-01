namespace VInquirer;
public sealed record InquirerSettings
{
    public ConsoleColor BackgroundColor { get; init; } = ConsoleColor.Black;
    public ConsoleColor DefaultTextColor { get; init; } = ConsoleColor.White;
    public ConsoleColor ErrorTextColor { get; init; } = ConsoleColor.Red;
    public ConsoleColor QuestionTextColor { get; init; } = ConsoleColor.Yellow;
    public ConsoleColor OptionTextColor { get; init; } = ConsoleColor.DarkGray;
    public ConsoleColor SelectedOptionTextColor { get; init; } = ConsoleColor.Cyan;
}
