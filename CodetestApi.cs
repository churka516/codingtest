var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

async static Task<int> Listify(int start, int end, int index)
{
    return ((IEnumerable<int>)Enumerable.Range(start, end)).ElementAt(index);
}


app.MapGet("/listify", async (int start, int end, int index) =>
{
    return await Listify(start,end,index);
});

app.Run();
