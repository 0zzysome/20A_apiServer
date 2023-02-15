
WebApplication app = WebApplication.Create();

app.Urls.Add("http://localhost:3000");
app.Urls.Add("http://*:3000");

Ball b = new Ball();

b.Color = "green";
b.Size = 10;
b.DoesBounce = true;

//när get körs ativera metoden.
app.MapGet("/", Answer);

app.MapGet("/ball/{ballColor}", (string ballColor) => 
{ 
b.Color = ballColor;    
return b;
} );

app.MapGet("/mult/{number},{number2}", (int number, int number2) =>
{
    return (number * number2).ToString();
});
app.MapGet("/sub/{number},{number2}", (int number, int number2) =>
{
    return (number - number2).ToString();
});

app.MapGet("/div/{number},{number2}", (int number, int number2) =>
{
    double result = number/number2;
    return (result).ToString();
});
app.Run(); 

static string Answer()
{
    return "hello ";
}