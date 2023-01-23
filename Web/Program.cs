using FactorialService;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

FactorialServicer factorialService = new FactorialServicer();
app.MapGet("/", () => "Insert a number in the url like 'localhost:5000/1");

app.MapGet("/{i}", (int i) => printResult(i));

string printResult(int i)
{
    return "Factorial of " + i + " is " + factorialService.calcFactorial(i);
}
app.Run();
