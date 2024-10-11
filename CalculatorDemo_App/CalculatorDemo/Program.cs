
using CalculatorLibrary;
using CalculatorDemo;


List<double> numbers = new List<double>();

"Welcome user to my Calculator_Demo App!!".PrintToConsole();
string input = "";
while(input.ToLower() != "quit")
{
    double answer;
    "Choose one of the following(or enter 'quit'): ".PrintToConsole();
    input = "(+, -, /, *, %, ^):  ".RequestString();
    if(input.ToLower() == "quit")
    {
        break;
    }

    switch (input)
    {
        case "+":
            numbers = "Please input numbers: ".RequestNumbers();
            answer = numbers.AddNumbers();
            answer.PrintToConsole();
            Console.Write("\n");
            break;
        case "-":
            numbers = "Please input numbers: ".RequestNumbers();
            answer = numbers.MinusNumbers();
            answer.PrintToConsole();
            break;
        case "/":
            numbers = "Please input numbers: ".RequestNumbers();
            answer = numbers.DivideNumbers();
            answer.PrintToConsole();
            break;
        case "*":
            numbers = "Please input numbers: ".RequestNumbers();
            answer = numbers.TimesNumbers();
            answer.PrintToConsole();
            break;
        case "%":
            numbers = "Please input numbers: ".RequestNumbers();
            answer = numbers.ModulusNumbers();
            answer.PrintToConsole();
            break;
        case "^":
            double baseNum = "Please enter basenumber: ".RequestDouble();
            double expoNum = "Please enter exponent: ".RequestDouble();
            answer = Calculations.ToThePower(baseNum, expoNum);
            answer.PrintToConsole();
            break;
        default:
            "Put in valid Format:".PrintToConsole();
            Console.WriteLine();
            break;
    }
}

Console.ReadLine();