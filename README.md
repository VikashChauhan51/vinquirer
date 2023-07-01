# VInquirer
A collection of common interactive command line user interfaces.

## Quick Start Example:

``` C#
using VInquirer.Prompts;
using VInquirer.Validators;
using VInquirer;

// create input prompts and validators
var numbersOnly = new RegexValidator("^[0-9]*$");
var nameInput = new Input("name", "What is your name?");
var ageInput = new Input("age", "What is your age?", validator: numbersOnly);
var passwordInput = new PasswordInput("password", "What is the password?");

// create inquirer with input prompts
var inquirer = new Inquirer(nameInput, ageInput, passwordInput);

// takes user inputs

inquirer.Ask();

// display user inputs

foreach (var ans in inquirer.Answers())
{
    System.Console.WriteLine(ans);
}

```
## Options Example:

``` C#
using VInquirer.Prompts;
using VInquirer.Validators;
using VInquirer;

// create input prompts and validators
var options = new string[] { "Option 1", "Option 2" };
var listInput = new ListInput("option", "Which option?", options);
var sureInput = new InputConfirmation("confirm", "Are you sure?");

// create inquirer with input prompts
var inquirer = new Inquirer(listInput, sureInput);

// takes user inputs

inquirer.Ask();

// display user inputs

foreach (var ans in inquirer.Answers())
{
    System.Console.WriteLine(ans);
}

```

## Custom Console Colors Settings Example:

``` C#
using VInquirer.Prompts;
using VInquirer.Validators;
using VInquirer;


var settings = new InquirerSettings
{
    BackgroundColor = ConsoleColor.Black,
    DefaultTextColor = ConsoleColor.White,
    ErrorTextColor = ConsoleColor.Red,
    QuestionTextColor = ConsoleColor.Yellow,
    OptionTextColor = ConsoleColor.DarkGray,
    SelectedOptionTextColor = ConsoleColor.Cyan
};

// create input prompts and validators
var options = new string[] { "Option 1", "Option 2" };
var listInput = new ListInput("option", "Which option?", options,settings: settings);
var sureInput = new InputConfirmation("confirm", "Are you sure?",settings: settings with { QuestionTextColor = ConsoleColor.Cyan });

// create inquirer with input prompts
var inquirer = new Inquirer(listInput, sureInput);

// takes user inputs

inquirer.Ask();

// display user inputs

foreach (var ans in inquirer.Answers())
{
    System.Console.WriteLine(ans);
}

```