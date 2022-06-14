using System.Text;
using TodoFullStack.Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var todoItems = new List<TodoItem>() {
    new TodoItem{Text = "Lage middag"},
    new TodoItem{Text = "Trene"}
};

app.MapGet("/todo", () =>
{
    return todoItems;
});
app.MapPut("/todo/{id}", (Guid id) =>
{
    var todoItem = todoItems.FirstOrDefault(t => t.Id == id);
    todoItem.Done = DateTime.Now;
});


app.UseStaticFiles();
app.Run();


//var txt = new StringBuilder()
//    .AppendLine("Hei")
//    .AppendLine("På")
//    .AppendLine("Deg")
//    .ToString();
//    ;