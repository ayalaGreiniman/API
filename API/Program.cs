
using _2_services;
using _2_services.Interfaces;
using _2_services.Services;

namespace API
{
            
    public class Program 
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            //builder.Services.AddServices();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IPersonService, PersonService>();
            builder.Services.AddScoped<IChildService, ChildService>();
            builder.Services.AddRepoDependencies();
            var app = builder.Build();
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }

        //protected override Task ExecuteAsync(CancellationToken stoppingToken)
        //{
        //    throw new NotImplementedException();
        //}
    }
}