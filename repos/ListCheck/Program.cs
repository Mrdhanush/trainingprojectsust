using Microsoft.EntityFrameworkCore;
using AllocateResourceAPI.Data;
using AllocateResourceAPI.Repository;

namespace AllocateResourceAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Register services to the DI container
            builder.Services.AddControllers();

            builder.Services.AddDbContext<ResourceAllContext>(options =>
              options.UseSqlServer(builder.Configuration.GetConnectionString("Def")));

            // Ensure the configuration is loaded to access appsettings.json

            // Check if connection string is null or empty
        

        

            // Register repository interface and implementation
            builder.Services.AddScoped<IResourceListRepository, ResourceListRepository>();

            // Add Swagger for API documentation
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
