namespace FirstCoreWebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            builder.services.AddMvc();

            app.MapGet("/", () => "Welcome to .NET 6");

            app.Run();
        }
    }
}