using FactorialService;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

FactorialServicer factorialService = new FactorialServicer();
app.MapGet("/{i}", (int i) => printResult(i));

string printResult(int i)
{
    return "Factorial of " + i + " is " + factorialService.calcFactorial(i);
}
app.Run();
