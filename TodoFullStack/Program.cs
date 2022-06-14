using System.Text;
using TodoFullStack.Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/todos", () =>
{
    return new[]{
        new TodoItem
        {
            Text = "Lage middag"
        },
        new TodoItem
        {
            Text = "Trene"
        },
    };
});
app.UseStaticFiles();
app.Run();


//var txt = new StringBuilder()
//    .AppendLine("Hei")
//    .AppendLine("P�")
//    .AppendLine("Deg")
//    .ToString();
//    ;