using System.IO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}


if (app.Environment.IsDevelopment())
{
    String filePath = @"C:\Users\ahmedamma\Documents\data_csv.csv";
    try
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;

            while((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }


    }
    catch(Exception ex)
    {
        Console.WriteLine(ex);
    }


}


if (app.Environment.IsProduction())
{
    String filePath = @"C:\Users\ahmedamma\Documents\planets.csv";
    try
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }


    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
    }


}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
