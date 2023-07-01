// See https://aka.ms/new-console-template for more information
using VInquirer.Prompts;
using VInquirer.Validators;
using VInquirer;

Sample1();
Sample2();


 static void Sample1()
{
    var numbersOnly = new RegexValidator("^[0-9]*$");
    var nameInput = new Input("name", "What is your name?");
    var ageInput = new Input("age", "What is your age?", numbersOnly);
    var passwordInput = new PasswordInput("password", "What is the password?");

    var inquirer = new Inquirer(nameInput, ageInput, passwordInput);

    inquirer.Ask();

    System.Console.WriteLine($@"Hello {nameInput.Answer()}! Your age is {ageInput.Answer()}");
    System.Console.WriteLine($@"Secret password: {passwordInput.Answer()}!");
    System.Console.ReadKey();
}
 static void Sample2()
{
    var options = new string[] { "Option 1", "Option 2" };
    var listInput = new ListInput("option", "Which option?", options);
    var sureInput = new InputConfirmation("confirm", "Are you sure?");

    var inquirer = new Inquirer(listInput, sureInput);

    inquirer.Ask();

    var answer = listInput.Answer();
    Console.WriteLine($@"You have selected option: {answer} - {options[Int32.Parse(answer) - 1]}");
    Console.WriteLine(sureInput.Answer() == "y" ? "And you are sure!" : "And you are not sure!");
    Console.ReadKey();
}
